
using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.Presenters;
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
    public partial class Product : UserControl
    {
        //add kind
        int id_product;
        int quantity;
        int price;
        int kind;
        AddQuatity qty;


        public Product()
        {
            InitializeComponent();
        }

        public Product(String name, String price)
        {
            LabelProduct = name;
            LabelPrice = price;
        }

        public Image ImageProduct
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

        public string LabelProduct
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

        public int idProduct
        {
            get
            {
                return id_product;
            }
            set
            {
                id_product = value;
            }
        }

        public int p_kind
        {
            get
            {
                return kind;
            }
            set
            {
                kind = value;
            }
        }

        public int p_Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }


        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }


        public string LabelPrice
        {
            get
            {
                return lb_Price.Text;
            }
            set
            {
                lb_Price.Text = value;
            }
        }

        public void Product_Click(object sender, EventArgs e)
        {
            if (quantity == 0)
            {
                this.Click += new EventHandler(this.showBox);
            }
            else
            {       
                qty = new AddQuatity(true);
                Menu menu = (Menu) this.Parent.Parent;
                qty.Show();

                ProductPresenter pre = new ProductPresenter();

                qty.btt_ok.Click += (s, a) => {
                    Guna.UI2.WinForms.Guna2TextBox c = menu.txb_IdOrder;
                    MessageBox.Show("quantity: " + qty.txbQuantity);
                    pre.addItem(this.idProduct, c.Text, int.Parse(qty.txbQuantity));
                    menu.reloadFlowLayout();
                    menu.showTotal();
                };

            }

        }

        private void lb_Price_Click(object sender, EventArgs e)
        {

        }

        private void lb_Price_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(lb_Price.Text, System.Globalization.NumberStyles.AllowThousands);
            lb_Price.Text = String.Format(culture, "{0:N0}", value);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void lb_NameProduct_Click(object sender, EventArgs e)
        {

        }

        public void Product_Load(object sender, EventArgs e)
        {

        }

        public void showBox(object sender, EventArgs e)
        {
            MyMessageBox.showBox("This product is sold out.", "Message");
        }

        public void Product_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
