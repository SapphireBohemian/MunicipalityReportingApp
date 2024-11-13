namespace MunicipalityReportingApp
{
    partial class MainMenuForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl; // Add this line

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEventsAnnouncements = new System.Windows.Forms.Button();
            this.btnServiceRequestStatus = new System.Windows.Forms.Button();
            this.btnViewReportedIssues = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(200, 100);
            this.tabControl.TabIndex = 0;
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReportIssues.Location = new System.Drawing.Point(100, 250);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(279, 40);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnEventsAnnouncements
            // 
            this.btnEventsAnnouncements.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEventsAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventsAnnouncements.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEventsAnnouncements.Location = new System.Drawing.Point(100, 310);
            this.btnEventsAnnouncements.Name = "btnEventsAnnouncements";
            this.btnEventsAnnouncements.Size = new System.Drawing.Size(279, 40);
            this.btnEventsAnnouncements.TabIndex = 2;
            this.btnEventsAnnouncements.Text = "Local Events and Announcements";
            this.btnEventsAnnouncements.UseVisualStyleBackColor = true;
            this.btnEventsAnnouncements.Click += new System.EventHandler(this.btnViewLocalEvents_Click);
            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnServiceRequestStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRequestStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(100, 330);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(279, 40);
            this.btnServiceRequestStatus.TabIndex = 4;
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.UseVisualStyleBackColor = true;
            this.btnServiceRequestStatus.Click += new System.EventHandler(this.btnServiceRequestStatus_Click);
            //
            // btnViewReportedIssues
            // 
            this.btnViewReportedIssues.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewReportedIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReportedIssues.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnViewReportedIssues.Location = new System.Drawing.Point(100, 430);
            this.btnViewReportedIssues.Name = "btnViewReportedIssues";
            this.btnViewReportedIssues.Size = new System.Drawing.Size(279, 40);
            this.btnViewReportedIssues.TabIndex = 4;
            this.btnViewReportedIssues.Text = "View Reported Issues";
            this.btnViewReportedIssues.UseVisualStyleBackColor = true;
            this.btnViewReportedIssues.Click += new System.EventHandler(this.btnViewReportedIssues_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(102, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(256, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Municipal Services";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::MunicipalityReportingApp.Properties.Resources.m2;
            this.pictureBoxLogo.Location = new System.Drawing.Point(100, 80);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(279, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(469, 500);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnEventsAnnouncements);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.Controls.Add(this.btnViewReportedIssues);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEventsAnnouncements;
        private System.Windows.Forms.Button btnServiceRequestStatus;
        private System.Windows.Forms.Button btnViewReportedIssues;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

