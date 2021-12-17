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
            if (dtGridView_OrderForm.Rows.Count > 1) dtGridView_OrderForm.CurrentCell.Selected = false;
        }

        void reloadGV()
        {
            dtGridView_OrderForm.Rows.Clear();
            od.showOrderForm(dtGridView_OrderForm);
            if (dtGridView_OrderForm.Rows.Count > 1) dtGridView_OrderForm.CurrentCell.Selected = false;
        }
        private void dtGridView_OrderForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < dtGridView_OrderForm.RowCount - 1)
            { 
                int id_order = int.Parse(dtGridView_OrderForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                lb_id_order.Text = id_order.ToString();

                od.showDetailOrderForm(fLayoutPl_Detail, id_order);
            } 
                 
        }

        private void btt_remove_Click(object sender, EventArgs e)
        {
            if(dtGridView_OrderForm.SelectedCells.Count > 0)
            {
                AlertDialog dialog = new AlertDialog();
                dialog.Show();
                dialog.btt_ok.Click += (s, a) =>
                {
                    int selected_index = dtGridView_OrderForm.SelectedCells[0].RowIndex;
                    DataGridViewRow selected_row = dtGridView_OrderForm.Rows[selected_index];
                    int id = Convert.ToInt32(selected_row.Cells[0].Value);
                    pro.removeAll(id);
                    od.deleteOrderForm(id);
                    fLayoutPl_Detail.Controls.Clear();
                    reloadGV();
                    MyMessageBox.showBox("Delete this order form successfully!", "Message");

                };
            }
            else MyMessageBox.showBox("Please choose order you want to remove!", "Message");
            
        }

        private void btt_confirm_Click(object sender, EventArgs e)
        {
            if (dtGridView_OrderForm.SelectedCells.Count > 0)
            {
                int selected_index1 = dtGridView_OrderForm.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row1 = dtGridView_OrderForm.Rows[selected_index1];
                int id_choose1 = Convert.ToInt32(selected_row1.Cells[0].Value);
                if (id != 0)
                {
                    ob.addOrderBill(id_choose1, id);
                    od.updateStatusOrderForm(id_choose1);
                   
                    reloadGV();
                    fLayoutPl_Detail.Controls.Clear();
                    lb_id_order.Text = "1";
                    MyMessageBox.showBox("Confirmed Order!", "Message");
                }
            }
            else
            {
                MyMessageBox.showBox("Please choose order you want to confirm!", "Message");
            }

        }


        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Search.Text == "")
                {
                    MyMessageBox.showBox("Please enter something before searching", "Message");
                }
                else MyMessageBox.showBox("The result of searching is below", "Message");
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            od.searchData(dtGridView_OrderForm, txt_Search.Text);
        }
    }
}
