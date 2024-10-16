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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.ShowDialog();
        }

        private void btnViewReportedIssues_Click(object sender, EventArgs e)
        {
            ViewReportedIssuesForm viewForm = new ViewReportedIssuesForm();
            viewForm.ShowDialog();
        }

        private void btnViewLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.ShowDialog();
        }

    }
}
