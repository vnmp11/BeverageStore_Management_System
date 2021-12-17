using Beverage_Management_System.Connection;
using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Beverage_Management_System
{
    public partial class AddStaff : Form, IAddStaff
    {
        static public int message = 0;

        int id;
        public string username { get => txt_Username.Text; set => throw new NotImplementedException(); }
        public string password { get => txt_Password.Text; set => throw new NotImplementedException(); }
        public string name { get => txt_Name.Text; set => throw new NotImplementedException(); }
        public DateTime dob { get => dtPicker_DOB.Value; set => throw new NotImplementedException(); }
        public string sex { get => getSex(rb_Male) ; set => throw new NotImplementedException(); }
        public string phone { get => txt_Phone.Text; set => throw new NotImplementedException(); }
        public string address { get => txt_Address.Text; set => throw new NotImplementedException(); }
        public int role { get => getRole(rb_Waiter, rb_Bartender); set => throw new NotImplementedException(); }

        public AddStaff()
        {
            InitializeComponent();
        }
        public AddStaff(int id)
        {  
            InitializeComponent();

            StaffPresenter presenter = new StaffPresenter(this, id);
            presenter.setInformation(txt_ID, txt_Username, txt_Password, txt_Name, rb_Male, rb_Female, dtPicker_DOB,
                txt_Phone, txt_Address, rb_Waiter, rb_Bartender, rb_Accountant);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string getSex(RadioButton rb)
        {
            if (rb.Checked == true) return "Male";
            else return "Female";
        }

        public int getRole(RadioButton rb1, RadioButton rb2)
        {
            if (rb1.Checked == true) return 1;
            else if (rb2.Checked == true) return 2;
            else return 3;
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btt_visible_Click(object sender, EventArgs e)
        {
            btt_visible.Hide();
            btt_unvisible.Show();
            txt_Password.UseSystemPasswordChar = true;
        }

        private void btt_unvisible_Click(object sender, EventArgs e)
        {
            btt_visible.Show();
            btt_unvisible.Hide();
            txt_Password.UseSystemPasswordChar = false;
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.ToString().Trim() != "" && txt_Password.Text.ToString().Trim() != ""
                  && txt_Name.Text.ToString().Trim() != "" && (rb_Male.Checked == true || rb_Female.Checked == true)
                  && dtPicker_DOB.Value != null && txt_Phone.Text.ToString().Trim() != "" && txt_Address.Text.ToString().Trim() != ""
                  && (rb_Waiter.Checked == true || rb_Bartender.Checked == true || rb_Accountant.Checked == true))
            {
                if (txt_ID.Text.Trim() != "") id = Convert.ToInt32(txt_ID.Text);
                else id = -1;
                StaffPresenter presenter = new StaffPresenter(this, id);
                presenter.addStaff(this);
               
                this.Close();

               
            }
            else MyMessageBox.showBox("Please fill in the employee's information completely!", "Message");
        }

        public void refreshForm()
        {
            txt_ID.Text = "";
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_Name.Text = "";
            rb_Male.Checked = true;
            rb_Female.Checked = false;
            dtPicker_DOB.Value = Convert.ToDateTime("01/01/2001");
            txt_Phone.Text = "";
            txt_Address.Text = "";
            rb_Accountant.Checked = true;
            rb_Bartender.Checked = false;
            rb_Waiter.Checked = false;

        }

        private void AddStaff_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {

            message = 1;
        }

        private void AddStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Staff f1 = (Staff)this.Owner;
            f1.reloadTable();
        }

        private void AddStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
        }

        private void txt_Phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
        }

        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
        }
    }
}
