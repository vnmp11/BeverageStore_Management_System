using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;
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
    public partial class AddGoodAgency : Form, IAddGoodsAgency
    {
        GoodAgency parent;
        public AddGoodAgency(GoodAgency form)
        {
            InitializeComponent();
            this.parent = form;
        }

        public static int idtemp2;

        public string name { get => txt_Name_Good.Text; set => throw new NotImplementedException(); }
        public string price { get => txt_Price_Good.Text; set => throw new NotImplementedException(); }
        public string unit { get => txt_Unit_Good.Text; set => throw new NotImplementedException(); }
        public string quantity { get => txt_Quantity_Good.Text; set => throw new NotImplementedException(); }
        //public string search { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AddGoodAgency(int ID, GoodAgency form)
        {
            InitializeComponent();
            this.parent = form;
            idtemp2 = ID;
        }
        private void btt_Add_Good_Click(object sender, EventArgs e)
        {
            if (txt_Name_Good.Text.ToString().Trim() != "" && txt_Price_Good.ToString().Trim() != ""
                  && txt_Unit_Good.ToString().Trim() != "" && txt_Quantity_Good.ToString().Trim() != "")
            {
                GoodAgencyPresenter agencyPresenter = new GoodAgencyPresenter(this, idtemp2);
                agencyPresenter.addGoodAgency(this, idtemp2);

                this.Close();

            }
            else MyMessageBox.showBox("Please fill in the product's information completely!", "Message");
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            if (txt_Name_Good.Text.ToString().Trim() != "" && txt_Price_Good.ToString().Trim() != ""
                  && txt_Unit_Good.ToString().Trim() != "" && txt_Quantity_Good.ToString().Trim() != "")
            {
                GoodAgencyPresenter agencyPresenter = new GoodAgencyPresenter(this, idtemp2);
                agencyPresenter.addGoodAgency(this, idtemp2);

                parent.refreshDataGV();
                this.Close();

            }
            else MyMessageBox.showBox("Please fill in the goods's information completely!", "Message");
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            txt_Name_Good.Text = "";
            txt_Price_Good.Text = "";
            txt_Unit_Good.Text = "";
            txt_Quantity_Good.Text = "";
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Price_Good_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_Quantity_Good_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AddGoodAgency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void txt_Name_Good_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void txt_Price_Good_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void txt_Unit_Good_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void txt_Quantity_Good_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }

        private void guna2Button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button3.PerformClick();
            }
        }
    }
}
