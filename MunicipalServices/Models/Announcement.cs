using System;

namespace MunicipalServices.Models
{
    /// <summary>
    /// How prominently an announcement should be shown. Lower values are more urgent,
    /// which lets the priority queue treat the smallest value as the highest priority.
    /// </summary>
    public enum AnnouncementUrgency
    {
        Urgent = 0,
        Important = 1,
        Info = 2
    }

    /// <summary>
    /// A notice published by the municipality (outages, closures, service updates).
    /// </summary>
    public class Announcement
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public AnnouncementUrgency Urgency { get; set; }
        public DateTime PostedAt { get; set; }
    }
}
