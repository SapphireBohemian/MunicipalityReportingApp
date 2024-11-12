using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityReportingApp
{
    public class EventSearch
    {
        private Dictionary<string, string> eventDetails = new Dictionary<string, string>();

        public void AddEvent(string eventName, string eventDescription)
        {
            eventDetails[eventName] = eventDescription;
        }

        public string SearchEvent(string eventName)
        {
            return eventDetails.TryGetValue(eventName, out string description) ? description : "Event not found.";
        }

        public List<string> GetAllEvents()
        {
            return eventDetails.Select(kvp => $"{kvp.Key}: {kvp.Value}").ToList();
        }
    }
}
