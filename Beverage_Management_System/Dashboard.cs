using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Drawing;
using Beverage_Management_System.Model;

namespace Beverage_Management_System
{
    public partial class Dashboard : Form
    {
        Guna.UI2.WinForms.Guna2Button currentBtn;
        int id_person = -1;
        string sex_person;
        public static int check = 0;
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(int ID, string sex)
        {
            InitializeComponent();
            id_person = ID;
            sex_person = sex;

            if (sex_person == "Male")
            {
                pB_Image.Image = Properties.Resources.male;
            }   else if (sex_person == "Female")
            {
                pB_Image.Image = Properties.Resources.female;

            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form activeForm = null;
        public void openChildForm(Form f)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pl_content.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void hideSubMenu()
        {
            if (pl_SubMenuProduct.Visible == true)
                pl_SubMenuProduct.Visible = false;
            if (pl_SubMenuFinancialNote.Visible == true) pl_SubMenuFinancialNote.Visible = false;
          
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Guna.UI2.WinForms.Guna2Button)btnSender)
                {
                    DisableButton();
                    currentBtn = (Guna.UI2.WinForms.Guna2Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(37, 130, 167);
                    
                }    
            }    
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in pl_Dashboard_Waiter.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 149, 191); 
                }    
            }

            foreach (Control previousBtn in pL_Dashboard_Bartender.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 149, 191);
                }
            }

            foreach (Control previousBtn in pl_Dashboard_Owner.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 149, 191);
                }
            }

            foreach (Control previousBtn in pl_Dashboard_Accounting.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 149, 191);
                }
            }

            foreach (Control previousBtn in pl_Dashboard_Waiter.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 149, 191);
                }
            }

            foreach (Control previousBtn in pl_SubMenuFinancialNote.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 149, 191);
                }
            }

            foreach (Control previousBtn in pl_SubMenuProduct.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 149, 191);
                }
            }
        }

        private void guna2ImageButton2_Click(object sender, System.EventArgs e)
        {
            if (pl_menu.Width == 80)
            {
                pl_menu.Width = 235;
            }
            else
                pl_menu.Width = 80;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new Staff());
            showSubMenu(pl_SubMenuProduct);
        }

        private void btt_Product_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            showSubMenu(pl_SubMenuProduct);
         
        }

        private void btt_Inventory_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new Inventory());
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new Menu(id_person));
        }

        private void btt_Staff_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.Owner = this;
            ActiveButton(sender);
            openChildForm(st);
        }

        private void btt_Statistic_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new Statistic());
        }

        private void btt_Report_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new ManageReport());
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new IncidentReport());
            
        }

        private void btt_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btt_hide_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btt_maximize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btt_maximize.Visible = false;
            btt_minimize.Visible = true;
        }

        private void btt_minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btt_minimize.Visible = false;
            btt_maximize.Visible = true;
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new Agency());
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new ImportForm());
        }
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new TrackingNote());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new OrderForm(id_person));
        }

        public void setDashboard_Owner()
        {
            pl_Dashboard_Owner.Visible = true;
            pl_Dashboard_Waiter.Visible = false;
            pL_Dashboard_Bartender.Visible = false;
            pl_Dashboard_Accounting.Visible = false;
        }

        public void setDashboard_Waiter()
        {
            pl_Dashboard_Owner.Visible = false;
            pl_Dashboard_Waiter.Visible = true;
            pL_Dashboard_Bartender.Visible = false;
            pl_Dashboard_Accounting.Visible = false;
            //pB_Image.Image =
        }
        public void setDashboard_Bartender()
        {
            pl_Dashboard_Owner.Visible = false;
            pl_Dashboard_Waiter.Visible = false;
            pL_Dashboard_Bartender.Visible = true;
            pl_Dashboard_Accounting.Visible = false;
            //pb_Image.Image = 
        }
        public void setDashboard_Accountant()
        {
            pl_Dashboard_Owner.Visible = false;
            pl_Dashboard_Waiter.Visible = false;
            pL_Dashboard_Bartender.Visible = false;
            pl_Dashboard_Accounting.Visible = true;
            //pb_Image.Image = 
        }

        public void setPersonalInformation(string name, string role)
        {
            lb_Name.Text = name;
            lb_Role.Text = role;
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
            MyMessageBox.showBox("Logged out successfully", "Message");
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btt_FinancialNote_Click(object sender, EventArgs e)
        {
            showSubMenu(pl_SubMenuFinancialNote);
        }

        private void btt_GoodsImportBill_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new GoodsImportBill(id_person));
        }

        private void btt_OrderBill_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new OrderBill(id_person));
        }

        private void btt_Note_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new FinancialNote());
        }

        private void btt_ManageInventory_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new ImportForm(id_person));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Time.Text =  DateTime.Now.ToString("HH:mm:ss");
            lb_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lb_Date_Click(object sender, EventArgs e)
        {

        }
    }
}
