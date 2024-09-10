using System;
using System.Windows.Forms;

namespace MunicipalityReportingApp
{
    public partial class ReportIssuesForm : Form
    {
        public ReportIssuesForm()
        {
            InitializeComponent();
            InitializeProgressBar();
            UpdateProgressBar();  // Initialize progress bar
        }

        private void InitializeProgressBar()
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
        }

        private void UpdateProgressBar()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                progress += 33;  // 33% if location is filled
            if (cbCategory.SelectedIndex != -1)
                progress += 33;  // 33% if category is selected
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
                progress += 34;  // 34% if description is filled

            // Ensure the value is within the valid range
            if (progress < progressBar.Minimum)
                progress = progressBar.Minimum;
            if (progress > progressBar.Maximum)
                progress = progressBar.Maximum;

            progressBar.Value = progress;        
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

            // Reset the progress bar
            UpdateProgressBar();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the Report Issues form and return to the main menu
        }

        // Event handlers to update progress bar when user fills out fields
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();  // Update when location text changes
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();  // Update when category is selected
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();  // Update when description changes
        }
    }
}
