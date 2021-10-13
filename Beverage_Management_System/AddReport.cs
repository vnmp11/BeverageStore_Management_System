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
    public partial class AddReport : Form
    {
        IncidentReportPresenter pre = new IncidentReportPresenter();
        public AddReport()
        {
            InitializeComponent();
            pre.showId(cb_idOrderBill);
        }

        public AddReport(int id_orderform, String reason, String solution, int fine, DateTime date)
        {
            InitializeComponent();

            txb_Fine.Text = fine.ToString();
            txb_Reason.Text = reason;
            txb_Solution.Text = solution;
            cb_idOrderBill.Items.Add(id_orderform.ToString());
            cb_idOrderBill.SelectedIndex = 1;
            dateTime.Value = date;
           
        }

        bool checkEmpty()
        {
            if (cb_idOrderBill.SelectedIndex == 0)
            {
                MyMessageBox.showBox("Please choose ID order form.");
                return false;
            }
            else if (txb_Fine.Text == "")
            {
                MyMessageBox.showBox("Please enter fine.");
                return false;
            }
            else
                return true;
        }

        private void AddReport_Load(object sender, EventArgs e)
        {

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
                pre.addReport(cb_idOrderBill.SelectedItem.ToString(), txb_Reason.Text, txb_Solution.Text, txb_Fine.Text.Replace(",", ""), dateTime.Value.Date);
                this.Close();
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
    }
}
