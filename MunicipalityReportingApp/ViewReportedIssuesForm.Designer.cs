namespace MunicipalityReportingApp
{
    partial class ViewReportedIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvReportedIssues;
        private System.Windows.Forms.ColumnHeader chIssueID;
        private System.Windows.Forms.ColumnHeader chLocation;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Label lblHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lvReportedIssues = new System.Windows.Forms.ListView();
            this.chIssueID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvReportedIssues
            // 
            this.lvReportedIssues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIssueID,
            this.chLocation,
            this.chCategory,
            this.chDescription,
            this.chStatus});
            this.lvReportedIssues.FullRowSelect = true;
            this.lvReportedIssues.GridLines = true;
            this.lvReportedIssues.HideSelection = false;
            this.lvReportedIssues.Location = new System.Drawing.Point(17, 52);
            this.lvReportedIssues.Name = "lvReportedIssues";
            this.lvReportedIssues.Size = new System.Drawing.Size(652, 261);
            this.lvReportedIssues.TabIndex = 0;
            this.lvReportedIssues.UseCompatibleStateImageBehavior = false;
            this.lvReportedIssues.View = System.Windows.Forms.View.Details;
            // 
            // chIssueID
            // 
            this.chIssueID.Text = "Location";
            this.chIssueID.Width = 100;
            // 
            // chLocation
            // 
            this.chLocation.Text = "Category";
            this.chLocation.Width = 150;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Desciption";
            this.chCategory.Width = 150;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Attachment";
            this.chDescription.Width = 250;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 100;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBackToMainMenu.Location = new System.Drawing.Point(583, 321);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(86, 26);
            this.btnBackToMainMenu.TabIndex = 1;
            this.btnBackToMainMenu.Text = "Back to Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(17, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(179, 21);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "List of Reported Issues";
            // 
            // ViewReportedIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(686, 364);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.lvReportedIssues);
            this.MaximizeBox = false;
            this.Name = "ViewReportedIssuesForm";
            this.Text = "View Reported Issues";
            this.Load += new System.EventHandler(this.ViewReportedIssuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
