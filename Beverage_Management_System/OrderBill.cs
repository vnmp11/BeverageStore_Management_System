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
    public partial class OrderBill : Form, IOrderBill
    {
        OrderBillPresenter presenter;
        int id_accountant = 0;

        public string search { get => txt_Search.Text; set => txt_Search.Text = value; }

        public OrderBill()
        {
            InitializeComponent();
            presenter = new OrderBillPresenter(this);
        }

        public OrderBill(int ID)
        {
            InitializeComponent();
            this.id_accountant = ID;
            presenter = new OrderBillPresenter(this);
            presenter.setDataGV(dataGV);
            dataGV.AllowUserToAddRows = false;
            if(dataGV.Rows.Count > 0) dataGV.CurrentCell.Selected = false;
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV.SelectedCells.Count > 0)
            {
                int selected_index = dataGV.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dataGV.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID_ORDER_FORM"].Value);

                if (id_choose > 0)
                {
                    presenter.getDetailsOrderBill(id_choose, fLayoutPl_Details);
                }

            }

        }



        private void btt_Browse_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedCells.Count > 0)
            {
                AlertDialog dialog = new AlertDialog();
                dialog.setMessage("Do you want to browse this bill?");
                dialog.Show();
                dialog.btt_ok.Click += (s, a) =>
                {
                    AlertDialog print = new AlertDialog();
                    print.setMessage("Do you want to print this bill?");
                    print.Show();

                    print.btt_ok.Click += (d, b) =>
                    {
                        print.Close();
                        int selected_index1 = dataGV.SelectedCells[0].RowIndex;
                        DataGridViewRow selected_row1 = dataGV.Rows[selected_index1];
                        int id_choose1 = Convert.ToInt32(selected_row1.Cells["ID_ORDER_FORM"].Value);

                        presenter.printBill(id_choose1);


                        if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                        {
                            printDocument1.Print();

                        }
                        int selected_index = dataGV.SelectedCells[0].RowIndex;
                        DataGridViewRow selected_row = dataGV.Rows[selected_index];
                        int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);
                        int id_form = Convert.ToInt32(selected_row.Cells["ID_ORDER_FORM"].Value);
                        dataGV.AllowUserToAddRows = true;
                        presenter.browseBill(id_choose, id_accountant, dataGV, id_form, fLayoutPl_Details);
                        dataGV.AllowUserToAddRows = false;
                        if (dataGV.Rows.Count > 0) dataGV.CurrentCell.Selected = false;
                       

                    };
                    print.btt_cancel.Click += (d, b) =>
                    {
                        print.Close();
                        int selected_index = dataGV.SelectedCells[0].RowIndex;
                        DataGridViewRow selected_row = dataGV.Rows[selected_index];
                        int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);
                        int id_form = Convert.ToInt32(selected_row.Cells["ID_ORDER_FORM"].Value);
                        dataGV.AllowUserToAddRows = true;
                        presenter.browseBill(id_choose, id_accountant, dataGV, id_form, fLayoutPl_Details);
                        dataGV.AllowUserToAddRows = false;
                        if (dataGV.Rows.Count > 0) dataGV.CurrentCell.Selected = false;

                    };        
                };

                

            }
            else MyMessageBox.showBox("Please choose a bill which you want to browse!", "Message");
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dataGV.AllowUserToAddRows = true;
            presenter.searchBill(dataGV);
            dataGV.AllowUserToAddRows = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var fnt = new Font("Times new Roman", 14, FontStyle.Bold);
            var fnt1 = new Font("Times new Roman", 14, FontStyle.Regular);
            int x = 200, y = 200;
            int dy = (int)fnt.GetHeight(e.Graphics) * 1;

            String name = presenter.getNameOfAccountant(id_accountant);

            e.Graphics.DrawString("ORDER BILL", new Font("Times new Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(350, 50));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToString(), fnt, Brushes.Black, new PointF(200, 90));
            e.Graphics.DrawString("Accountant: " + name, fnt, Brushes.Black, new PointF(200, 90 + dy));
            //e.Graphics.DrawString("NUMBER ORDER: " + txb_IdOrder.Text, fnt, Brushes.Black, new PointF(200, 90 + dy + dy));

            e.Graphics.DrawString("Name", fnt, Brushes.Black, new PointF(200, 170));
           // e.Graphics.DrawString("Price", fnt, Brushes.Black, new PointF(400, 170));
            e.Graphics.DrawString("Quantity", fnt, Brushes.Black, new PointF(400, 170));
            e.Graphics.DrawString("Total", fnt, Brushes.Black, new PointF(500, 170));

            presenter.detailsBills.Count();

            for (int i = 0; i < presenter.detailsBills.Count(); i++)
            {
                e.Graphics.DrawString(presenter.detailsBills[i].lb_NameProduct.Text, fnt1, Brushes.Black, new PointF(200, y));
                 
                //int price = int.Parse(presenter.detailsBills[i].lb_total.Text.ToString("########0")) / int.Parse(presenter.detailsBills[i].lb_quantity.Text);


                //e.Graphics.DrawString(price.ToString(), fnt1, Brushes.Black, new PointF(400, y));

                e.Graphics.DrawString(presenter.detailsBills[i].lb_quantity.Text, fnt1, Brushes.Black, new PointF(400, y));

                e.Graphics.DrawString(presenter.detailsBills[i].lb_total.Text, fnt1, Brushes.Black, new PointF(500, y));
                y += dy;
            }

            e.Graphics.DrawString("------------------------------------------------------------------------", fnt, Brushes.Black, new PointF(200, y += dy));

            int selected_index = dataGV.SelectedCells[0].RowIndex;
            DataGridViewRow selected_row = dataGV.Rows[selected_index];
            string fine = selected_row.Cells["FINE"].Value.ToString();
            String total = selected_row.Cells["TOTAL_PRICE"].Value.ToString();

            e.Graphics.DrawString("Fine: " + fine.ToString(), fnt, Brushes.Black, new PointF(200, y += dy));
            y += dy;
            e.Graphics.DrawString("Total: " + total.ToString(), fnt, Brushes.Black, new PointF(200, y));
            y += dy;
            //e.Graphics.DrawString("Total Payable: " + lb_total.Text, fnt, Brushes.Black, new PointF(x, y));
            //y += dy;
            //e.Graphics.DrawString("Items Quantity: " + lb_QtyItem.Text, fnt, Brushes.Black, new PointF(x, y));
            //y += dy;
            e.Graphics.DrawString("Thanks and see you next time!", fnt, Brushes.Black, new PointF(320, y += dy));
        }
    }
}
