namespace MunicipalityReportingApp
{
    partial class ViewReportedIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvReportedIssues;
        private System.Windows.Forms.Button btnBackToMainMenu;

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
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvReportedIssues
            // 
            this.lvReportedIssues.Location = new System.Drawing.Point(12, 12);
            this.lvReportedIssues.Name = "lvReportedIssues";
            this.lvReportedIssues.Size = new System.Drawing.Size(760, 400);
            this.lvReportedIssues.TabIndex = 0;
            this.lvReportedIssues.UseCompatibleStateImageBehavior = false;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Location = new System.Drawing.Point(12, 418);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(125, 23);
            this.btnBackToMainMenu.TabIndex = 1;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // ViewReportedIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.lvReportedIssues);
            this.Name = "ViewReportedIssuesForm";
            this.Text = "View Reported Issues";
            this.Load += new System.EventHandler(this.ViewReportedIssuesForm_Load);
            this.ResumeLayout(false);
        }
    }
}
