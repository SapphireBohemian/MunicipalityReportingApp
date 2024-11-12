using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalityReportingApp
{
    public class EventDataStructure
    {
        private Stack<string> pastEvents = new Stack<string>();
        private Queue<string> upcomingEvents = new Queue<string>();
        private SortedList<int, string> priorityEvents = new SortedList<int, string>(); 

        public void AddPastEvent(string eventName)
        {
            pastEvents.Push(eventName);
        }

        public string GetLastPastEvent()
        {
            return pastEvents.Count > 0 ? pastEvents.Pop() : "No past events.";
        }

        public void AddUpcomingEvent(string eventName)
        {
            upcomingEvents.Enqueue(eventName);
        }

        public string GetNextUpcomingEvent()
        {
            return upcomingEvents.Count > 0 ? upcomingEvents.Dequeue() : "No upcoming events.";
        }

        public void AddPriorityEvent(int urgency, string eventName)
        {
            priorityEvents.Add(urgency, eventName);
        }

        public string GetMostUrgentEvent()
        {
            return priorityEvents.Count > 0 ? priorityEvents.Values[0] : "No urgent events.";
        }

        public List<string> GetAllPastEvents()
        {
            return pastEvents.ToList();
        }

        public List<string> GetAllUpcomingEvents()
        {
            return upcomingEvents.ToList();
        }

        public List<string> GetAllPriorityEvents()
        {
            return priorityEvents.Values.ToList(); 
        }
    }

}
