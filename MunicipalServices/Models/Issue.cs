using System;
using System.Collections.Generic;

namespace MunicipalServices.Models
{
    /// <summary>
    /// A single citizen-reported issue, as captured by the Report Issues form.
    /// </summary>
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> AttachmentPaths { get; set; } = new List<string>();
        public DateTime SubmittedAt { get; set; } = DateTime.Now;
    }
}
