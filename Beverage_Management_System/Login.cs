using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beverage_Management_System.View;
using Beverage_Management_System.Presenters;

namespace Beverage_Management_System
{
    public partial class Login : Form, ILogin
    {
        public string username { get => txt_Username.Text ; set => txt_Username.Text = value; }
        public string password { get => txt_Password.Text; set => txt_Password.Text = value; }

        public Login()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
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
            txt_Password.UseSystemPasswordChar = true;
        }

        private void btt_unvisible2_Click(object sender, EventArgs e)
        {
            btt_visible2.Show();
            btt_unvisible2.Hide();
            txt_Password.UseSystemPasswordChar = false;
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);
            presenter.Login(this);
        }

        public void Refresh_UsernameAndPassword()
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
        }
    }
}
