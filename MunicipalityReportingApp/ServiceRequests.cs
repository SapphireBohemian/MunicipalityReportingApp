using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReportingApp
{
    public static class ServiceRequests
    {
        public static List<ServiceRequest> RequestsList = new List<ServiceRequest>();

        public static void Add(ServiceRequest request)
        {
            RequestsList.Add(request);
        }

        public static ServiceRequest FindById(string id)
        {
            return RequestsList.Find(request => request.Id == id);
        }
    }
}
