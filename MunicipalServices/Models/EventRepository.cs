using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServices.Models
{
    /// <summary>
    /// In-memory catalogue of local events. Each event is indexed several ways so the
    /// UI can retrieve it quickly by id, by category, or in date order.
    /// </summary>
    internal static class EventRepository
    {
        // Hash-based lookup by id: O(1) average.
        private static readonly Dictionary<int, LocalEvent> _byId = new Dictionary<int, LocalEvent>();

        // Hash-based lookup by category (case-insensitive): O(1) average.
        private static readonly Dictionary<string, List<LocalEvent>> _byCategory =
            new Dictionary<string, List<LocalEvent>>(StringComparer.OrdinalIgnoreCase);

        // Keys kept in date order, so events can be walked chronologically without sorting.
        private static readonly SortedDictionary<DateTime, List<LocalEvent>> _byDate =
            new SortedDictionary<DateTime, List<LocalEvent>>();

        // Sets guarantee each category / date is stored only once, however many events share it.
        private static readonly HashSet<string> _categories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private static readonly SortedSet<DateTime> _eventDates = new SortedSet<DateTime>();

        static EventRepository()
        {
            SeedEvents();
        }

        public static int Count => _byId.Count;

        /// <summary>Unique categories, alphabetically.</summary>
        public static IEnumerable<string> Categories => _categories.OrderBy(c => c);

        /// <summary>Unique dates that have at least one event, earliest first.</summary>
        public static IReadOnlyCollection<DateTime> EventDates => _eventDates;

        public static void Add(LocalEvent localEvent)
        {
            var day = localEvent.Date.Date;

            _byId[localEvent.Id] = localEvent;

            if (!_byCategory.TryGetValue(localEvent.Category, out var categoryList))
            {
                categoryList = new List<LocalEvent>();
                _byCategory[localEvent.Category] = categoryList;
            }
            categoryList.Add(localEvent);

            if (!_byDate.TryGetValue(day, out var dayList))
            {
                dayList = new List<LocalEvent>();
                _byDate[day] = dayList;
            }
            dayList.Add(localEvent);

            _categories.Add(localEvent.Category);
            _eventDates.Add(day);
        }

        public static LocalEvent GetById(int id)
        {
            return _byId.TryGetValue(id, out var localEvent) ? localEvent : null;
        }

        public static IReadOnlyList<LocalEvent> GetByCategory(string category)
        {
            return _byCategory.TryGetValue(category, out var list)
                ? (IReadOnlyList<LocalEvent>)list
                : new List<LocalEvent>();
        }

        /// <summary>Events on or after <paramref name="from"/>, in chronological order.</summary>
        public static IEnumerable<LocalEvent> GetUpcoming(DateTime from)
        {
            foreach (var day in _byDate)
            {
                if (day.Key < from.Date)
                    continue;
                foreach (var localEvent in day.Value)
                    yield return localEvent;
            }
        }

        private static void SeedEvents()
        {
            var today = DateTime.Today;
            var id = 1;

            void AddEvent(int daysFromToday, int hour, string title, string category, string location, string description)
            {
                Add(new LocalEvent
                {
                    Id = id++,
                    Title = title,
                    Category = category,
                    Date = today.AddDays(daysFromToday).AddHours(hour),
                    Location = location,
                    Description = description
                });
            }

            AddEvent(2, 10, "Ward Committee Meeting", "Public Meetings", "Civic Centre, Main Hall",
                "Monthly ward meeting where residents can raise service delivery concerns directly with their councillor.");
            AddEvent(3, 9, "Community Clean-Up Day", "Environment", "Riverside Park",
                "Join your neighbours to clear litter along the river. Gloves and refuse bags are provided.");
            AddEvent(5, 8, "Free Health Screening", "Health", "Ubuntu Community Clinic",
                "Free blood pressure, glucose and HIV screening for all residents. No appointment needed.");
            AddEvent(6, 14, "Youth Career Expo", "Education", "Central Library",
                "Meet training providers and employers, and get help with CVs and bursary applications.");
            AddEvent(8, 9, "Water-Wise Gardening Workshop", "Environment", "Botanical Gardens Hall",
                "Learn practical ways to save water at home and grow a drought-resistant garden.");
            AddEvent(8, 18, "Neighbourhood Watch Meeting", "Safety", "Sunridge Community Hall",
                "Report on recent incidents and sign up for the volunteer patrol roster.");
            AddEvent(10, 10, "Heritage Day Street Festival", "Arts & Culture", "Market Square",
                "Live music, traditional food stalls and dance performances celebrating our diverse cultures.");
            AddEvent(12, 15, "Municipal Budget Public Participation", "Public Meetings", "Civic Centre, Council Chamber",
                "Have your say on next year's budget and the priorities for roads, water and electricity.");
            AddEvent(14, 7, "Community 5km Fun Run", "Sports & Recreation", "Sports Complex",
                "A family-friendly fun run open to all ages, with refreshments at the finish line.");
            AddEvent(17, 11, "Recycling Drive", "Environment", "Town Hall Parking Lot",
                "Drop off paper, plastic, glass and e-waste for recycling. Collect a free compost bag.");
            AddEvent(20, 10, "Arts & Crafts Market", "Arts & Culture", "Market Square",
                "Local artists and crafters showcase and sell their work. Free entry.");
            AddEvent(24, 9, "Vaccination Awareness Day", "Health", "Ubuntu Community Clinic",
                "Talks and free child immunisation checks by clinic nurses.");
            AddEvent(28, 16, "Inter-Ward Soccer Tournament", "Sports & Recreation", "Sports Complex",
                "Teams from every ward compete for the mayoral cup. Come and support your ward.");
            AddEvent(35, 10, "Job Seekers Workshop", "Education", "Youth Centre",
                "CV writing, interview skills and information on local learnerships and internships.");
        }
    }
}
