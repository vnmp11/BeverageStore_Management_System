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
    public partial class OrderForm : Form
    {
        OrderFormPresenter o = new OrderFormPresenter();
        public OrderForm()
        {
            InitializeComponent();
            o.showOrderForm(dtGridView_OrderForm);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void dtGridView_OrderForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < dtGridView_OrderForm.RowCount - 1)
            { 
                int id_order = int.Parse(dtGridView_OrderForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                label2.Text = id_order.ToString();

                o.showDetailOrderForm(flowLayoutPanel1, id_order);
            } 
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

        }
    }
}
