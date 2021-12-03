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
            dataGV.CurrentCell.Selected = false;
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fLayoutPl_Details.Visible = true;
            lb_Details.Visible = true;
            if (e.RowIndex < dataGV.RowCount - 1)
            {
                int id_order_form = int.Parse(dataGV.Rows[e.RowIndex].Cells[1].Value.ToString());
                presenter.getDetailsOrderBill(id_order_form, fLayoutPl_Details);
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
                    int selected_index = dataGV.SelectedCells[0].RowIndex;
                    DataGridViewRow selected_row = dataGV.Rows[selected_index];
                    int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                    presenter.browseBill(id_choose, id_accountant, dataGV, lb_Details, fLayoutPl_Details);
                };

            }
            else MyMessageBox.showBox("Please choose a bill which you want to browse!", "Message");
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            presenter.searchBill(dataGV);
        }
    }
}
