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
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
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

        private void Product_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click");
        }

        private void lb_Price_Click(object sender, EventArgs e)
        {

        }

        private void pB_ProductImage_Click(object sender, EventArgs e)
        {

        }
    }
}
