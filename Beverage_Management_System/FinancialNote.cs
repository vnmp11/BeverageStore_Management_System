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
        public FinancialNote()
        {
            InitializeComponent();
            presenter = new FinancialNotePresenter(this);
            presenter.setDataGV();
            dataGV_Goods_Import_Bill.CurrentCell.Selected = false;
            dataGV_Order_Bill.CurrentCell.Selected = false;
        }

        public void getDetailsGoodsImportBill(int ID)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            fLayoutPl_Details_Goods_Import_Bill.Controls.Clear();

            string query = "Select DGIB.ID_GOODS, G.NAME, DGIB.QUANTITY, DGIB.TOTAL_PRICE from " +
                "(GOODS_IMPORT_BILL GIB join DETAILS_GOODS_IMPORT_BILL DGIB on GIB.ID_GOODS_IMPORT_BILL = DGIB.ID_GOODS_IMPORT_BILL) join " +
                "GOODS G on DGIB.ID_GOODS = G.ID_GOODS where GIB.ID_GOODS_IMPORT_BILL ='" + ID + "';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id_goods = Convert.ToInt32(sdr["ID_GOODS"]);
                string name = sdr["NAME"].ToString();
                int quantity = Convert.ToInt32(sdr["QUANTITY"]);
                double total_price = Convert.ToDouble(sdr["TOTAL_PRICE"]);

                DetailsBill i = new DetailsBill();
                i.lb_ID_Title.Text = "ID Goods: ";
                i.lb_ID_Product.Text = id_goods.ToString();
                i.lb_NameProduct.Text = name;
                i.lb_quantity.Text = quantity.ToString();
                i.lb_total.Text = total_price.ToString("###,###,##0");
                fLayoutPl_Details_Goods_Import_Bill.Controls.Add(i);
            }
            myConnection.sqlcon.Close();
        }

        public void getDetailsOrderBill(int ID)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            fLayoutPl_Details_Order_Bill.Controls.Clear();

            string query = "Select P.ID_PRODUCT, P.NAME, DO.QUANTITY, DO.TOTAL_PRICE from " +
                "(ORDERFORM O join DETAILS_ORDERFORM DO on O.ID_ORDERFORM = DO.ID_ORDERFORM) join " +
                "PRODUCT P on DO.ID_PRODUCT = P.ID_PRODUCT where O.ID_ORDERFORM ='" + ID + "';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id_product = Convert.ToInt32(sdr["ID_PRODUCT"]);
                string name = sdr["NAME"].ToString();
                int quantity = Convert.ToInt32(sdr["QUANTITY"]);
                double total_price = Convert.ToDouble(sdr["TOTAL_PRICE"]);

                DetailsBill i = new DetailsBill();
                i.lb_ID_Product.Text = id_product.ToString();
                i.lb_NameProduct.Text = name;
                i.lb_quantity.Text = quantity.ToString();
                i.lb_total.Text = total_price.ToString("###,###,##0");
                fLayoutPl_Details_Order_Bill.Controls.Add(i);
            }
            myConnection.sqlcon.Close();
        }

        public void setDataGVGoodsImportBill_Fill()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MGoodsImportBill> list = new List<MGoodsImportBill>();

            DataTable dt = new DataTable();
            string querry = "Select * from GOODS_IMPORT_BILL where STATUS = 1;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_GOODS_IMPORT_BILL"]);
                    int ID_GOODS_IMPORT_FORM = Convert.ToInt32(row["ID_GOODS_IMPORT_FORM"]);
                    int ID_BARTENDER = Convert.ToInt32(row["ID_BARTENDER"]);
                    int ID_ACCOUNTANT = Convert.ToInt32(row["ID_ACCOUNTANT"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CON"]);
                    string DATE_CON = date.ToString("dd-MM-yyyy");
                    double TOTAL_PRICE = Convert.ToDouble(row["TOTAL_PRICE"]);
                    int STATUS = 1;

                    MGoodsImportBill goodsImportBill = new MGoodsImportBill(ID, ID_BARTENDER, ID_ACCOUNTANT, ID_GOODS_IMPORT_FORM, TOTAL_PRICE, "", DATE_CON, STATUS);
                    list.Add(goodsImportBill);
                }

            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV_Goods_Import_Bill.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getID_GOODS_IMPORT_FORM();
                row.Cells[2].Value = list[i].getID_ACCOUNTANT();
                row.Cells[3].Value = list[i].getDATE_CONFIRM();
                row.Cells[4].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV_Goods_Import_Bill.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        public void setDataGVOrderBill_Fill()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderBill> list = new List<MOrderBill>();

            DataTable dt = new DataTable();
            string querry = "Select * from ORDER_BILL where STATUS = 1;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_ORDER_BILL"]);
                    int ID_ORDER_FORM = Convert.ToInt32(row["ID_ORDER_FORM"]);
                    int ID_BARTENDER = Convert.ToInt32(row["ID_BARTENDER"]);
                    int ID_ACCOUNTANT = Convert.ToInt32(row["ID_ACCOUNTANT"]);
                    double TOTAL_PRICE_PRODUCTS = Convert.ToDouble(row["TOTAL_PRICE_PRODUCTS"]);
                    double FINE = Convert.ToDouble(row["FINE"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CON"]);
                    string DATE_CON = date.ToString("dd-MM-yyyy");
                    double TOTAL_PRICE = Convert.ToDouble(row["TOTAL_PRICE"]);
                    int STATUS = 1;


                    MOrderBill orderBill = new MOrderBill(ID, ID_ORDER_FORM, ID_BARTENDER, ID_ACCOUNTANT, TOTAL_PRICE_PRODUCTS, FINE, "", DATE_CON, TOTAL_PRICE, STATUS);
                    list.Add(orderBill);
                }

            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV_Order_Bill.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getID_ORDER_FORM();
                row.Cells[2].Value = list[i].getID_ACCOUNTANT();
                row.Cells[3].Value = list[i].getDATE_CONFIRM();
                row.Cells[4].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV_Order_Bill.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        private void dataGV_Order_Bill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fLayoutPl_Details_Order_Bill.Visible = true;
            lb_Details_Order_Bill.Visible = true;
            if (e.RowIndex < dataGV_Order_Bill.RowCount - 1)
            {
                int id_order_form = int.Parse(dataGV_Order_Bill.Rows[e.RowIndex].Cells[1].Value.ToString());
                presenter.getDetailsOrderBill(id_order_form);
            }
        }

        private void dataGV_Goods_Import_Bill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fLayoutPl_Details_Goods_Import_Bill.Visible = true;
            lb_Details_Goods_Import_Bill.Visible = true;
            if (e.RowIndex < dataGV_Goods_Import_Bill.RowCount - 1)
            {
                int id_goods_import_bill = int.Parse(dataGV_Goods_Import_Bill.Rows[e.RowIndex].Cells[0].Value.ToString());
                presenter.getDetailsGoodsImportBill(id_goods_import_bill);
            }
        }

        private void txt_SearchOrderBill_TextChanged(object sender, EventArgs e)
        {
            presenter.searchOrderBill();
        }

        private void txt_SearchGoodsImportBill_TextChanged(object sender, EventArgs e)
        {
            presenter.searchGoodsImportBill();
        }

        public void searchOrderBill()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderBill> list = new List<MOrderBill>();
            dataGV_Order_Bill.Rows.Clear();

            string querry = "Select * from ORDER_BILL where STATUS = 1 and (ID_ORDER_BILL like '" + txt_SearchOrderBill.Text + "%' or ID_ORDER_FORM like '" + txt_SearchOrderBill.Text + "%');";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_ORDER_BILL"]);
                    int ID_ORDER_FORM = Convert.ToInt32(row["ID_ORDER_FORM"]);
                    int ID_BARTENDER = Convert.ToInt32(row["ID_BARTENDER"]);
                    int ID_ACCOUNTANT = Convert.ToInt32(row["ID_ACCOUNTANT"]);
                    double TOTAL_PRICE_PRODUCTS = Convert.ToDouble(row["TOTAL_PRICE_PRODUCTS"]);
                    double FINE = Convert.ToDouble(row["FINE"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CON"]);
                    string DATE_CON = date.ToString("dd-MM-yyyy");
                    double TOTAL_PRICE = Convert.ToDouble(row["TOTAL_PRICE"]);


                    MOrderBill orderBill = new MOrderBill(ID, ID_ORDER_FORM, ID_BARTENDER, ID_ACCOUNTANT, TOTAL_PRICE_PRODUCTS, FINE, "", DATE_CON, TOTAL_PRICE, 1);
                    list.Add(orderBill);
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV_Order_Bill.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getID_ORDER_FORM();
                row.Cells[2].Value = list[i].getID_ACCOUNTANT();
                row.Cells[3].Value = list[i].getDATE_CONFIRM();
                row.Cells[4].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV_Order_Bill.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        public void searchGoodsImportBill()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MGoodsImportBill> list = new List<MGoodsImportBill>();
            dataGV_Goods_Import_Bill.Rows.Clear();

            string querry = "Select * from GOODS_IMPORT_BILL where STATUS = 1 and (ID_GOODS_IMPORT_BILL like '" + txt_SearchGoodsImportBill.Text + "%' or ID_GOODS_IMPORT_FORM like '" + txt_SearchGoodsImportBill.Text + "%');";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_GOODS_IMPORT_BILL"]);
                    int ID_GOODS_IMPORT_FORM = Convert.ToInt32(row["ID_GOODS_IMPORT_FORM"]);
                    int ID_BARTENDER = Convert.ToInt32(row["ID_BARTENDER"]);
                    int ID_ACCOUNTANT = Convert.ToInt32(row["ID_ACCOUNTANT"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CON"]);
                    string DATE_CON = date.ToString("dd-MM-yyyy");
                    double TOTAL_PRICE = Convert.ToDouble(row["TOTAL_PRICE"]);


                    MGoodsImportBill goodsImportBill = new MGoodsImportBill(ID, ID_BARTENDER, ID_ACCOUNTANT, ID_GOODS_IMPORT_FORM, TOTAL_PRICE, "", DATE_CON, 1);
                    list.Add(goodsImportBill);
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV_Goods_Import_Bill.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getID_GOODS_IMPORT_FORM();
                row.Cells[2].Value = list[i].getID_ACCOUNTANT();
                row.Cells[3].Value = list[i].getDATE_CONFIRM();
                row.Cells[4].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV_Goods_Import_Bill.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }
    }
}
