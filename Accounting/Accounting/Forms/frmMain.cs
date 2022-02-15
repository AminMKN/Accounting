using System;
using System.Windows.Forms;
using Accounting.Tools;
using System.Diagnostics;
using Accounting.Infrastructure.Repositories;

namespace Accounting.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ribbonControl1.SelectedRibbonTabItem = ribbonTabItem1;
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            if (Messages.Exit() == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            //new frmRemainingReport(new RemainingReportRepository()).Show();
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            new frmBarcode().Show();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            //new frmProject(new ProjectRepository()).Show();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            //new frmSewingBreakDown(new SewingBreakDownRepository()).Show();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            new frmPrintBreakDown(new PrintBreakDownRepository()).Show();
        }
    }
}
