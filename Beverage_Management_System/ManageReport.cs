using Beverage_Management_System.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System
{
    public partial class ManageReport : Form
    {
        IncidentReportPresenter p = new IncidentReportPresenter();
        public ManageReport()
        {
            InitializeComponent();
            p.showListReport(dataGV_Report);
            dataGV_Report.CurrentCell = null;
        }

        private void ManageReport_Load(object sender, EventArgs e)
        {

        }

        private void txb_Search_TextChanged(object sender, EventArgs e)
        {
            if (txb_Search.Text == "")
            {
                p.showListReport(dataGV_Report);
            }
            else
            {
                p.searchReport(dataGV_Report, txb_Search.Text);
            }
        }

        private void dataGV_Report_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id_orderform = int.Parse(dataGV_Report.Rows[e.RowIndex].Cells[1].Value.ToString());
            String reason = dataGV_Report.Rows[e.RowIndex].Cells[2].Value.ToString();
            String solution = dataGV_Report.Rows[e.RowIndex].Cells[3].Value.ToString();
            int fine = int.Parse(dataGV_Report.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(",", ""));
            DateTime date = (DateTime)dataGV_Report.Rows[e.RowIndex].Cells[5].Value;

            AddReport report = new AddReport(id_orderform, reason, solution, fine, date);
            report.Show();
        }

        private void txb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txb_Search.Text == "")
                {
                    MyMessageBox.showBox("Please enter something before searching", "Message");
                }
                else MyMessageBox.showBox("The result of searching is below", "Message");
            }
        }
    }
}
