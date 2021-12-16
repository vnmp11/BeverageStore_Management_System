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
    public partial class Report : Form
    {
        IncidentReportPresenter pre;

        public string fine { get => txb_Fine.Text; set => txb_Fine.Text = value; }
        public string reason { get => txb_Reason.Text; set => txb_Reason.Text = value; }
        public string solution { get => txb_Solution.Text; set => txb_Solution.Text = value; }

        public Report()
        {
            InitializeComponent();
            pre = new IncidentReportPresenter();
            DateTime today = DateTime.Today;
            dateTime.Value = today;
            pre.showId(cb_idOrderBill);

            cb_idOrderBill.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public Report(int id_orderform, String reason, String solution, int fine, DateTime date)
        {
            InitializeComponent();
            pre = new IncidentReportPresenter();
            pre.setInformation(id_orderform, reason, solution, fine, date,
                txb_Fine, txb_Reason, txb_Solution, cb_idOrderBill, dateTime);

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_idOrderBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
