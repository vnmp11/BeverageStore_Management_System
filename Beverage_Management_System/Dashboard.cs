﻿using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Drawing;


namespace Beverage_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Form activeForm = null;
        private void openChildForm(Form f)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
           
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

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

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btt_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btt_maximize.Visible = false;
            btt_minimize.Visible = true;
        }

        private void btt_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btt_maximize.Visible = true;
            btt_minimize.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff());
            showSubMenu(pl_SubMenuProduct);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            showSubMenu(pl_SubMenuProduct);
        }

        private void btt_manageStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new Inventory());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pl_Dashboard_Owner.Visible = true;
            pl_Dashboard_Waiter.Visible = false;
            pL_Dashboard_Bartender.Visible = false;
            pl_Dashboard_Accounting.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pl_Dashboard_Owner.Visible = false;
            pl_Dashboard_Waiter.Visible = true;
            pL_Dashboard_Bartender.Visible = false;
            pl_Dashboard_Accounting.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void btt_Inventory_Click(object sender, EventArgs e)
        {
            openChildForm(new Inventory());
        }

        private void btt_statistic_Click(object sender, EventArgs e)
        {
            openChildForm(new Statistic());
        }

        private void btt_agency_Click(object sender, EventArgs e)
        {
            openChildForm(new Agency());
        }

        private void btt_report_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageReport());
        }

        private void pl_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btt_report_waiter_Click(object sender, EventArgs e)
        {
            openChildForm(new IncidentReport());
        }

        private void btt_order_Click(object sender, EventArgs e)
        {
            openChildForm(new Menu());
        }

        private void btt_Product_Click(object sender, EventArgs e)
        {
            showSubMenu(pl_SubMenuProduct);
         
        }

        private void btt_Inventory_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Inventory());
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Menu());
        }

        private void btt_Staff_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff());
        }

        private void btt_Statistic_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Statistic());
        }

        private void btt_Report_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ManageReport());
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
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

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Agency());
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            openChildForm(new Agency());
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ImportForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pl_Dashboard_Owner.Visible = false;
            pl_Dashboard_Waiter.Visible = false;
            pL_Dashboard_Bartender.Visible = true;
            pl_Dashboard_Accounting.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            pl_Dashboard_Owner.Visible = false;
            pl_Dashboard_Waiter.Visible = false;
            pL_Dashboard_Bartender.Visible = false;
            pl_Dashboard_Accounting.Visible = true;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new TrackingNote());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }
    }
}
