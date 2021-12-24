using Beverage_Management_System.Presenters;
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
    public partial class DetailOrder : UserControl
    {
        public int id;
        public int kind;
        public int id_order;
        decimal oldValue;
        ProductPresenter p = new ProductPresenter();
        public DetailOrder()
        {
            InitializeComponent();
        }

        public DetailOrder(string quantity, string price, String name, string total_price)
        {
            LabelName = name;
            NumberRicQuantity = quantity;
            LabelTotal_Price = total_price;
            LabelPrice = price;
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

        public string LabelIn_Stock
        {
            get
            {
                return lb_InStock.Text;
            }
            set
            {
                lb_InStock.Text = value;
            }
        }

        public string NumberRicQuantity
        {
            get
            {
                return txb_quatityItem.Text;
            }
            set
            {
                txb_quatityItem.Text = value;
            }
        }

        private void DetailOrder_Load(object sender, EventArgs e)
        {
            
        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            Menu menu2 = (Menu)this.Parent.Parent;
            p.removeItem(id, id_order);
            menu2.pl_Order.Controls.Remove(this);
            menu2.showTotal();
        }

        private void nR_quantity_ValueChanged(object sender, EventArgs e)
        {
            
        }
      
        private void nR_quantity_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void nR_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void nR_quantity_Click(object sender, EventArgs e)
        {
            
        }

        private void DetailOrder_Click(object sender, EventArgs e)
        {
            Menu menu = (Menu)this.Parent.Parent;
            AddQuatity qty = new AddQuatity();
            int current_qty = p.getQuantity(id, id_order.ToString());
            qty.txb_quantity.Text = current_qty.ToString();
            qty.Show();

            qty.btt_ok.Click += (s, a) =>
            {
                int quantity = int.Parse(qty.txbQuantity);
                p.addItem(id, id_order.ToString(), quantity-current_qty);
                menu.reloadFlowLayout();
            };

            }
    }
}
