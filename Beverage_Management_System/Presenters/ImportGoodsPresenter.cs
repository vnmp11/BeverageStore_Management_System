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
        public void setDataGV()
        {
            importGoodsView.setDataGV_Fill_ImportGoods();
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

            SqlCommand cmd= new SqlCommand("Update GOODS_IMPORT_FORM set ID_PERSON=@id, DATE_CRE=@date where ID_GOODS_IMPORT_FORM=@idForm;", myConnection.sqlcon);

            
            aDateTime = DateTime.Now.ToString();
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
            SqlCommand cmd = new SqlCommand("INSERT INTO GOODS_IMPORT_FORM ( STATUS) VALUES('0');" ,myConnection.sqlcon);




           // cmd.Parameters.AddWithValue("@idIG", idForm);
            
           
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MyMessageBox.showBox("Add successfully!", "Message");
            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
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
            SqlCommand cmd = new SqlCommand("INSERT INTO DETAIL_GOODS_IMPORT_FORM (ID_GOODS_IMPORT_FORM, STATUS, ID_PRODUCT, NAME, QUANTITY) VALUES(@idIG, @status, @idProduct, @name, @quantity);", myConnection.sqlcon);




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
        }



        public void dataGV_IGF(DataGridView dataGV, int role)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MImportGoods> list = new List<MImportGoods>();

            string querry;
            
            if(role == 0)
            {
                querry ="Select * from GOODS_IMPORT_FORM where ID_PERSON IS NOT NULL ;";
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
                   
                   

                    MImportGoods importGoods = new MImportGoods(ID,ID_Person, status,dateCre);
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
        //check role master or bar
        public void openGoodsDetailFormBAR(int id_choosed)
        {
            GoodsInImportForm form = new GoodsInImportForm(id_choosed);
            form.Show();
        }
        public void openGoodsDetailFormMaster(int id_choosed)
        {
            GoodsInImportForm form = new GoodsInImportForm(id_choosed, 0);
            form.Show();
        }

        public void dataGV_Detail(DataGridView dataGV, int id)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MDetailGoodsImport> list = new List<MDetailGoodsImport>();

            string querry = "Select * from DETAIL_GOODS_IMPORT_FORM where ID_GOODS_IMPORT_FORM =" +id+ ";";
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
                    string quantity= row["QUANTITY"].ToString(); ;
                    string ID_Product= row["ID_PRODUCT"].ToString(); ;


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
    }

}
