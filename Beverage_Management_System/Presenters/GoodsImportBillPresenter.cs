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
    class GoodsImportBillPresenter
    {
        IGoodsImportBill goodsImportBillView;
        List<MGoodsImportBill> goodsImportBills = new List<MGoodsImportBill>();

        public GoodsImportBillPresenter(IGoodsImportBill view)
        {
            this.goodsImportBillView = view;
        }
        public GoodsImportBillPresenter()
        {
        }
        public void setDataGV(Guna.UI2.WinForms.Guna2DataGridView dataGV)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            goodsImportBills = new List<MGoodsImportBill>();

            DataTable dt = new DataTable();
            string querry = "Select * from GOODS_IMPORT_BILL where STATUS = 0;";
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
                    DateTime date = Convert.ToDateTime(row["DATE_CRE"]);
                    string DATE_CRE = date.ToString("dd-MM-yyyy");
                    double TOTAL_PRICE = Convert.ToDouble(row["TOTAL_PRICE"]);
                    int STATUS = 0;

                    MGoodsImportBill goodsImportBill = new MGoodsImportBill(ID, ID_BARTENDER, ID_ACCOUNTANT, ID_GOODS_IMPORT_FORM, TOTAL_PRICE, DATE_CRE);
                    goodsImportBills.Add(goodsImportBill);
                }

            }

            for (int i = 0; i < goodsImportBills.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = goodsImportBills[i].getID();
                row.Cells[1].Value = goodsImportBills[i].getID_GOODS_IMPORT_FORM();
                row.Cells[2].Value = goodsImportBills[i].getID_BARTENDER();
                row.Cells[3].Value = goodsImportBills[i].getDATE_CREATE();
                row.Cells[4].Value = goodsImportBills[i].getDATE_CONFIRM();
                row.Cells[5].Value = goodsImportBills[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }
        public void getDetailsGoodsImportBill(int ID, System.Windows.Forms.FlowLayoutPanel fLayoutPl_Details)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            fLayoutPl_Details.Controls.Clear();

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
                fLayoutPl_Details.Controls.Add(i);
            }
            myConnection.sqlcon.Close();
        }
        public void browseBill(int ID, int id_accountant,
            Guna.UI2.WinForms.Guna2DataGridView dataGV,
            System.Windows.Forms.Label lb_Details, System.Windows.Forms.FlowLayoutPanel fLayoutPl_Details)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            int count = 0;

            string date_confirm = DateTime.Now.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("Update GOODS_IMPORT_BILL set ID_ACCOUNTANT=@id_accountant, DATE_CON=@date_con, STATUS=@status where ID_GOODS_IMPORT_BILL=@id;",
                myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_accountant", id_accountant);
            cmd.Parameters.AddWithValue("@date_con", date_confirm);
            cmd.Parameters.AddWithValue("@status", 1);
            cmd.Parameters.AddWithValue("@id", ID);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                List<MProduct> list_transaction = new List<MProduct>();
                List<MProduct> list = new List<MProduct>();

                string query1 = "Select P.ID_PRODUCT, P.NAME, P.QUANTITY AS Q1, DGIB.QUANTITY AS Q2, G.QUANTITY AS Q3 from " +
                    "((GOODS_IMPORT_BILL GIB join DETAILS_GOODS_IMPORT_BILL DGIB on GIB.ID_GOODS_IMPORT_BILL = DGIB.ID_GOODS_IMPORT_BILL) join " +
                    "PRODUCT P on DGIB.ID_GOODS = P.ID_GOODS) join " +
                    "GOODS G on P.ID_GOODS = G.ID_GOODS where DGIB.ID_GOODS_IMPORT_BILL ='" + ID + "';";
                SqlCommand cmd1 = new SqlCommand(query1, myConnection.sqlcon);
                SqlDataReader sdr = cmd1.ExecuteReader();
                while (sdr.Read())
                {
                    int id_product = Convert.ToInt32(sdr["ID_PRODUCT"]);
                    string name = sdr["NAME"].ToString();
                    int inventory_quantity = Convert.ToInt32(sdr["Q1"]);
                    int import_quantity = Convert.ToInt32(sdr["Q2"]);
                    int quantity_per_unit = Convert.ToInt32(sdr["Q3"]);

                    int quantity = inventory_quantity + import_quantity * quantity_per_unit;

                    MProduct product_transaction = new MProduct(id_product, 0, 0, name, 0, "", import_quantity * quantity_per_unit, null);
                    list_transaction.Add(product_transaction);

                    MProduct product = new MProduct(id_product, 0, 0, name, 0, "", quantity, null);
                    list.Add(product);
                }
                sdr.Close();

                SqlCommand cmd2 = new SqlCommand("Insert into TRACKING_NOTE(KIND, DATE_CON, ID_BILL) values (@kind, @date_con, @id_bill);", myConnection.sqlcon);
                cmd2.Parameters.AddWithValue("@kind", 2);
                cmd2.Parameters.AddWithValue("@date_con", date_confirm);
                cmd2.Parameters.AddWithValue("@id_bill", ID);
                int result2 = cmd2.ExecuteNonQuery();
                if (result2 > 0)
                {
                    string query3 = "Select MAX(ID_TRACKING_NOTE) as MAX from TRACKING_NOTE;";
                    SqlCommand cmd3 = new SqlCommand(query3, myConnection.sqlcon);
                    SqlDataReader dr = cmd3.ExecuteReader();
                    if (dr.Read())
                    {
                        int id_tracking_note = Convert.ToInt32(dr["MAX"]);
                        dr.Close();

                        for (int i = 0; i < list_transaction.Count(); i++)
                        {
                            SqlCommand cmd4 = new SqlCommand("Insert into DETAILS_TRACKING_NOTE(ID_PRODUCT,ID_TRACKING_NOTE, NAME, QUANTITY) values (@id_product,@id_tracking_note,@name,@quantity);",
                                myConnection.sqlcon);
                            cmd4.Parameters.AddWithValue("@id_product", list_transaction[i].getID());
                            cmd4.Parameters.AddWithValue("@id_tracking_note", id_tracking_note);
                            cmd4.Parameters.AddWithValue("@name", list_transaction[i].getNAME());
                            cmd4.Parameters.AddWithValue("@quantity", list_transaction[i].getQUANTITY());

                            cmd4.ExecuteNonQuery();

                            SqlCommand cmd5 = new SqlCommand("Update PRODUCT set QUANTITY=@quantity Where ID_PRODUCT ='" + list_transaction[i].getID() + "';", myConnection.sqlcon);
                            cmd5.Parameters.AddWithValue("@quantity", list[i].getQUANTITY());

                            int result5 = cmd5.ExecuteNonQuery();
                            if (result5 > 0)
                            {
                                count++;
                            }
                            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");

                        }
                    }
                }
                if (count == list.Count())
                {
                    dataGV.Rows.Clear();
                    setDataGV(dataGV);
                    fLayoutPl_Details.Visible = false;
                    lb_Details.Visible = false;

                    MyMessageBox.showBox("Browse this bill successfully!", "Message");
                }

            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            myConnection.sqlcon.Close();
        }
        public void searchBill(Guna.UI2.WinForms.Guna2DataGridView dataGV)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MGoodsImportBill> list = new List<MGoodsImportBill>();
            dataGV.Rows.Clear();

            string querry = "Select * from GOODS_IMPORT_BILL where STATUS = 0 and (ID_GOODS_IMPORT_BILL like '" + goodsImportBillView.search + "%' or ID_GOODS_IMPORT_FORM like '" + goodsImportBillView.search + "%');";
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
                    DateTime date = Convert.ToDateTime(row["DATE_CRE"]);
                    string DATE_CRE = date.ToString("dd-MM-yyyy");
                    double TOTAL_PRICE = Convert.ToDouble(row["TOTAL_PRICE"]);


                    MGoodsImportBill goodsImportBill = new MGoodsImportBill(ID, ID_BARTENDER, ID_ACCOUNTANT, ID_GOODS_IMPORT_FORM, TOTAL_PRICE, DATE_CRE);
                    list.Add(goodsImportBill);
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getID_GOODS_IMPORT_FORM();
                row.Cells[2].Value = list[i].getID_BARTENDER();
                row.Cells[3].Value = list[i].getDATE_CREATE();
                row.Cells[4].Value = list[i].getDATE_CONFIRM();
                row.Cells[5].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }
    }
}
