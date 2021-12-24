using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System.Presenters
{
    class FinancialNotePresenter
    {
        IFinancialNote financialNoteView;

        List<MGoodsImportBill> goodsImportBills = new List<MGoodsImportBill>();
        List<MOrderBill> orderBills = new List<MOrderBill>();
        List<Person> accountants = new List<Person>();

        public FinancialNotePresenter(IFinancialNote view)
        {
            this.financialNoteView = view;
        }
        public FinancialNotePresenter()
        {
        }
        public void setDataGV(Guna.UI2.WinForms.Guna2DataGridView dataGV_Goods_Import_Bill, Guna.UI2.WinForms.Guna2DataGridView dataGV_Order_Bill)
        {
            setDataGVOrderBill_Fill(dataGV_Order_Bill);
            setDataGVGoodsImportBill_Fill(dataGV_Goods_Import_Bill);
        }

        public void setDataGV1(Guna.UI2.WinForms.Guna2DataGridView dataGV_Order_Bill)
        {
            setDataGVOrderBill_Fill(dataGV_Order_Bill);
        }

        public void setDataGV2(Guna.UI2.WinForms.Guna2DataGridView dataGV_Goods_Import_Bill)
        {
            setDataGVGoodsImportBill_Fill(dataGV_Goods_Import_Bill);
        }

        public void setDataGVOrderBill_Fill(Guna.UI2.WinForms.Guna2DataGridView dataGV_Order_Bill)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            orderBills = new List<MOrderBill>();
            accountants = new List<Person>();

            string query5 = "Select * from PERSON where ROLE = 3";
            SqlCommand cmd5 = new SqlCommand(query5, myConnection.sqlcon);
            SqlDataReader sdr5 = cmd5.ExecuteReader();
            while (sdr5.Read())
            {
                int id = (int)sdr5["ID_PERSON"];
                string name = sdr5["NAME"].ToString();

                Person person = new Person(id, "", "", name, "", "", "", "", 0);
                accountants.Add(person);
            }
            sdr5.Close();

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
                    orderBills.Add(orderBill);
                }

            }

            for (int i = 0; i < orderBills.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV_Order_Bill.Rows[i].Clone();
                row.Cells[0].Value = orderBills[i].getID();
                row.Cells[1].Value = orderBills[i].getID_ORDER_FORM();
                for (int j = 0; j < accountants.Count(); j++)
                {
                    if (accountants[j].getID() == orderBills[i].getID_ACCOUNTANT()) row.Cells[2].Value = accountants[j].getNAME();
                }
                row.Cells[3].Value = orderBills[i].getDATE_CONFIRM();
                row.Cells[4].Value = orderBills[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV_Order_Bill.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        public void setDataGVGoodsImportBill_Fill(Guna.UI2.WinForms.Guna2DataGridView dataGV_Goods_Import_Bill)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            goodsImportBills = new List<MGoodsImportBill>();

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
                    goodsImportBills.Add(goodsImportBill);
                }

            }

            for (int i = 0; i < goodsImportBills.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV_Goods_Import_Bill.Rows[i].Clone();
                row.Cells[0].Value = goodsImportBills[i].getID();
                row.Cells[1].Value = goodsImportBills[i].getID_GOODS_IMPORT_FORM();
                for (int j = 0; j < accountants.Count(); j++)
                {
                    if (accountants[j].getID() == goodsImportBills[i].getID_ACCOUNTANT()) row.Cells[2].Value = accountants[j].getNAME();
                }
                row.Cells[3].Value = goodsImportBills[i].getDATE_CONFIRM();
                row.Cells[4].Value = goodsImportBills[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV_Goods_Import_Bill.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        public void getDetailsGoodsImportBill(int ID, System.Windows.Forms.FlowLayoutPanel fLayoutPl_Details_Goods_Import_Bill)
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
        public void getDetailsOrderBill(int ID, System.Windows.Forms.FlowLayoutPanel fLayoutPl_Details_Order_Bill)
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
        public void searchOrderBill(Guna.UI2.WinForms.Guna2DataGridView dataGV_Order_Bill)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderBill> list = new List<MOrderBill>();
            dataGV_Order_Bill.Rows.Clear();

            string querry = "Select O.ID_ORDER_BILL, O.ID_ORDER_FORM, O.ID_BARTENDER, O.ID_ACCOUNTANT, " +
                "O.TOTAL_PRICE_PRODUCTS, O.FINE, O.DATE_CON, O.TOTAL_PRICE, P.NAME from ORDER_BILL O join PERSON P on O.ID_ACCOUNTANT = P.ID_PERSON " +
                "where STATUS = 1 and (O.ID_ORDER_BILL like '" + financialNoteView.search_OrderBill + "%' or " +
                    "O.ID_ORDER_FORM like '" + financialNoteView.search_OrderBill + "%' or P.NAME like '" + financialNoteView.search_OrderBill + "%');";
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
                for (int j = 0; j < accountants.Count(); j++)
                {
                    if (accountants[j].getID() == list[i].getID_ACCOUNTANT()) row.Cells[2].Value = accountants[j].getNAME();
                }
                row.Cells[3].Value = list[i].getDATE_CONFIRM();
                row.Cells[4].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV_Order_Bill.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        public void searchGoodsImportBill(Guna.UI2.WinForms.Guna2DataGridView dataGV_Goods_Import_Bill)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MGoodsImportBill> list = new List<MGoodsImportBill>();
            dataGV_Goods_Import_Bill.Rows.Clear();

            string querry = "Select G.ID_GOODS_IMPORT_BILL, G.ID_GOODS_IMPORT_FORM, G.ID_BARTENDER, G.ID_ACCOUNTANT, " +
                "G.DATE_CON, G.TOTAL_PRICE, P.NAME from GOODS_IMPORT_BILL G join PERSON P on G.ID_ACCOUNTANT = P.ID_PERSON " +
                "where STATUS = 1 and (ID_GOODS_IMPORT_BILL like '" + financialNoteView.search_GoodImportBill + "%' or " +
                "ID_GOODS_IMPORT_FORM like '" + financialNoteView.search_GoodImportBill + "%' or P.NAME like '" + financialNoteView.search_GoodImportBill + "%');";
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
                for (int j = 0; j < accountants.Count(); j++)
                {
                    if (accountants[j].getID() == list[i].getID_ACCOUNTANT()) row.Cells[2].Value = accountants[j].getNAME();
                }
                row.Cells[3].Value = list[i].getDATE_CONFIRM();
                row.Cells[4].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV_Goods_Import_Bill.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

    }
}
