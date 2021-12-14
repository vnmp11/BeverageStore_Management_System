using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
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

namespace Beverage_Management_System
{
    public partial class AddProduct : Form, IAddProduct
    {


        Image default_img;

        int id = 0;
        Inventory parent;

        InventoryPresenter presenter;

        public string name { get => txt_Name.Text; set => txt_Name.Text = value; }
        public string price { get => txt_Price.Text; set => txt_Price.Text = value; }
        public string quantity { get => txt_Quantity.Text; set => txt_Quantity.Text = value; }

        public AddProduct(Inventory form)
        {
            InitializeComponent();
            this.parent = form;
            default_img = pB_Product.Image;
            presenter = new InventoryPresenter(this);
            presenter.fillDataInCombobox(cb_KindOfProduct, cb_Unit, cb_Goods);

        }

        public AddProduct(int ID, Inventory form)
        {
            InitializeComponent();
            this.parent = form;
            id = ID;
            default_img = pB_Product.Image;
            presenter = new InventoryPresenter(this);
            presenter.fillDataInCombobox(cb_KindOfProduct, cb_Unit, cb_Goods);
            presenter.setInformation(ID, txt_Name, txt_Quantity, txt_Price, pB_Product,
                cb_KindOfProduct, cb_Unit, cb_Goods);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }



        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (presenter.handle_AddProduct(id, cb_Goods, cb_KindOfProduct,
                cb_Unit, pB_Product, default_img) == true)
            {
                presenter.refreshForm(txt_Name, txt_Price, txt_Quantity, cb_Goods,
                    cb_KindOfProduct, cb_Unit, pB_Product, default_img);
                parent.refreshDataGV();
            }
        }

        private void cb_KindOfProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
        }

        private void txt_Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
        }

        private void guna2Button2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void guna2Button2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pB_Product.Image = new Bitmap(open.FileName);
            }
        }
    }
}
