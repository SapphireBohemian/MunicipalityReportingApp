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
            this.chIssueID = new System.Windows.Forms.ColumnHeader();
            this.chLocation = new System.Windows.Forms.ColumnHeader();
            this.chCategory = new System.Windows.Forms.ColumnHeader();
            this.chDescription = new System.Windows.Forms.ColumnHeader();
            this.chStatus = new System.Windows.Forms.ColumnHeader();
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
            this.lvReportedIssues.Location = new System.Drawing.Point(20, 60);
            this.lvReportedIssues.Name = "lvReportedIssues";
            this.lvReportedIssues.Size = new System.Drawing.Size(760, 300);
            this.lvReportedIssues.TabIndex = 0;
            this.lvReportedIssues.UseCompatibleStateImageBehavior = false;
            this.lvReportedIssues.View = System.Windows.Forms.View.Details;

            // 
            // chIssueID
            // 
            this.chIssueID.Text = "Issue ID";
            this.chIssueID.Width = 100;

            // 
            // chLocation
            // 
            this.chLocation.Text = "Location";
            this.chLocation.Width = 150;

            // 
            // chCategory
            // 
            this.chCategory.Text = "Category";
            this.chCategory.Width = 150;

            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 250;

            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 100;

            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackToMainMenu.Location = new System.Drawing.Point(680, 370);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(100, 30);
            this.btnBackToMainMenu.TabIndex = 1;
            this.btnBackToMainMenu.Text = "Back to Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);

            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(181, 21);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "List of Reported Issues";

            // 
            // ViewReportedIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.lvReportedIssues);
            this.Name = "ViewReportedIssuesForm";
            this.Text = "View Reported Issues";
            this.Load += new System.EventHandler(this.ViewReportedIssuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
