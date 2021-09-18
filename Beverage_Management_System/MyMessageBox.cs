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
    public partial class MyMessageBox : Form
    {
        static MyMessageBox newMessageBox;
        //static string ButtonID = 1;

        public MyMessageBox()
        {
            InitializeComponent();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }

        public static void showBox(string txt)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lb_message.Text = txt;
            newMessageBox.ShowDialog();
            
        }

        public static void showBox(string txt, string title)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lb_Title.Text = title;
            newMessageBox.lb_message.Text = txt;
            newMessageBox.ShowDialog();
            
        }

        private void btt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
