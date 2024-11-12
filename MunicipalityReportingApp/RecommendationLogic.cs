using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReportingApp
{
    public class RecommendationLogic
    {
        private Dictionary<string, int> searchCount = new Dictionary<string, int>();
        private Dictionary<string, Event> eventsDatabase = new Dictionary<string, Event>();

        public void LogUserSearch(string category, string eventName)
        {
            string key = $"{category}:{eventName}"; 

            if (searchCount.ContainsKey(key))
            {
                searchCount[key]++;
            }
            else
            {
                searchCount[key] = 1;
            }
        }

        public List<string> GetRecommendations(string userCategoryPreference, int topN = 1)
        {
            // Recommend the most frequently searched events or categories that match the user category preference
            return searchCount
                .Where(pair => pair.Key.StartsWith(userCategoryPreference))
                .OrderByDescending(pair => pair.Value)
                .Select(pair => pair.Key)
                .Take(topN)
                .ToList();
        }



        public Dictionary<string, int> GetSearchData()
        {
            
            return new Dictionary<string, int>(searchCount);
        }


        
        public void AddEventToDatabase(Event eventItem)
        {
            eventsDatabase[eventItem.Name] = eventItem;
        }
    }
}



