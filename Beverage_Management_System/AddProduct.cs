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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            int result = presenter.handle_AddProduct(id, cb_Goods, cb_KindOfProduct,
                cb_Unit, pB_Product, default_img);
            if (result == 1)
            {
                presenter.refreshForm(txt_Name, txt_Price, txt_Quantity, cb_Goods,
                    cb_KindOfProduct, cb_Unit, pB_Product, default_img);
                parent.refreshDataGV();
            }
            else if (result == 2)
            {
                parent.refreshDataGV();
            }
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

      

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pB_Product.Image = new Bitmap(open.FileName);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            if (cb_Goods.Items.Count > 0) cb_Goods.SelectedIndex = 0;
            if (cb_KindOfProduct.Items.Count > 0) cb_KindOfProduct.SelectedIndex = 0;
            if (cb_Unit.Items.Count > 0) cb_Unit.SelectedIndex = 0;
            txt_Price.Text = "";
            txt_Quantity.Text = "";
            pB_Product.Image = default_img;
        }

        private void guna2Button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Save.PerformClick();
            }
            
        }
    }
}
