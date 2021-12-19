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
            dataGV_Report.AllowUserToAddRows = false;
            if (dataGV_Report.Rows.Count > 0) dataGV_Report.CurrentCell.Selected = false;
        }

        private void btt_addReport_Click(object sender, EventArgs e)
        {
            AddReport report = new AddReport();
            report.Show();
            report.FormClosing += (s, a) =>
            {
                dataGV_Report.AllowUserToAddRows = true;
                dataGV_Report.Rows.Clear();
                p.showListReport(dataGV_Report);
                dataGV_Report.AllowUserToAddRows = false;
                if (dataGV_Report.Rows.Count > 0) dataGV_Report.CurrentCell.Selected = false;
            };
        }

        private void dataGV_Report_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_orderform = int.Parse(dataGV_Report.Rows[e.RowIndex].Cells[1].Value.ToString());
            String reason = dataGV_Report.Rows[e.RowIndex].Cells[2].Value.ToString();
            String solution = dataGV_Report.Rows[e.RowIndex].Cells[3].Value.ToString();
            int fine = int.Parse(dataGV_Report.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(",", ""));
            DateTime date = DateTime.ParseExact(dataGV_Report.Rows[e.RowIndex].Cells[5].Value.ToString(), "dd/MM/yyyy", null);

            AddReport report = new AddReport(id_orderform, reason, solution, fine, date);
            report.Show();
            report.FormClosing += (s, a) =>
            {
                dataGV_Report.AllowUserToAddRows = true;
                dataGV_Report.Rows.Clear();
                p.showListReport(dataGV_Report);
                dataGV_Report.AllowUserToAddRows = false;
                if (dataGV_Report.Rows.Count > 0) dataGV_Report.CurrentCell.Selected = false;
            };
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

        private void txb_Search_TextChanged(object sender, EventArgs e)
        {
            if (txb_Search.Text == "")
            {
                dataGV_Report.AllowUserToAddRows = true;
                p.showListReport(dataGV_Report);
                dataGV_Report.AllowUserToAddRows = false;
                if (dataGV_Report.Rows.Count > 0) dataGV_Report.CurrentCell.Selected = false;
            }
            else
            {
                dataGV_Report.AllowUserToAddRows = true;
                p.searchReport(dataGV_Report, txb_Search.Text);
                dataGV_Report.AllowUserToAddRows = false;
            }
        }

        private void txb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGV_Report_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id_orderform = int.Parse(dataGV_Report.Rows[e.RowIndex].Cells[1].Value.ToString());
            String reason = dataGV_Report.Rows[e.RowIndex].Cells[2].Value.ToString();
            String solution = dataGV_Report.Rows[e.RowIndex].Cells[3].Value.ToString();
            int fine = int.Parse(dataGV_Report.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(",", ""));
            DateTime date = DateTime.ParseExact(dataGV_Report.Rows[e.RowIndex].Cells[5].Value.ToString(), "dd/MM/yyyy", null);

            AddReport report = new AddReport(id_orderform, reason, solution, fine, date, false);
            report.Show();
              report.FormClosing += (s, a) =>
            {
                dataGV_Report.AllowUserToAddRows = true;
                dataGV_Report.Rows.Clear();
                p.showListReport(dataGV_Report);
                dataGV_Report.AllowUserToAddRows = false;
                if (dataGV_Report.Rows.Count > 0) dataGV_Report.CurrentCell.Selected = false;
            };
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dataGV_Report.SelectedCells.Count > 0)
            {
                AlertDialog dialog = new AlertDialog();
                dialog.setMessage("Do you want to delete this report?");
                dialog.Show();
                dialog.btt_ok.Click += (s, a) =>
                {
                    int selected_index = dataGV_Report.SelectedCells[0].RowIndex;
                    DataGridViewRow selected_row = dataGV_Report.Rows[selected_index];
                    int id_choose = Convert.ToInt32(selected_row.Cells["ID_REPORT"].Value);

                    IncidentReportPresenter presenter = new IncidentReportPresenter();
                    if (presenter.deleteReport(id_choose.ToString(), (selected_row.Cells["ID_ORDER_FORM"].Value).ToString()) > 0)
                    {
                        dataGV_Report.AllowUserToAddRows = true;
                        dataGV_Report.Rows.Clear();
                        p.showListReport(dataGV_Report);
                        dataGV_Report.AllowUserToAddRows = false;
                        if (dataGV_Report.Rows.Count > 1) dataGV_Report.CurrentCell.Selected = false;
                        MyMessageBox.showBox("Delete this report successfully!", "Message");
                    }
                    else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
                };



            }
            else MyMessageBox.showBox("Please choose a report which you want to delete!", "Message");

        }
    }
}
