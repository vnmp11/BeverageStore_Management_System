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
    public partial class Item : UserControl
    {
        int id_product;
        string quantity;
        string total_price;
        String name;
        string price;

        public Item()
        {
            InitializeComponent();
        }

        public Item(string quantity, string price, String name, string total_price, Image img)
        {
            lb_NameProduct.Text = name;
            lb_quantity.Text = quantity;
            lb_total.Text = total_price;
            lb_price.Text = price;
            pB_ProductImage.Image = img;
        }

        public String LabelName
        {
            get
            {
                return lb_NameProduct.Text;
            }
            set
            {
                lb_NameProduct.Text = value;
            }
        }

        public string LabelPrice
        {
            get
            {
                return lb_price.Text;
            }
            set
            {
                lb_price.Text = value;
            }
        }

        public string LabelTotal_Price
        {
            get
            {
                return lb_total.Text;
            }
            set
            {
                lb_total.Text = value;
            }
        }

        public string LabelQuantity
        {
            get
            {
                return lb_quantity.Text;
            }
            set
            {
                lb_quantity.Text = value;
            }
        }

        public Image PbItem
        {
            get
            {
                return pB_ProductImage.Image;
            }
            set
            {
                pB_ProductImage.Image = value;
            }
        }


        private void lb_total_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lb_price_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_NameProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
