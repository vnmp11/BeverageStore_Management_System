using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;
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
    public partial class AddReport : Form, IAddReport
    {
        IncidentReportPresenter pre;

        public string fine { get => txb_Fine.Text; set => txb_Fine.Text = value; }
        public string reason { get => txb_Reason.Text; set => txb_Reason.Text = value; }
        public string solution { get => txb_Solution.Text; set => txb_Solution.Text = value; }

        public AddReport()
        {
            InitializeComponent();
            dateTime.MaxDate = DateTime.Now.Date;
            pre = new IncidentReportPresenter(this);
            DateTime today = DateTime.Now.Date;
            dateTime.Value = today;
            pre.showId(cb_idOrderBill);
        }

        public AddReport(int id_orderform, String reason, String solution, int fine, DateTime date)
        {
            InitializeComponent();
            pre = new IncidentReportPresenter(this);
            pre.setInformation(id_orderform, reason, solution, fine, date,
                txb_Fine, txb_Reason, txb_Solution, cb_idOrderBill, dateTime);
            btt_SubmitReport.Visible = false;
            btt_delete.Visible = false;

        }

        public AddReport(int id_orderform, String reason, String solution, int fine, DateTime date, bool isSeen)
        {
            if(isSeen)
            {
                InitializeComponent();
                pre = new IncidentReportPresenter(this);
                pre.setInformation(id_orderform, reason, solution, fine, date,
                    txb_Fine, txb_Reason, txb_Solution, cb_idOrderBill, dateTime);
            }
            else
            {
                InitializeComponent();
                pre = new IncidentReportPresenter(this);
                pre.setInformation(id_orderform, reason, solution, fine, date,
                    txb_Fine, txb_Reason, txb_Solution, cb_idOrderBill, dateTime);
                btt_SubmitReport.Visible = false;
                btt_delete.Visible = false;
            }

        }

        bool checkEmpty()
        {
            object id = cb_idOrderBill.SelectedItem;
            if (id == null)
            {
                MyMessageBox.showBox("Please choose ID order form.");
                return false;
            }
            else if (txb_Fine.Text == "")
            {
                MyMessageBox.showBox("Please enter fine.");
                return false;
            }
            else if (txb_Reason.Text == "")
            {
                MyMessageBox.showBox("Please enter reason.");
                return false;
            }
            else if (txb_Solution.Text == "")
            {
                MyMessageBox.showBox("Please enter solution.");
                return false;
            }
            return true;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
                cb_idOrderBill.SelectedIndex = 0;
                txb_Fine.Text = " ";
                txb_Reason.Text = " ";
                txb_Solution.Text = " ";
            
        }

        private void btt_SubmitReport_Click(object sender, EventArgs e)
        {
            if (checkEmpty())
            {
                if (pre.checkReport(cb_idOrderBill.SelectedItem.ToString()))
                {
                    pre.updateReport(cb_idOrderBill.SelectedItem.ToString());
                    this.Close();

                }
                else
                {
                    pre.addReport(cb_idOrderBill.SelectedItem.ToString(), dateTime.Value.Date);
                    this.Close();
                }
            }
        }

        private void txb_Fine_TextChanged(object sender, EventArgs e)
        {
            txb_Fine.Text = String.Format("{0:#,##0.00}", txb_Fine.Text);
        }

        private void txb_Fine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void AddReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btt_SubmitReport.PerformClick();
            }
        }

        private void txb_Fine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btt_SubmitReport.PerformClick();
            }
        }

        private void txb_Reason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btt_SubmitReport.PerformClick();
            }
        }

        private void txb_Solution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btt_SubmitReport.PerformClick();
            }
        }

        private void btt_SubmitReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btt_SubmitReport.PerformClick();
            }
        }

        private void AddReport_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txb_Fine_DoubleClick(object sender, EventArgs e)
        {
            txb_Fine.SelectAll();
        }

        private void txb_Reason_DoubleClick(object sender, EventArgs e)
        {
            txb_Reason.SelectAll();
        }

        private void txb_Solution_DoubleClick(object sender, EventArgs e)
        {
            txb_Solution.SelectAll();
        }
    }
}
