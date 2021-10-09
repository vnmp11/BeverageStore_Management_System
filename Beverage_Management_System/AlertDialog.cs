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
    public partial class AlertDialog : Form
    {
        static AlertDialog dialog;
        public AlertDialog()
        {
            InitializeComponent();
        }

        public void showBox(string txt, string title)
        {
            dialog = new AlertDialog();
            dialog.lb_Title.Text = title;
            dialog.lb_message.Text = txt;
            dialog.Show();

        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setMessage(string s)
        {
            lb_message.Text = s;
        }

        private void AlertDialog_Load(object sender, EventArgs e)
        {

        }

        private void lb_message_Click(object sender, EventArgs e)
        {

        }
    }
}
