using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System.Presenters
{
    class ImportGoodsPresenter
    {

        IAddImportGoods importGoodsView;
        IImportGoods importGoods;

        List<MProduct> list_product = new List<MProduct>();
        List<KindOfProduct> list_kind = new List<KindOfProduct>();

        public ImportGoodsPresenter(IAddImportGoods view, int id)
        {
            importGoodsView = view;
        }
        public ImportGoodsPresenter()
        {

        }
        public ImportGoodsPresenter(IImportGoods view)
        {
            importGoods = view;
        }
        public void setDataGV(Guna.UI2.WinForms.Guna2DataGridView DtaGridView_Warehouse)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            list_product = new List<MProduct>();

            DataTable dt = new DataTable();
            string querry = "Select ID_PRODUCT, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY from PRODUCT where QUANTITY < 100;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_PRODUCT"]);
                    int ID_KIND = Convert.ToInt32(row["ID_KIND"]);
                    int ID_GOODS = Convert.ToInt32(row["ID_GOODS"]);
                    string NAME = row["NAME"].ToString();
                    double PRICE = Convert.ToDouble(row["PRICE"]);
                    string UNIT = row["UNIT"].ToString();
                    int QUANTITY = Convert.ToInt32(row["QUANTITY"]);
                    byte[] IMAGE = null;


                    MProduct product = new MProduct(ID, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY, IMAGE);
                    list_product.Add(product);
                }

            }

            for (int i = 0; i < list_product.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)DtaGridView_Warehouse.Rows[i].Clone();
                row.Cells[0].Value = list_product[i].getID();
                row.Cells[1].Value = list_product[i].getNAME();
                row.Cells[2].Value = list_product[i].getQUANTITY();
                DtaGridView_Warehouse.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        public void addDataGV_ImportGoods(DataGridView data, int id, string name, int quantity)
        {


            data.Rows.Add(id, name, quantity);

        }

        public int show_id()
        {
            String query1 = "Select Max(ID_GOODS_IMPORT_FORM) from GOODS_IMPORT_FORM;";

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand(query1, myConnection.sqlcon);
            int id_order = (int)cmd.ExecuteScalar();

            myConnection.sqlcon.Close();
            return id_order;

        }

        public void updateImportForm()
        {
            string idPerson = importGoodsView.id_Person.Trim();
            string aDateTime = importGoodsView.date.Trim();
            string idForm = importGoodsView.id_IG.Trim();

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update GOODS_IMPORT_FORM set ID_PERSON=@id, DATE_CRE=@date where ID_GOODS_IMPORT_FORM=@idForm;", myConnection.sqlcon);


            aDateTime = DateTime.Now.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@id", idPerson);
            cmd.Parameters.AddWithValue("@date", aDateTime);
            cmd.Parameters.AddWithValue("@idForm", idForm);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {


            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
        }

        public void addImportForm()
        {

            //string idForm = importGoodsView.id_IG.Trim();


            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO GOODS_IMPORT_FORM ( STATUS) VALUES('0');", myConnection.sqlcon);




            // cmd.Parameters.AddWithValue("@idIG", idForm);


            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MyMessageBox.showBox("Add successfully!", "Message");
            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
        }

        public bool deleteImportForm(int id_choose)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd1 = new SqlCommand("Delete from DETAIL_GOODS_IMPORT_FORM where ID_GOODS_IMPORT_FORM=@id;", myConnection.sqlcon);
            cmd1.Parameters.AddWithValue("@id", id_choose);
            cmd1.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("Delete from GOODS_IMPORT_FORM where ID_GOODS_IMPORT_FORM=@id;", myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id", id_choose);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MyMessageBox.showBox("Delete import form successfully!", "Message");
                return true;

            }
            else
            {
                MyMessageBox.showBox("Some errors occured!", "Message");
                return false;
            }

        }


        public void addDetailImportForm()
        {

            string idForm = importGoodsView.id_IG.Trim();
            string statusDetail = importGoodsView.statusDetail.Trim();
            // string idDetail = importGoodsView.id_Detail_IG.Trim();
            string idProduct = importGoodsView.id_Product.Trim();
            string name = importGoodsView.name.Trim();
            string quantity = importGoodsView.quantity.Trim();

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DETAIL_GOODS_IMPORT_FORM (ID_GOODS_IMPORT_FORM, NAME, STATUS, QUANTITY, ID_PRODUCT) VALUES(@idIG, @name, @status, @quantity, @idProduct);", myConnection.sqlcon);

            cmd.Parameters.AddWithValue("@idIG", idForm);
            cmd.Parameters.AddWithValue("@status", statusDetail);
            cmd.Parameters.AddWithValue("@idProduct", idProduct);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@quantity", quantity);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {

            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            myConnection.sqlcon.Close();
        }



        public void dataGV_IGF(DataGridView dataGV, int role)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MImportGoods> list = new List<MImportGoods>();

            string querry;

            if (role == 0)
            {
                querry = "Select * from GOODS_IMPORT_FORM where ID_PERSON IS NOT NULL ;";
            }
            else
            {
                querry = "Select * from GOODS_IMPORT_FORM where ID_PERSON IS NOT NULL AND STATUS =0 ;";
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string ID = row["ID_GOODS_IMPORT_FORM"].ToString();
                    string ID_Person = row["ID_PERSON"].ToString();
                    string status = row["STATUS"].ToString();

                    DateTime date = Convert.ToDateTime(row["DATE_CRE"]);
                    string dateCre = date.ToString("dd-MM-yyyy");



                    MImportGoods importGoods = new MImportGoods(ID, ID_Person, status, dateCre);
                    list.Add(importGoods);

                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();

                row.Cells[1].Value = list[i].getID_P();
                row.Cells[2].Value = list[i].getDATE();

                int status = int.Parse(list[i].getSTATUS());

                if (status == 0)
                {
                    row.Cells[3].Value = false;
                }
                else
                {
                    row.Cells[3].Value = true;
                }




                dataGV.Rows.Add(row);


            }
            myConnection.sqlcon.Close();
        }


        public void dataGV_Detail(DataGridView dataGV, int id)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MDetailGoodsImport> list = new List<MDetailGoodsImport>();

            string querry = "Select * from DETAIL_GOODS_IMPORT_FORM where ID_GOODS_IMPORT_FORM =" + id + ";";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string ID_Detail = row["ID_DETAIL_GOODS_IMPORT_FORM"].ToString();
                    string ID_Goods = row["ID_GOODS_IMPORT_FORM"].ToString();
                    string name = row["NAME"].ToString();
                    string status = row["STATUS"].ToString();
                    string quantity = row["QUANTITY"].ToString(); ;
                    string ID_Product = row["ID_PRODUCT"].ToString(); ;


                    MDetailGoodsImport mDetailGoodsImport = new MDetailGoodsImport(ID_Detail, ID_Goods, name, status, quantity, ID_Product);
                    list.Add(mDetailGoodsImport);

                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getid_Detail();

                row.Cells[1].Value = list[i].getname();
                row.Cells[2].Value = list[i].getquantity();

                int status = int.Parse(list[i].getstatus());

                if (status == 0)
                {
                    row.Cells[3].Value = false;
                }
                else
                {
                    row.Cells[3].Value = true;
                }




                dataGV.Rows.Add(row);


            }
            myConnection.sqlcon.Close();
        }

        public int confirm(int idTemp, Guna.UI2.WinForms.Guna2DataGridView DtaGridView_Goods)
        {
            List<MDetailsGoodsImportBill> list_detailsImportBill = new List<MDetailsGoodsImportBill>();
            double bill_totalPrice = 0;
            bool sign = false;
            int id_bartender = 0;
            int id_goods_import_form = 0;
            bool isChecked = false;

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            for (int i = 0; i < DtaGridView_Goods.RowCount - 1; i++)
            {
                int id1 = Convert.ToInt32(DtaGridView_Goods.Rows[i].Cells["ID"].Value);

                SqlCommand cmd = new SqlCommand("Update DETAIL_GOODS_IMPORT_FORM set STATUS=@status where ID_DETAIL_GOODS_IMPORT_FORM=@idForm;", myConnection.sqlcon);

                if (Convert.ToBoolean(DtaGridView_Goods.Rows[i].Cells["STATUS"].Value) == true)
                {
                    cmd.Parameters.AddWithValue("@status", 1);
                    sign = true;
                    isChecked = true;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@status", 0);
                    sign = false;
                }
                cmd.Parameters.AddWithValue("@idForm", id1);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    if (sign == true)
                    {
                        string querry = "Select G.ID_GOODS, D.QUANTITY, G.PRICE, GI.ID_PERSON, GI.ID_GOODS_IMPORT_FORM from " +
                            "((DETAIL_GOODS_IMPORT_FORM D join PRODUCT P on D.ID_PRODUCT = P.ID_PRODUCT) join " +
                            "GOODS G on P.ID_GOODS = G.ID_GOODS) join " +
                            "GOODS_IMPORT_FORM GI on D.ID_GOODS_IMPORT_FORM = GI.ID_GOODS_IMPORT_FORM where D.ID_DETAIL_GOODS_IMPORT_FORM ='" + id1 + "'; ";
                        SqlCommand sqlCommand = new SqlCommand(querry, myConnection.sqlcon);
                        SqlDataReader dr = sqlCommand.ExecuteReader();
                        if (dr.Read())
                        {
                            int id_goods = Convert.ToInt32(dr["ID_GOODS"]);
                            int quantity = Convert.ToInt32(dr["QUANTITY"]);
                            double price = Convert.ToDouble(dr["PRICE"]);
                            double total_price = price * quantity;
                            id_bartender = Convert.ToInt32(dr["ID_PERSON"]);
                            id_goods_import_form = Convert.ToInt32(dr["ID_GOODS_IMPORT_FORM"]);
                            MDetailsGoodsImportBill details_GIB = new MDetailsGoodsImportBill(0, 0, id_goods, quantity, total_price);
                            list_detailsImportBill.Add(details_GIB);
                            dr.Close();
                        }
                    }
                }
                else return -1;

            }

            if (isChecked == false)
            {
                return 0;
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("Update GOODS_IMPORT_FORM set STATUS=1 where ID_GOODS_IMPORT_FORM=@id;", myConnection.sqlcon);
                cmd1.Parameters.AddWithValue("@id", idTemp);
                int result1 = cmd1.ExecuteNonQuery();
                if (result1 > 0)
                {

                    string date_create = DateTime.Now.ToString("yyyy-MM-dd");

                    for (int i = 0; i < list_detailsImportBill.Count(); i++)
                    {
                        bill_totalPrice += list_detailsImportBill[i].getTOTAL_PRICE();
                    }

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO GOODS_IMPORT_BILL (ID_BARTENDER, ID_ACCOUNTANT, ID_GOODS_IMPORT_FORM, TOTAL_PRICE, DATE_CRE, STATUS) VALUES(@id_bartender, @id_accountant, @id_goods_import_form, @total_price, @date_cre, @status);", myConnection.sqlcon);
                    cmd2.Parameters.AddWithValue("@id_bartender", id_bartender);
                    cmd2.Parameters.AddWithValue("@id_accountant", 4);
                    cmd2.Parameters.AddWithValue("@id_goods_import_form", id_goods_import_form);
                    cmd2.Parameters.AddWithValue("@total_price", bill_totalPrice);
                    cmd2.Parameters.AddWithValue("@date_cre", date_create);
                    cmd2.Parameters.AddWithValue("@status", 0);

                    int result2 = cmd2.ExecuteNonQuery();
                    if (result2 > 0)
                    {
                        string query3 = "Select MAX(ID_GOODS_IMPORT_BILL) as MAX from GOODS_IMPORT_BILL;";
                        SqlCommand cmd3 = new SqlCommand(query3, myConnection.sqlcon);
                        SqlDataReader dr = cmd3.ExecuteReader();
                        if (dr.Read())
                        {
                            int id_goods_import_bill = Convert.ToInt32(dr["MAX"]);
                            dr.Close();
                            for (int i = 0; i < list_detailsImportBill.Count(); i++)
                            {
                                list_detailsImportBill[i].setID_GOODS_IMPORT_BILL(id_goods_import_bill);
                                SqlCommand cmd4 = new SqlCommand("INSERT INTO DETAILS_GOODS_IMPORT_BILL (ID_GOODS_IMPORT_BILL, ID_GOODS, QUANTITY, TOTAL_PRICE) " +
                                    "VALUES(@id_gib, @id_goods, @quantity, @total_price);", myConnection.sqlcon);
                                cmd4.Parameters.AddWithValue("@id_gib", list_detailsImportBill[i].getID_GOODS_IMPORT_BILL());
                                cmd4.Parameters.AddWithValue("@id_goods", list_detailsImportBill[i].getID_GOODS());
                                cmd4.Parameters.AddWithValue("@quantity", list_detailsImportBill[i].getQUANTITY());
                                cmd4.Parameters.AddWithValue("@total_price", list_detailsImportBill[i].getTOTAL_PRICE());

                                int result4 = cmd4.ExecuteNonQuery();
                                if (result4 > 0)
                                {
                                    return 1;
                                }
                                else return -1;

                            }
                        }
                    }
                    else return -1;
                }
                else return -1;
                return -1;
            }

            myConnection.sqlcon.Close();
        }
    }

}
