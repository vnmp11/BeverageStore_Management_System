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
        ProductPresenter pro = new ProductPresenter();
        OrderFormPresenter od = new OrderFormPresenter();
        OrderBillPresenter ob = new OrderBillPresenter();

        int id;
        static int id_waiter;
        public OrderForm(int id_batender)
        {
            InitializeComponent();
            id = id_batender;
            od.showOrderForm(dtGridView_OrderForm);
        }

        void reloadGV()
        {
            dtGridView_OrderForm.Rows.Clear();
            od.showOrderForm(dtGridView_OrderForm);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dtGridView_OrderForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < dtGridView_OrderForm.RowCount - 1)
            { 
                int id_order = int.Parse(dtGridView_OrderForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                id_waiter = int.Parse(dtGridView_OrderForm.Rows[e.RowIndex].Cells[1].Value.ToString());
                lb_id_order.Text = id_order.ToString();

                od.showDetailOrderForm(fLayoutPl_Detail, id_order);
            } 
                 
        }

        private void btt_remove_Click(object sender, EventArgs e)
        {
           
            int id = int.Parse(lb_id_order.Text);
            AlertDialog dialog = new AlertDialog();
            dialog.Show();
            dialog.btt_ok.Click += (s, a) =>
            {
              
                if ((id < int.Parse(pro.show_id()) && id != 1))
                {
         
                    pro.removeAll(id);
                    od.deleteOrderForm(id);
                    fLayoutPl_Detail.Controls.Clear();
                    reloadGV();
                }
                else
                {
                    MyMessageBox.showBox("Please choose order you want to remove!", "Message");
                }
            };
            
        }

        private void btt_confirm_Click(object sender, EventArgs e)
        {
            if (id_waiter != 0)
            {
                ob.addOrderBill(int.Parse(lb_id_order.Text), id);
                od.updateStatusOrderForm(int.Parse(lb_id_order.Text));
                reloadGV();
                fLayoutPl_Detail.Controls.Clear();
                lb_id_order.Text = "1";

                MyMessageBox.showBox("Confirmed Order!", "Message");
            }
            else
            {
                MyMessageBox.showBox("Please choose order you want to confirm!", "Message");
            }

        }
    }
}
