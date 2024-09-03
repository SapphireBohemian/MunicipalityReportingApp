using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalityReportingApp
{
    public partial class ViewReportedIssuesForm : Form
    {
        public ViewReportedIssuesForm()
        {
            InitializeComponent();
        }

        private void ViewReportedIssuesForm_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadIssues();
        }

        private void SetupListView()
        {
            lvReportedIssues.View = View.Details;
            lvReportedIssues.Columns.Add("Location", 100);
            lvReportedIssues.Columns.Add("Category", 100);
            lvReportedIssues.Columns.Add("Description", 200);
            lvReportedIssues.Columns.Add("Attachment", 100);
        }

        private void LoadIssues()
        {
            lvReportedIssues.Items.Clear();

            foreach (var issue in ReportedIssues.IssuesList)
            {
                var item = new ListViewItem(issue.Location ?? "N/A");
                item.SubItems.Add(issue.Category ?? "N/A");
                item.SubItems.Add(issue.Description ?? "N/A");
                item.SubItems.Add(string.IsNullOrEmpty(issue.Attachment) ? "No attachment" : issue.Attachment);

                lvReportedIssues.Items.Add(item);
            }
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

