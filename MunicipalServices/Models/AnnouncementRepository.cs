using System;
using System.Collections.Generic;
using MunicipalServices.DataStructures;

namespace MunicipalServices.Models
{
    /// <summary>
    /// Holds municipal announcements in a priority queue so the most urgent notices
    /// always surface first, with the newest notice winning ties.
    /// </summary>
    internal static class AnnouncementRepository
    {
        private sealed class UrgencyThenNewestComparer : IComparer<Announcement>
        {
            public int Compare(Announcement x, Announcement y)
            {
                var byUrgency = x.Urgency.CompareTo(y.Urgency);
                return byUrgency != 0 ? byUrgency : y.PostedAt.CompareTo(x.PostedAt);
            }
        }

        private static readonly PriorityQueue<Announcement> _queue =
            new PriorityQueue<Announcement>(new UrgencyThenNewestComparer());

        static AnnouncementRepository()
        {
            SeedAnnouncements();
        }

        public static int Count => _queue.Count;

        public static void Add(Announcement announcement)
        {
            _queue.Enqueue(announcement);
        }

        /// <summary>The announcement that should be shown first.</summary>
        public static Announcement MostUrgent => _queue.Peek();

        /// <summary>All announcements, most urgent first.</summary>
        public static IReadOnlyList<Announcement> GetByPriority()
        {
            return _queue.ToOrderedList();
        }

        private static void SeedAnnouncements()
        {
            var now = DateTime.Now;

            Add(new Announcement
            {
                Title = "Planned water outage",
                Message = "Water supply will be interrupted in Sunridge and surrounding areas on Thursday " +
                          "from 08:00 to 16:00 while a burst main is repaired. Please store water in advance.",
                Urgency = AnnouncementUrgency.Urgent,
                PostedAt = now.AddHours(-3)
            });
            Add(new Announcement
            {
                Title = "Road closure: Main Road",
                Message = "Main Road between Station Street and Church Street is closed for resurfacing until " +
                          "the end of next week. Use Voortrekker Road as an alternative.",
                Urgency = AnnouncementUrgency.Important,
                PostedAt = now.AddHours(-20)
            });
            Add(new Announcement
            {
                Title = "Load shedding schedule update",
                Message = "The updated load shedding schedule is available at the Civic Centre and all " +
                          "municipal libraries.",
                Urgency = AnnouncementUrgency.Important,
                PostedAt = now.AddDays(-1)
            });
            Add(new Announcement
            {
                Title = "Library extended hours",
                Message = "Central Library will stay open until 20:00 on weekdays this month to support " +
                          "learners preparing for exams.",
                Urgency = AnnouncementUrgency.Info,
                PostedAt = now.AddDays(-2)
            });
            Add(new Announcement
            {
                Title = "Refuse collection reminder",
                Message = "Please place bins on the kerb by 06:00 on your collection day. Bins left out " +
                          "overnight may be damaged or stolen.",
                Urgency = AnnouncementUrgency.Info,
                PostedAt = now.AddDays(-4)
            });
        }
    }
}
