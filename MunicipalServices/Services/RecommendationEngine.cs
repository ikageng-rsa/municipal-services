using System;
using System.Collections.Generic;
using System.Linq;
using MunicipalServices.DataStructures;
using MunicipalServices.Models;

namespace MunicipalServices.Services
{
    /// <summary>
    /// A suggested event together with why it was suggested.
    /// </summary>
    public class Recommendation
    {
        public LocalEvent Event { get; set; }
        public double Score { get; set; }
        public string Reason { get; set; }
    }

    /// <summary>
    /// Learns what a user is interested in from their searches and the events they open,
    /// then ranks upcoming events against that profile.
    ///
    /// Scoring for a candidate event:
    ///   interest in its category (searches weigh more than views, recent activity weighs more)
    ///   + a share of the interest in related categories
    ///   + a small bonus for events that are happening soon.
    /// </summary>
    public class RecommendationEngine
    {
        private const int MaxInteractions = 20;
        private const double SearchWeight = 3.0;
        private const double ViewWeight = 1.0;
        private const double RecencyDecay = 0.85;
        private const double RelatedFactor = 0.4;

        /// <summary>Categories that tend to appeal to the same people (symmetric).</summary>
        private static readonly Dictionary<string, HashSet<string>> RelatedCategories = BuildRelatedCategories();

        private struct Interaction
        {
            public string Category;
            public double Weight;
        }

        // Oldest interaction first. Capped so stale behaviour ages out of the profile.
        private readonly Queue<Interaction> _interactions = new Queue<Interaction>();
        private readonly HashSet<int> _viewedEventIds = new HashSet<int>();

        /// <summary>One engine shared for the whole application session.</summary>
        public static RecommendationEngine Shared { get; } = new RecommendationEngine();

        public bool HasHistory => _interactions.Count > 0;

        /// <summary>Records a category search. Searches without a category carry no preference signal.</summary>
        public void RecordSearch(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                return;
            Record(category, SearchWeight);
        }

        /// <summary>Records that the user opened an event to read about it.</summary>
        public void RecordView(LocalEvent localEvent)
        {
            if (localEvent == null)
                return;
            _viewedEventIds.Add(localEvent.Id);
            Record(localEvent.Category, ViewWeight);
        }

        public void Reset()
        {
            _interactions.Clear();
            _viewedEventIds.Clear();
        }

        /// <summary>
        /// Ranks <paramref name="candidates"/> against the user's profile and returns the best
        /// <paramref name="maxResults"/>. Events the user has already opened are left out.
        /// </summary>
        public List<Recommendation> GetRecommendations(IEnumerable<LocalEvent> candidates, DateTime today, int maxResults)
        {
            var results = new List<Recommendation>();
            if (!HasHistory || maxResults <= 0)
                return results;

            var interest = ComputeInterest();

            // Highest score first; the earlier event wins a tie.
            var ranked = new PriorityQueue<Recommendation>(Comparer<Recommendation>.Create((a, b) =>
            {
                var byScore = b.Score.CompareTo(a.Score);
                return byScore != 0 ? byScore : a.Event.Date.CompareTo(b.Event.Date);
            }));

            foreach (var candidate in candidates)
            {
                if (_viewedEventIds.Contains(candidate.Id))
                    continue;

                var direct = interest.TryGetValue(candidate.Category, out var d) ? d : 0.0;
                var relatedScore = 0.0;
                string strongestRelated = null;
                var strongestRelatedInterest = 0.0;

                if (RelatedCategories.TryGetValue(candidate.Category, out var related))
                {
                    foreach (var other in related)
                    {
                        if (!interest.TryGetValue(other, out var value))
                            continue;
                        relatedScore += value * RelatedFactor;
                        if (value > strongestRelatedInterest)
                        {
                            strongestRelatedInterest = value;
                            strongestRelated = other;
                        }
                    }
                }

                if (direct + relatedScore <= 0)
                    continue;

                var daysAway = Math.Max(0, (candidate.Date.Date - today.Date).TotalDays);
                var soonBonus = 1.0 / (1.0 + daysAway / 7.0);

                ranked.Enqueue(new Recommendation
                {
                    Event = candidate,
                    Score = direct + relatedScore + soonBonus,
                    Reason = direct > 0
                        ? $"Because you're interested in {candidate.Category} events"
                        : $"Similar to your interest in {strongestRelated} events"
                });
            }

            while (ranked.Count > 0 && results.Count < maxResults)
                results.Add(ranked.Dequeue());

            return results;
        }

        private void Record(string category, double weight)
        {
            _interactions.Enqueue(new Interaction { Category = category, Weight = weight });
            while (_interactions.Count > MaxInteractions)
                _interactions.Dequeue();
        }

        /// <summary>Sums interaction weights per category, discounting older interactions.</summary>
        private Dictionary<string, double> ComputeInterest()
        {
            var interest = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
            var age = 0;

            foreach (var interaction in _interactions.Reverse())
            {
                var weight = interaction.Weight * Math.Pow(RecencyDecay, age++);
                interest[interaction.Category] =
                    (interest.TryGetValue(interaction.Category, out var existing) ? existing : 0.0) + weight;
            }

            return interest;
        }

        private static Dictionary<string, HashSet<string>> BuildRelatedCategories()
        {
            var map = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);

            void Link(string a, string b)
            {
                if (!map.ContainsKey(a)) map[a] = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                if (!map.ContainsKey(b)) map[b] = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                map[a].Add(b);
                map[b].Add(a);
            }

            Link("Environment", "Health");
            Link("Environment", "Sports & Recreation");
            Link("Health", "Sports & Recreation");
            Link("Public Meetings", "Safety");
            Link("Public Meetings", "Education");
            Link("Education", "Arts & Culture");
            Link("Arts & Culture", "Sports & Recreation");

            return map;
        }
    }
}
