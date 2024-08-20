namespace MunicipalityReportingApp
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEventsAnnouncements = new System.Windows.Forms.Button();
            this.btnServiceRequestStatus = new System.Windows.Forms.Button();
            this.btnViewReportedIssues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Location = new System.Drawing.Point(92, 246);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(112, 23);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnEventsAnnouncements
            // 
            this.btnEventsAnnouncements.Enabled = false;
            this.btnEventsAnnouncements.Location = new System.Drawing.Point(289, 246);
            this.btnEventsAnnouncements.Name = "btnEventsAnnouncements";
            this.btnEventsAnnouncements.Size = new System.Drawing.Size(210, 23);
            this.btnEventsAnnouncements.TabIndex = 1;
            this.btnEventsAnnouncements.Text = "Local Events and Announcements";
            this.btnEventsAnnouncements.UseVisualStyleBackColor = true;
            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.Enabled = false;
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(586, 246);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(154, 23);
            this.btnServiceRequestStatus.TabIndex = 2;
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.UseVisualStyleBackColor = true;
            // 
            // btnViewReportedIssues
            // 
            this.btnViewReportedIssues.Location = new System.Drawing.Point(92, 300);
            this.btnViewReportedIssues.Name = "btnViewReportedIssues";
            this.btnViewReportedIssues.Size = new System.Drawing.Size(150, 23);
            this.btnViewReportedIssues.TabIndex = 3;
            this.btnViewReportedIssues.Text = "View Reported Issues";
            this.btnViewReportedIssues.UseVisualStyleBackColor = true;
            this.btnViewReportedIssues.Click += new System.EventHandler(this.btnViewReportedIssues_Click);

            // Add the button to the form
            this.Controls.Add(this.btnViewReportedIssues);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewReportedIssues);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.Controls.Add(this.btnEventsAnnouncements);
            this.Controls.Add(this.btnReportIssues);
            this.Name = "MainMenuForm";
            this.Text = "Municipality Reporting App";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEventsAnnouncements;
        private System.Windows.Forms.Button btnServiceRequestStatus;
        private System.Windows.Forms.Button btnViewReportedIssues;
    }
}

