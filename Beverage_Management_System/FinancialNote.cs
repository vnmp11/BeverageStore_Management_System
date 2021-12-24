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
    public partial class FinancialNote : Form, IFinancialNote
    {
        FinancialNotePresenter presenter;

        public string search_OrderBill { get => txt_SearchOrderBill.Text; set => txt_SearchOrderBill.Text = value; }
        public string search_GoodImportBill { get => txt_SearchGoodsImportBill.Text; set => txt_SearchGoodsImportBill.Text = value; }

        public FinancialNote()
        {
            InitializeComponent();
            presenter = new FinancialNotePresenter(this);
            presenter.setDataGV(dataGV_Goods_Import_Bill, dataGV_Order_Bill);
            dataGV_Goods_Import_Bill.AllowUserToAddRows = false;
            dataGV_Order_Bill.AllowUserToAddRows = false;
            if(dataGV_Goods_Import_Bill.Rows.Count > 0) dataGV_Goods_Import_Bill.CurrentCell.Selected = false;
            if(dataGV_Order_Bill.Rows.Count > 0) dataGV_Order_Bill.CurrentCell.Selected = false;
        }

        private void dataGV_Order_Bill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV_Order_Bill.SelectedCells.Count > 0)
            {
                int selected_index = dataGV_Order_Bill.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dataGV_Order_Bill.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID_ORDER_FORM"].Value);

                if (id_choose > 0)
                {
                    presenter.getDetailsOrderBill(id_choose, fLayoutPl_Details_Order_Bill);
                }

            }

        }

        private void dataGV_Goods_Import_Bill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV_Goods_Import_Bill.SelectedCells.Count > 0)
            {
                int selected_index = dataGV_Goods_Import_Bill.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dataGV_Goods_Import_Bill.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID_GOODS_IMPORT_BILL"].Value);

                if (id_choose > 0)
                {
                    presenter.getDetailsGoodsImportBill(id_choose, fLayoutPl_Details_Goods_Import_Bill);
                }

            }
        }

        private void txt_SearchOrderBill_TextChanged(object sender, EventArgs e)
        {
            if(txt_SearchOrderBill.Text != "")
            {
                dataGV_Order_Bill.AllowUserToAddRows = true;
                presenter.searchOrderBill(dataGV_Order_Bill);
                dataGV_Order_Bill.AllowUserToAddRows = false;
            }
            else
            {
                dataGV_Order_Bill.AllowUserToAddRows = true;
                dataGV_Order_Bill.Rows.Clear();
                presenter.setDataGV1(dataGV_Order_Bill);
                if (dataGV_Order_Bill.Rows.Count > 0) dataGV_Order_Bill.CurrentCell.Selected = false;
                dataGV_Order_Bill.AllowUserToAddRows = false;
            }
            
        }

        private void txt_SearchGoodsImportBill_TextChanged(object sender, EventArgs e)
        {
            if(txt_SearchGoodsImportBill.Text != "")
            {
                dataGV_Goods_Import_Bill.AllowUserToAddRows = true;
                presenter.searchGoodsImportBill(dataGV_Goods_Import_Bill);
                dataGV_Goods_Import_Bill.AllowUserToAddRows = false;
            }
            else
            {
                dataGV_Goods_Import_Bill.AllowUserToAddRows = true;
                dataGV_Goods_Import_Bill.Rows.Clear();
                presenter.setDataGV2(dataGV_Goods_Import_Bill);
                if (dataGV_Goods_Import_Bill.Rows.Count > 0) dataGV_Goods_Import_Bill.CurrentCell.Selected = false;
                dataGV_Goods_Import_Bill.AllowUserToAddRows = false;
            }
            
        }

        private void txt_SearchOrderBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_SearchOrderBill.Text == "")
                {
                    MyMessageBox.showBox("Please enter something before searching", "Message");
                }
                else MyMessageBox.showBox("The result of searching is below", "Message");
            }
        }

        private void txt_SearchGoodsImportBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_SearchGoodsImportBill.Text == "")
                {
                    MyMessageBox.showBox("Please enter something before searching", "Message");
                }
                else MyMessageBox.showBox("The result of searching is below", "Message");
            }
        }

        private void txt_SearchOrderBill_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_SearchGoodsImportBill_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
