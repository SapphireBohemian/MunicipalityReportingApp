namespace MunicipalityReportingApp
{
    partial class ServiceRequestStatusForm
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
            this.lvServiceRequests = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnShowPriorityRequests = new System.Windows.Forms.Button();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxGraph = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();

            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.lblRequestID);
            this.groupBoxSearch.Controls.Add(this.txtRequestID);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.lblStatus);
            this.groupBoxSearch.Controls.Add(this.btnShowPriorityRequests);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(400, 120);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search Service Request";

            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Location = new System.Drawing.Point(6, 22);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(102, 13);
            this.lblRequestID.TabIndex = 1;
            this.lblRequestID.Text = "Enter Request ID:";

            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(9, 38);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(180, 20);
            this.txtRequestID.TabIndex = 0;

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(200, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;

            // 
            // btnShowPriorityRequests ```csharp
            // 
            this.btnShowPriorityRequests.Location = new System.Drawing.Point(9, 86);
            this.btnShowPriorityRequests.Name = "btnShowPriorityRequests";
            this.btnShowPriorityRequests.Size = new System.Drawing.Size(181, 23);
            this.btnShowPriorityRequests.TabIndex = 4;
            this.btnShowPriorityRequests.Text = "Show Next Priority Request";
            this.btnShowPriorityRequests.UseVisualStyleBackColor = true;
            this.btnShowPriorityRequests.Click += new System.EventHandler(this.btnShowPriorityRequests_Click);

            // 
            // groupBoxGraph
            // 
            this.groupBoxGraph.Controls.Add(this.lblChartTitle);
            this.groupBoxGraph.Controls.Add(this.graphPanel);
            this.groupBoxGraph.Location = new System.Drawing.Point(12, 138);
            this.groupBoxGraph.Name = "groupBoxGraph";
            this.groupBoxGraph.Size = new System.Drawing.Size(400, 350);
            this.groupBoxGraph.TabIndex = 1;
            this.groupBoxGraph.TabStop = false;
            this.groupBoxGraph.Text = "Service Request Status Overview";

            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.Location = new System.Drawing.Point(6, 16);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(300, 21);
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.Text = "Overview of Service Request Statuses";

            // 
            // graphPanel
            // 
            this.graphPanel.Location = new System.Drawing.Point(9, 40);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(380, 300);
            this.graphPanel.TabIndex = 5;

            // 
            // lvServiceRequests
            // 
            this.lvServiceRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            new System.Windows.Forms.ColumnHeader() { Text = "Request ID", Width = 100 },
            new System.Windows.Forms.ColumnHeader() { Text = "Status", Width = 100 },
            new System.Windows.Forms.ColumnHeader() { Text = "Description", Width = 200 }});
            this.lvServiceRequests.FullRowSelect = true;
            this.lvServiceRequests.GridLines = true;
            this.lvServiceRequests.Location = new System.Drawing.Point(12, 494);
            this.lvServiceRequests.Name = "lvServiceRequests";
            this.lvServiceRequests.Size = new System.Drawing.Size(400, 200);
            this.lvServiceRequests.TabIndex = 2;
            this.lvServiceRequests.UseCompatibleStateImageBehavior = false;
            this.lvServiceRequests.View = System.Windows.Forms.View.Details;

            // 
            // ServiceRequestStatusForm
            // 
            this.ClientSize = new System.Drawing.Size(424, 706);
            this.Controls.Add(this.lvServiceRequests);
            this.Controls.Add(this.groupBoxGraph);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "ServiceRequestStatusForm";
            this.Text = "Service Request Status";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.ListView lvServiceRequests;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Button btnShowPriorityRequests;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxGraph;
    }
}
