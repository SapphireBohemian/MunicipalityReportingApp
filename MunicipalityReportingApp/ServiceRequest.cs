using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ServiceRequest.cs
namespace MunicipalityReportingApp
{
    public class ServiceRequest
    {
        public string Id { get; set; } // Unique identifier for the request
        public string Description { get; set; } // Description of the issue
        public string Status { get; set; } // Current status of the request
        public DateTime SubmissionDate { get; set; } // Date when the request was submitted

        public ServiceRequest(string id, string description, string status, DateTime submissionDate)
        {
            Id = id;
            Description = description;
            Status = status;
            SubmissionDate = submissionDate;
        }
    }

    public static class ReportedRequests
    {
        public static List<ServiceRequest> RequestsList = new List<ServiceRequest>();

        public static void Add(ServiceRequest request)
        {
            RequestsList.Add(request);
        }
    }
}