namespace MunicipalityReportingApp
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(20, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(68, 21);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location:";

            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLocation.Location = new System.Drawing.Point(120, 20);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(250, 29);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);

            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(20, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 21);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";

            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
                "Road Maintenance",
                "Street Lighting",
                "Waste Management",
                "Parks and Recreation",
                "Public Safety"
            });
            this.cbCategory.Location = new System.Drawing.Point(120, 70);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(250, 29);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(20, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 21);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";

            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbDescription.Location = new System.Drawing.Point(20, 150);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(350, 100);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);

            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAttachMedia.Location = new System.Drawing.Point(20, 270);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(150, 30);
            this.btnAttachMedia.TabIndex = 6;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);

            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAttachment.Location = new System.Drawing.Point(180, 275);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(120, 21);
            this.lblAttachment.TabIndex = 7;
            this.lblAttachment.Text = "No file selected.";

            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(20, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 30);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackToMainMenu.Location = new System.Drawing.Point(220, 320);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(150, 30);
            this.btnBackToMainMenu.TabIndex = 9;
            this.btnBackToMainMenu.Text = "Back to Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);

            // 
            // progressBar
            // 
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressBar.Location = new System.Drawing.Point(20, 370);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 23);
            this.progressBar.TabIndex = 10;

            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Name = "ReportIssuesForm";
            this.Text = "Report an Issue";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
