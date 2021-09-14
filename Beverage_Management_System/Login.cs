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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void label16_Click(object sender, EventArgs e)
        {
      
            panel3.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_visible2_Click(object sender, EventArgs e)
        {
            btt_visible2.Hide();
            btt_unvisible2.Show();
            txb_passLogin.UseSystemPasswordChar = true;
        }

        private void btt_unvisible2_Click(object sender, EventArgs e)
        {
            btt_visible2.Show();
            btt_unvisible2.Hide();
            txb_passLogin.UseSystemPasswordChar = false;
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txb_passLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
