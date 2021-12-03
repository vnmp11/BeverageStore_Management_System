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
            dataGV_Goods_Import_Bill.CurrentCell.Selected = false;
            dataGV_Order_Bill.CurrentCell.Selected = false;
        }

        private void dataGV_Order_Bill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGV_Order_Bill.RowCount - 1)
            {
                int id_order_form = int.Parse(dataGV_Order_Bill.Rows[e.RowIndex].Cells[1].Value.ToString());
                presenter.getDetailsOrderBill(id_order_form, fLayoutPl_Details_Order_Bill);
            }
        }

        private void dataGV_Goods_Import_Bill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGV_Goods_Import_Bill.RowCount - 1)
            {
                int id_goods_import_bill = int.Parse(dataGV_Goods_Import_Bill.Rows[e.RowIndex].Cells[0].Value.ToString());
                presenter.getDetailsGoodsImportBill(id_goods_import_bill, fLayoutPl_Details_Goods_Import_Bill);
            }
        }

        private void txt_SearchOrderBill_TextChanged(object sender, EventArgs e)
        {
            presenter.searchOrderBill(dataGV_Order_Bill);
        }

        private void txt_SearchGoodsImportBill_TextChanged(object sender, EventArgs e)
        {
            presenter.searchGoodsImportBill(dataGV_Goods_Import_Bill);
        }

    }
}
