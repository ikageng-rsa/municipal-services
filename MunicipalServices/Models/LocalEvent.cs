using System;

namespace MunicipalServices.Models
{
    /// <summary>
    /// A community event hosted or promoted by the municipality.
    /// </summary>
    public class LocalEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
