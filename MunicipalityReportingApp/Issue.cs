using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReportingApp
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }

        public Issue(string location, string category, string description, string attachment)
        {
            Location = location;
            Category = category;
            Description = description;
            Attachment = attachment;
        }
    }

    public static class ReportedIssues
    {
        public static List<Issue> IssuesList = new List<Issue>();

        public static void Add(Issue issue)
        {
            IssuesList.Add(issue);
        }
    }
}
