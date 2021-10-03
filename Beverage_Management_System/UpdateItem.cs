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
    public partial class UpdateItem : Form
    {
        int id_item;
        int id_order;
        public UpdateItem()
        {
            InitializeComponent();
        }

        public UpdateItem(String quantity, int id, int idorder)
        {
            InitializeComponent();
            txb_quantity.Text = quantity;
            id_item = id;
            id_order = idorder;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {

        }

        private void btt_plus_Click(object sender, EventArgs e)
        {
            txb_quantity.Text = (int.Parse(txb_quantity.Text) + 1).ToString();
        }

        private void btt_minus_Click(object sender, EventArgs e)
        {
            if (int.Parse(txb_quantity.Text) > 1)
            {
                txb_quantity.Text = (int.Parse(txb_quantity.Text) - 1).ToString();
            }
        }
        private void txb_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public void btt_ok_Click(object sender, EventArgs e)
        {
            ProductPresenter p = new ProductPresenter();
            p.addItem(id_item, id_order.ToString() , int.Parse(txb_quantity.Text)-p.getQuantity(id_item));
            this.Close();
        }

        private void btt_remove_Click(object sender, EventArgs e)
        {
            ProductPresenter p = new ProductPresenter();
            p.removeItem(id_item);
            this.Close();

        }
    }
}
