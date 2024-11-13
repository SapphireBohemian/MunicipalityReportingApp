using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MunicipalityReportingApp
{
    public class ServiceRequest
    {
        public string Id { get; set; } 
        public string Description { get; set; } 
        public string Status { get; set; } 
        public DateTime SubmissionDate { get; set; } 

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