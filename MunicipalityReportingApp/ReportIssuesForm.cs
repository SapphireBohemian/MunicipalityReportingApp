using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MunicipalityReportingApp
{
    public partial class ReportIssuesForm : Form
    {
        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png|Documents|*.pdf;*.docx;*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblAttachment.Text = openFileDialog.FileName;  // Display selected file path
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Collect issue details
            string location = txtLocation.Text;
            string category = cbCategory.SelectedItem?.ToString();
            string description = rtbDescription.Text;
            string attachment = lblAttachment.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please fill in all required fields.", "Error");
                return;
            }

            // Create and store the issue
            Issue newIssue = new Issue(location, category, description, attachment);
            ReportedIssues.Add(newIssue);

            // Show a success message
            MessageBox.Show("Issue reported successfully!", "Success");

            // Clear the form fields
            txtLocation.Clear();
            rtbDescription.Clear();
            lblAttachment.Text = "No file selected.";
            cbCategory.SelectedIndex = -1;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the Report Issues form and return to the main menu
        }
    }
}
