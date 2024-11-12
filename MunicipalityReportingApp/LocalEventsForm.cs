using LiveCharts;
using LiveCharts.Wpf;  
using LiveCharts.WinForms; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityReportingApp
{
    public partial class LocalEventsForm : Form
    {
        private SortedDictionary<DateTime, List<Event>> eventsByDate = new SortedDictionary<DateTime, List<Event>>();
        private Dictionary<string, string> eventCategoriesMap = new Dictionary<string, string>();
        private RecommendationLogic recommendationLogic = new RecommendationLogic();
        private EventDataStructure eventDataStructure = new EventDataStructure();
        private EventSearch eventSearch = new EventSearch();
        private HashSet<string> uniqueCategories = new HashSet<string>();

        private LiveCharts.WinForms.PieChart pieChart; 

        public LocalEventsForm()
        {
            InitializeComponent();
            InitializePieChart(); 
            LoadEvents();
        }
        private void InitializePieChart()
        {
            
            pieChart = new LiveCharts.WinForms.PieChart
            {
                Dock = DockStyle.Bottom, 
                Height = 200 
            };

            this.Controls.Add(pieChart); 
        }

        private void UpdatePieChart(Dictionary<string, double> categoryData)
        {
            
            var existingCategories = pieChart.Series.Select(s => s.Title).ToList();

            foreach (var category in categoryData)
            {
                if (!existingCategories.Contains(category.Key))
                {
                    
                    pieChart.Series.Add(new PieSeries
                    {
                        Title = category.Key,
                        Values = new ChartValues<double> { category.Value },
                        DataLabels = true
                    });
                }
                else
                {
                    
                    var existingSeries = pieChart.Series.FirstOrDefault(s => s.Title == category.Key);
                    if (existingSeries != null)
                    {
                        existingSeries.Values[0] = category.Value;
                    }
                }
            }
        }

        private void LoadEvents()
        {
            try
            {
                DateTime startDate = new DateTime(2024, 10, 17);
                DateTime endDate = new DateTime(2024, 12, 25);

                // Predefined event names and their correct categories
                Dictionary<string, string> eventMapping = new Dictionary<string, string>
        {
            { "Community Cleanup", "Community Engagement" },
            { "Charity Marathon", "Community Engagement" },
            { "Food Drive", "Community Engagement" },
            { "Neighborhood Watch Program", "Community Engagement" },
            { "Health Expo", "Health & Wellness" },
            { "Blood Donation Camp", "Health & Wellness" },
            { "Fire Safety Demo", "Health & Wellness" },
            { "Environmental Workshop", "Health & Wellness" },
            { "Music Concert", "Entertainment & Culture" },
            { "Art Exhibition", "Entertainment & Culture" },
            { "Film Screening", "Entertainment & Culture" },
            { "Crafts Fair", "Entertainment & Culture" },
            { "Cultural Festival", "Entertainment & Culture" },
            { "Holiday Market", "Commerce & Employment" },
            { "Farmers Market", "Commerce & Employment" },
            { "Job Fair", "Commerce & Employment" },
            { "Entrepreneur Meetup", "Commerce & Employment" },
            { "Public Safety Workshop", "Safety & Technology" },
            { "Cybersecurity Awareness", "Safety & Technology" },
            { "Tech Conference", "Safety & Technology" },
            { "Coding Bootcamp", "Safety & Technology" },
            { "Recycling Drive", "Safety & Technology" }

        };

                Random random = new Random();

                // Generate 3 events for each day, cycling through the predefined event list
                var eventKeys = eventMapping.Keys.ToList();
                int eventCount = eventKeys.Count;

                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    // Select 3 unique random events for each day
                    HashSet<int> selectedIndexes = new HashSet<int>();
                    while (selectedIndexes.Count < 5)
                    {
                        int index = random.Next(eventCount);  
                        if (!selectedIndexes.Contains(index))
                        {
                            string eventName = eventKeys[index];
                            string eventCategory = eventMapping[eventName];
                            AddEvent(date, eventName, eventCategory);  
                            selectedIndexes.Add(index);
                        }
                    }
                }

                // Populate the category dropdown list
                cmbCategory.DataSource = new BindingSource(uniqueCategories.ToList(), null);

                DisplayInitialEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading events: {ex.Message}");
            }
        }

        private void AddEvent(DateTime date, string eventName, string category)
        {
            var newEvent = new Event { Name = eventName, Date = date, Category = category };

            if (!eventsByDate.ContainsKey(date))
            {
                eventsByDate[date] = new List<Event>();
            }
            eventsByDate[date].Add(newEvent);

            
            if (!eventCategoriesMap.ContainsKey(eventName))
            {
                eventCategoriesMap[eventName] = category;
            }

            
            uniqueCategories.Add(category);  

            eventSearch.AddEvent(eventName, category);  
        }

        private void DisplayInitialEvents()
        {
            List<string> allEvents = new List<string>();

            foreach (var dateEvents in eventsByDate)
            {
                foreach (var eventItem in dateEvents.Value)
                {
                    allEvents.Add($"{eventItem.Name}|{dateEvents.Key.ToShortDateString()}|{eventItem.Category}");
                    eventSearch.AddEvent(eventItem.Name, eventItem.Category);
                    eventDataStructure.AddUpcomingEvent(eventItem.Name);
                    recommendationLogic.AddEventToDatabase(eventItem);
                }
            }

            DisplayResults(allEvents);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime? selectedDate = chkDateFilter.Checked ? (DateTime?)dtpDate.Value.Date : null;
            string selectedCategory = cmbCategory.SelectedItem?.ToString();

            List<string> results = SearchEvents(selectedDate, selectedCategory);
            DisplayResults(results);

            foreach (var result in results)
            {
                string[] eventDetails = result.Split('|');
                if (eventDetails.Length == 3)
                {
                    recommendationLogic.LogUserSearch(selectedCategory, eventDetails[0]);
                }
            }

            var categoryFrequency = results
                .GroupBy(r => r.Split('|')[2])
                .ToDictionary(g => g.Key, g => (double)g.Count()); 

            UpdatePieChart(categoryFrequency);
        }


        private List<string> SearchEvents(DateTime? date, string category)
        {
            List<string> results = new List<string>();

            // Search by Date only
            if (date.HasValue && string.IsNullOrEmpty(category))
            {
                if (eventsByDate.TryGetValue(date.Value, out var eventsOnDate))
                {
                    results.AddRange(eventsOnDate.Select(e => $"{e.Name}|{date.Value.ToShortDateString()}|{e.Category}"));
                }
            }
            // Search by Category only
            else if (!date.HasValue && !string.IsNullOrEmpty(category))
            {
                foreach (var dateEvents in eventsByDate)
                {
                    results.AddRange(dateEvents.Value
                        .Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                        .Select(e => $"{e.Name}|{dateEvents.Key.ToShortDateString()}|{e.Category}"));
                }
            }
            // Search by both Date and Category
            else if (date.HasValue && !string.IsNullOrEmpty(category))
            {
                if (eventsByDate.TryGetValue(date.Value, out var eventsOnDate))
                {
                    results.AddRange(eventsOnDate
                        .Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                        .Select(e => $"{e.Name}|{date.Value.ToShortDateString()}|{e.Category}"));
                }
            }

            return results;
        }


        private void DisplayResults(List<string> results)
        {
            dataGridViewEvents.Rows.Clear();

            if (results.Count == 0)
            {
                MessageBox.Show("No events found for the selected criteria.");
                return;
            }

            foreach (var result in results)
            {
                string[] eventDetails = result.Split('|');
                if (eventDetails.Length == 3)
                {
                    dataGridViewEvents.Rows.Add(eventDetails[0], eventDetails[1], eventDetails[2]);
                }
            }


            // Get the selected category as the user's preference for recommendations
            string userCategoryPreference = cmbCategory.SelectedItem?.ToString() ?? "DefaultCategory"; 
            List<string> recommendations = recommendationLogic.GetRecommendations(userCategoryPreference, topN: 1); 
            lblRecommendations.Text = "Recommended Events: " + string.Join(", ", recommendations);

            
        }
        private void dataGridViewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEvents.Rows[e.RowIndex];
                string eventName = row.Cells["Event Name"].Value.ToString();
                string eventDate = row.Cells["Event Date"].Value.ToString();
                string category = row.Cells["Category"].Value.ToString();

                
                MessageBox.Show($"Event: {eventName}, Date: {eventDate}, Category: {category}");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkDateFilter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpRecommendations_Enter(object sender, EventArgs e)
        {

        }
    }

    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
    }
}
