using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using System;
using Beverage_Management_System.View;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System.Presenters
{
    class GoodAgencyPresenter
    {

        IGoodsAgency goodsAgencyView;
        IAddGoodsAgency addGoodsAgencyView;
        int id = -1;
        int id_selected_goods = 0;

        public Agency Owner { get; private set; }

        public GoodAgencyPresenter(IAddGoodsAgency view, int ID)
        {
            addGoodsAgencyView = view;
            id = ID;
        }

        public GoodAgencyPresenter(IAddGoodsAgency view, int ID, int ID1)
        {
            addGoodsAgencyView = view;
            id = ID;
            id_selected_goods = ID1;
        }

        public GoodAgencyPresenter(IGoodsAgency view)
        {
            goodsAgencyView = view;
        }

        public void setInformation(Guna.UI2.WinForms.Guna2TextBox txt_Name_Good, Guna.UI2.WinForms.Guna2TextBox txt_Price_Good,
            Guna.UI2.WinForms.Guna2TextBox txt_Unit_Good, Guna.UI2.WinForms.Guna2TextBox txt_Quantity_Good)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            string querry = "Select * from GOODS where ID_GOODS = '" + id_selected_goods + "';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    txt_Name_Good.Text = row["NAME"].ToString();
                    txt_Price_Good.Text = row["PRICE"].ToString();
                    txt_Unit_Good.Text = row["UNIT"].ToString();
                    txt_Quantity_Good.Text = row["QUANTITY"].ToString();

                }

            }
            myConnection.sqlcon.Close();
        }

       

        public void dataGVGood(DataGridView dataGV, int id)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MGoodsAgency> list = new List<MGoodsAgency>();

            string querry = "Select * from GOODS where ID_SUPPLIER =" + id + ";";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_GOODS"]);
                    string NAME = row["NAME"].ToString();
                    string PHONE = row["PRICE"].ToString();
                    string ADDRESS = row["UNIT"].ToString();
                    string ITEM = row["QUANTITY"].ToString();

                    MGoodsAgency good = new MGoodsAgency(ID, NAME, PHONE, ADDRESS, ITEM);
                    list.Add(good);

                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();

                row.Cells[1].Value = list[i].getNAME();
                int price =  int.Parse(list[i].getPRICE());

              
               
                row.Cells[2].Value = price.ToString("###,###,##0");

                row.Cells[3].Value = list[i].getUNIT();

                row.Cells[4].Value = list[i].getQUANTITY();
                dataGV.Rows.Add(row);

            }
            myConnection.sqlcon.Close();
        }


        public void addGoodAgency(AddGoodAgency form, int id, int selected_goods)
        {
            string name = addGoodsAgencyView.name.Trim();
            string price = addGoodsAgencyView.price.Trim();
            string unit = addGoodsAgencyView.unit.Trim();
            string quantity = addGoodsAgencyView.quantity.Trim();

            int idSupplier = id;
            id_selected_goods = selected_goods;

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            if(id_selected_goods == 0)
            {
                SqlCommand cmd = new SqlCommand("Insert into GOODS(NAME,PRICE,UNIT,QUANTITY,ID_SUPPLIER) " +
               "values (@name,@price,@unit,@quantity, @id);",
               myConnection.sqlcon);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@id", idSupplier);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MyMessageBox.showBox("Add goods's information successfully!", "Message");
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }

            else
            {
                SqlCommand cmd = new SqlCommand("Update GOODS set NAME=@name, PRICE=@price, UNIT=@unit, QUANTITY=@quantity where ID_GOODS=@id;",
                   myConnection.sqlcon);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@id", id_selected_goods);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MyMessageBox.showBox("Update goods's information successfully!", "Message");

                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
           
            myConnection.sqlcon.Close();


        }
        public int deleteGoodAgency(int id)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            bool sign = false;
            int iCount = 0;

            SqlCommand cmd1 = new SqlCommand("SELECT P.ID_PRODUCT FROM (PRODUCT P JOIN GOODS G ON P.ID_GOODS = G.ID_GOODS) WHERE " +
                "(G.ID_GOODS = '" + id + "' AND P.ID_PRODUCT IN (SELECT ID_PRODUCT FROM DETAIL_GOODS_IMPORT_FORM)) OR " +
                "(G.ID_GOODS = '" + id + "' AND G.ID_GOODS IN (SELECT ID_GOODS FROM DETAILS_GOODS_IMPORT_BILL)) OR" +
                "(G.ID_GOODS = '" + id + "' AND P.ID_PRODUCT IN (SELECT ID_PRODUCT FROM DETAILS_ORDERFORM))", myConnection.sqlcon);
            object oCount = cmd1.ExecuteScalar();
            if (oCount != null) sign = true;
            else sign = false;

            if (sign == true)
            {
                myConnection.sqlcon.Close();
                return 0;
            }
            else
            {
                SqlCommand cmd22 = new SqlCommand("Delete from PRODUCT where ID_GOODS in (SELECT ID_GOODS FROM GOODS where ID_GOODS=@id);", myConnection.sqlcon);
                cmd22.Parameters.AddWithValue("@id", id);
                cmd22.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("Delete from GOODS where ID_GOODS=@id;", myConnection.sqlcon);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    myConnection.sqlcon.Close();
                    return 1;
                }
                else
                {
                    myConnection.sqlcon.Close();
                    return -1;
                }
            }

        }
        public void searchData(Guna.UI2.WinForms.Guna2DataGridView dtGridView_Good, int id)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MGoodsAgency> list = new List<MGoodsAgency>();
            dtGridView_Good.Rows.Clear();

            string querry = "Select * from GOODS where (ID_SUPPLIER = " + id + ")and (NAME like '" + goodsAgencyView.search + "%' or ID_GOODS like '" + goodsAgencyView.search + "%');";

            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_GOODS"]);
                    string NAME = row["NAME"].ToString();
                    string PHONE = row["PRICE"].ToString();
                    string ADDRESS = row["UNIT"].ToString();
                    string ITEM = row["QUANTITY"].ToString();

                    MGoodsAgency good = new MGoodsAgency(ID, NAME, PHONE, ADDRESS, ITEM);
                    list.Add(good);

                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
             
                DataGridViewRow row = (DataGridViewRow)dtGridView_Good.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();

                row.Cells[1].Value = list[i].getNAME();

                row.Cells[2].Value = list[i].getPRICE();
                row.Cells[3].Value = list[i].getUNIT();

                row.Cells[4].Value = list[i].getQUANTITY();
                dtGridView_Good.Rows.Add(row);

            }

            myConnection.sqlcon.Close();

        }

        public void openAddGoodsForm(int id_supplier, GoodAgency parent, int id_choosed)
        {

            AddGoodAgency form = new AddGoodAgency(id_supplier, parent, id_choosed);
            form.Show();
        }
    }
}
