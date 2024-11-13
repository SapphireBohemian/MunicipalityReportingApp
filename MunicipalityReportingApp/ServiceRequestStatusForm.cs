using System;
using LiveCharts;
using LiveCharts.Wpf; // For WPF applications
using LiveCharts.WinForms; // For Windows Forms applications
using LiveCharts.Defaults; // For ChartValues
//using LiveCharts.Series; // For ColumnSeries and Axis
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace MunicipalityReportingApp
{
    public partial class ServiceRequestStatusForm : Form
    {
        private LiveCharts.WinForms.CartesianChart requestChart;
        private BinarySearchTree requestBST;
        private AVLTree requestAVL;
        private RedBlackTree requestRB;
        private MinHeap requestHeap;
        private Graph requestGraph;

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            InitializeDataStructures();
            InitializeChart();
            LoadServiceRequests();
            PopulateListView();
            //this.graphPanel.Paint += new PaintEventHandler(this.graphPanel_Paint);
        }

        private void InitializeChart()
        {
            requestChart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill
            };

            // Add the chart to the graph panel
            graphPanel.Controls.Add(requestChart);
            graphPanel.BringToFront();
        }

        private void InitializeDataStructures()
        {
            requestBST = new BinarySearchTree();
            requestAVL = new AVLTree();
            requestRB = new RedBlackTree();
            requestHeap = new MinHeap();
            requestGraph = new Graph();
        }

        private void LoadServiceRequests()
        {
            // Sample service requests with unique IDs
            var request1 = new ServiceRequest("S101", "Street light out", "In Progress", DateTime.Now);
            var request2 = new ServiceRequest("W102", "Water leak", "Resolved", DateTime.Now.AddDays(-1));
            var request3 = new ServiceRequest("P103", "Pothole repair", "Pending", DateTime.Now.AddDays(1));
            var request4 = new ServiceRequest("S104", "Street light stuck", "In Progress", DateTime.Now);
            var request5 = new ServiceRequest("G105", "Gas leak", "Pending", DateTime.Now.AddDays(-1));
            var request6 = new ServiceRequest("P106", "Pipe repair", "Resolved", DateTime.Now.AddDays(1));
            var request7 = new ServiceRequest("S107", "Traffic signal malfunction", "Pending", DateTime.Now);
            var request8 = new ServiceRequest("W108", "Sewage backup", "In Progress", DateTime.Now.AddDays(-2));
            var request9 = new ServiceRequest("G109", "Gas meter reading", "Resolved", DateTime.Now.AddDays(2));
            var request10 = new ServiceRequest("P110", "Sidewalk repair", "Pending", DateTime.Now.AddDays(3));

            // Insert into data structures
            requestBST.Insert(request1);
            requestBST.Insert(request2);
            requestBST.Insert(request3);
            requestBST.Insert(request4);
            requestBST.Insert(request5);
            requestBST.Insert(request6);
            requestBST.Insert(request7);
            requestBST.Insert(request8);
            requestBST.Insert(request9);
            requestBST.Insert(request10);

            requestAVL.Insert(request1);
            requestAVL.Insert(request2);
            requestAVL.Insert(request3);
            requestAVL.Insert(request4);
            requestAVL.Insert(request5);
            requestAVL.Insert(request6);
            requestAVL.Insert(request7);
            requestAVL.Insert(request8);
            requestAVL.Insert(request9);
            requestAVL.Insert(request10);

            requestRB.Insert(request1);
            requestRB.Insert(request2);
            requestRB.Insert(request3);
            requestRB.Insert(request4);
            requestRB.Insert(request5);
            requestRB.Insert(request6);
            requestRB.Insert(request7);
            requestRB.Insert(request8);
            requestRB.Insert(request9);
            requestRB.Insert(request10);

            requestHeap.Insert(request1);
            requestHeap.Insert(request2);
            requestHeap.Insert(request3);
            requestHeap.Insert(request4);
            requestHeap.Insert(request5);
            requestHeap.Insert(request6);
            requestHeap.Insert(request7);
            requestHeap.Insert(request8);
            requestHeap.Insert(request9);
            requestHeap.Insert(request10);

            // Add service requests to the static list for display
            ReportedRequests.Add(request1);
            ReportedRequests.Add(request2);
            ReportedRequests.Add(request3);
            ReportedRequests.Add(request4);
            ReportedRequests.Add(request5);
            ReportedRequests.Add(request6);
            ReportedRequests.Add(request7);
            ReportedRequests.Add(request8);
            ReportedRequests.Add(request9);
            ReportedRequests.Add(request10);

            // Debugging: Check how many requests were added
            Console.WriteLine($"Total Requests Loaded: {ReportedRequests.RequestsList.Count}");

            // Build graph relationships
            requestGraph.AddEdge(request1.Id, request2.Id);
            requestGraph.AddEdge(request2.Id, request3.Id);
            requestGraph.AddEdge(request1.Id, request3.Id);
            requestGraph.AddEdge(request3.Id, request4.Id);
            requestGraph.AddEdge(request5.Id, request6.Id);
            requestGraph.AddEdge(request7.Id, request8.Id);
            requestGraph.AddEdge(request9.Id, request10.Id);

            PopulateChart();
        }

        private void PopulateChart()
        {
            // Create a series for the chart
            var seriesCollection = new SeriesCollection();

            // Count the number of requests in each status
            var statusCounts = new Dictionary<string, int>
    {
        { "In Progress", 0 },
        { "Resolved", 0 },
        { "Pending", 0 }
    };

            // Count occurrences of each status
            foreach (var request in ReportedRequests.RequestsList)
            {
                if (statusCounts.ContainsKey(request.Status))
                {
                    statusCounts[request.Status]++;
                }
            }

            // Create a series for each status with data labels
            foreach (var status in statusCounts.Keys)
            {
                seriesCollection.Add(new ColumnSeries
                {
                    Title = status,
                    Values = new ChartValues<int> { statusCounts[status] },
                    DataLabels = true, // Show data labels
                    LabelPoint = point => point.Y.ToString() // Show the count as the label
                });
            }

            requestChart.Series = seriesCollection;

            // Configure axes
            requestChart.AxisX.Clear(); // Clear previous labels
            requestChart.AxisX.Add(new Axis
            {
                Title = "Service Request Status", // More descriptive axis title
                Labels = statusCounts.Keys.ToArray() // Use status names as labels
            });

            // Set Y-axis dynamically based on max count
            int maxCount = statusCounts.Values.Max();
            requestChart.AxisY.Clear(); // Clear previous settings
            requestChart.AxisY.Add(new Axis
            {
                Title = "Number of Requests", // More descriptive axis title
                MinValue = 0,
                MaxValue = maxCount + 1 // Add a little space above the max count
            });

            // Add chart title
           // requestChart.Title = "Overview of Service Request Statuses"; // Chart title
            requestChart.LegendLocation = LegendLocation.Right; // Place legend on the right
            requestChart.DataTooltip = new DefaultTooltip(); // Enable tooltips
        }

        private int GetStatusValue(string status)
        {
            switch (status)
            {
                case "In Progress":
                    return 1;
                case "Resolved":
                    return 2;
                case "Pending":
                    return 3;
                default:
                    return 0;
            }
        }

        private string[] GetRequestIds()
        {
            List<string> ids = new List<string>();
            foreach (var request in ReportedRequests.RequestsList)
            {
                ids.Add(request.Id);
            }
            return ids.ToArray();
        }
    

    private void btnSearch_Click(object sender, EventArgs e)
        {
            string requestId = txtRequestID.Text;
            var request = requestBST.Search(requestId);
            if (request != null)
            {
                lblStatus.Text = $"Status: {request.Status}";
            }
            else
            {
                lblStatus.Text = "Request not found.";
            }
        }

        private void PopulateListView()
        {
            lvServiceRequests.Items.Clear(); // Clear existing items

            // Use the static list to populate the ListView
            foreach (var request in ReportedRequests.RequestsList)
            {
                var item = new ListViewItem(request.Id); // Use Id instead of RequestID
                item.SubItems.Add(request.Status);
                item.SubItems.Add(request.Description);
                lvServiceRequests.Items.Add(item);
            }

            // Debugging: Check how many items were added to the ListView
            Console.WriteLine($"Total Items in ListView: {lvServiceRequests.Items.Count}");
        }

        private void btnShowPriorityRequests_Click(object sender, EventArgs e)
        {
            var priorityRequest = requestHeap.ExtractMin();
            if (priorityRequest != null)
            {
                MessageBox.Show($"Next priority request: {priorityRequest.Description} - Status: {priorityRequest.Status}");
            }
            else
            {
                MessageBox.Show("No priority requests available.");
            }
        }

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(System.Drawing.Color.Black);
            Brush brush = new SolidBrush(System.Drawing.Color.Blue);
            int nodeSize = 30;
            int spacing = 100;

            // Draw nodes and edges
            int x = 50, y = 50;
            foreach (var vertex in requestGraph.AdjacencyList.Keys)
            {
                g.FillEllipse(brush, new Rectangle(x, y, nodeSize, nodeSize)); // Draw node
                g.DrawString(vertex, this.Font, Brushes.Black, new PointF(x + 5, y + 5)); // Label node

                foreach (var neighbor in requestGraph.GetNeighbors(vertex))
                {
                    int neighborX = x + spacing; // Simple horizontal layout
                    g.DrawLine(pen, x + nodeSize / 2, y + nodeSize / 2, neighborX + nodeSize / 2, y + nodeSize / 2); // Draw edge
                }
                x += spacing; // Move to the next node position
            }
        }
    }
}