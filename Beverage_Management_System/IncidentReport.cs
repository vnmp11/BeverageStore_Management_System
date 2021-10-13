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
    public partial class IncidentReport : Form
    {
        IncidentReportPresenter p = new IncidentReportPresenter();
        public IncidentReport()
        {
            InitializeComponent();
            p.showListReport(dataGV_Report);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IncidentReport_Load(object sender, EventArgs e)
        {

        }

        private void btt_addReport_Click(object sender, EventArgs e)
        {
            AddReport report = new AddReport();
            report.Show();
            report.FormClosing += (s, a) =>
            {
                dataGV_Report.Rows.Clear();
                p.showListReport(dataGV_Report);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.showListReport(dataGV_Report);
        }

        private void dataGV_Report_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_orderform = int.Parse(dataGV_Report.Rows[e.RowIndex].Cells[1].Value.ToString());
            String reason = dataGV_Report.Rows[e.RowIndex].Cells[2].Value.ToString();
            String solution = dataGV_Report.Rows[e.RowIndex].Cells[3].Value.ToString();
            int fine = int.Parse(dataGV_Report.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(",", ""));
            DateTime date = (DateTime) dataGV_Report.Rows[e.RowIndex].Cells[5].Value;

            AddReport report = new AddReport(id_orderform, reason, solution, fine, date);
            report.Show();
        }
    }
}
