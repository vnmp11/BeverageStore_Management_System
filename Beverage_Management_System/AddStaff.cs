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

            setInformation(id);
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

        private void AddStaff_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

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

        private void setInformation(int id)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            string querry = "Select * from PERSON where ID_PERSON = '" + id + "';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    txt_ID.Text = row["ID_PERSON"].ToString();
                    txt_Username.Text = row["USERNAME"].ToString();
                    txt_Password.Text = row["PASSWORD"].ToString();
                    txt_Name.Text = row["NAME"].ToString();

                    DateTime date = Convert.ToDateTime(row["DOB"]);
                    dtPicker_DOB.Value = date;
                    string SEX = row["SEX"].ToString();
                    if (SEX != "Male")
                    {
                        rb_Female.Checked = true;
                        rb_Male.Checked = false;
                        //pB_avt.Image = 
                    }
                    else
                    {
                        rb_Male.Checked = true;
                        rb_Female.Checked = false;
                        //pB_avt.Image = 
                    }

                    txt_Phone.Text = row["PHONE"].ToString();
                    txt_Address.Text = row["ADDRESS"].ToString();

                    int ROLE = Convert.ToInt32(row["ROLE"]);
                    if (ROLE == 1)
                    {
                        rb_Waiter.Checked = true;
                        rb_Bartender.Checked = false;
                        rb_Accountant.Checked = false;
                    }
                    else if (ROLE == 2)
                    {
                        rb_Waiter.Checked = false;
                        rb_Bartender.Checked = true;
                        rb_Accountant.Checked = false;
                    }
                    else
                    {
                        rb_Waiter.Checked = false;
                        rb_Bartender.Checked = false;
                        rb_Accountant.Checked = true;
                    }


                }

            }
            myConnection.sqlcon.Close();
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
            //this.Owner.Dispose();


            Dashboard db = new Dashboard();
            Staff st = new Staff();
            st.Owner = db;
            db.openChildForm(st);
            db.Show();

     
        }

        private void AddStaff_Activated(object sender, EventArgs e)
        {
            
        }

        private void AddStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Owner.Hide();
        }
    }
}
