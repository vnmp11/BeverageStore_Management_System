using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Beverage_Management_System
{
    public partial class AddAgency : Form, IAddAgency
    {
        Agency parent;
        public AddAgency(Agency form)
        {
            InitializeComponent();
            this.parent = form;
           
        }
        public string name { get => txt_Name_Agency.Text; set => throw new NotImplementedException(); }
        public string address { get => txt_Address_Agency.Text; set => throw new NotImplementedException(); }
        public string phone { get => txt_Phone_Agency.Text; set => throw new NotImplementedException(); }
        public string item { get => txt_Item_Agency.Text; set => throw new NotImplementedException(); }
        int id;
        public AddAgency(int ID, Agency form)
        {
            InitializeComponent();
            this.parent = form;
            AgencyPresenter agencyPresenter = new AgencyPresenter(this, ID);
           
            agencyPresenter.setInforAgency( txt_Id_Agency, ID,txt_Name_Agency, txt_Address_Agency, txt_Phone_Agency, txt_Item_Agency);
        }
        
        private void guna2ImageButton1_Click(object sender, EventArgs e)
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (!txt_Id_Agency.Text.Equals(""))
            {
                AgencyPresenter agencyPresenter = new AgencyPresenter(this, id);
                agencyPresenter.UpdateSupllier(this,Int32.Parse( txt_Id_Agency.Text));
                parent.refreshDataGV();
            }
            else if (txt_Name_Agency.Text.ToString().Trim() != "" && txt_Address_Agency.ToString().Trim() != ""
                  && txt_Phone_Agency.ToString().Trim() != "" && txt_Item_Agency.ToString().Trim() != "")
            {
                AgencyPresenter agencyPresenter = new AgencyPresenter(this, id);
                agencyPresenter.addSupplier(this);

                parent.refreshDataGV();

                this.Close();

            }
            else MyMessageBox.showBox("Please fill in the agency's information completely!", "Message");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txt_Name_Agency.Text = "";
            txt_Address_Agency.Text = "";
            txt_Phone_Agency.Text = "";
            txt_Item_Agency.Text = "";

        }

        private void txt_Name_Agency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void txt_Address_Agency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void txt_Phone_Agency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void txt_Item_Agency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void AddAgency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void txt_Name_Agency_DoubleClick(object sender, EventArgs e)
        {
            txt_Name_Agency.SelectAll();
        }

        private void txt_Address_Agency_DoubleClick(object sender, EventArgs e)
        {
            txt_Address_Agency.SelectAll();
        }

        private void txt_Phone_Agency_DoubleClick(object sender, EventArgs e)
        {
            txt_Phone_Agency.SelectAll();
        }

        private void txt_Item_Agency_DoubleClick(object sender, EventArgs e)
        {
            txt_Item_Agency.SelectAll();
        }
    }
}
