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
    public partial class DetailsBill : UserControl
    {
        public DetailsBill()
        {
            InitializeComponent();
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

        public string LabelID
        {
            get
            {
                return lb_ID_Product.Text;
            }
            set
            {
                lb_ID_Product.Text = value;
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

        private void lb_total_Click(object sender, EventArgs e)
        {

        }
    }
}
