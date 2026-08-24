using System.Collections.Generic;

namespace MunicipalServices.Models
{
    /// <summary>
    /// In-memory store of issues reported during this application session.
    /// </summary>
    internal static class IssueRepository
    {
        private static readonly List<Issue> _issues = new List<Issue>();

        public static IReadOnlyList<Issue> Issues => _issues;

        public static void Add(Issue issue)
        {
            _issues.Add(issue);
        }
    }
}
