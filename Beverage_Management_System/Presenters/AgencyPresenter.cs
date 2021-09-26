using System;
using System.Collections.Generic;
using System.Linq;
using Beverage_Management_System.View;
using Beverage_Management_System.Model;
using Beverage_Management_System.Connection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Beverage_Management_System.Presenters
{
    class AgencyPresenter
    {
        IAddAgency addAgencyView;
        IAgency agencyView;
        int id = -1;

        //public Agency Owner { get; private set; }

        public AgencyPresenter(IAgency view)
        {
            agencyView = view;
        }
        public AgencyPresenter(IAddAgency view, int ID)
        {
            addAgencyView = view;
            id = ID;
        }

       

        public void dataGV(DataGridView dataGV)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MAgency> list = new List<MAgency>();

            string querry = "Select * from SUPPLIER;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_SUPPLIER"]);
                    string NAME = row["NAME"].ToString();
                    string PHONE = row["PHONE"].ToString();
                    string ADDRESS = row["ADDRESS"].ToString();
                    string ITEM = row["ITEM"].ToString();

                    MAgency agency = new MAgency(ID, NAME, PHONE, ADDRESS, ITEM);
                    list.Add(agency);

                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();

                row.Cells[1].Value = list[i].getNAME();

                row.Cells[2].Value = list[i].getPHONE();
                row.Cells[3].Value = list[i].getADDRESS();

                row.Cells[4].Value = list[i].getITEM();
                dataGV.Rows.Add(row);

            }
            myConnection.sqlcon.Close();
        }

        ///////ADD
        ///
        public void addSupplier(AddAgency form)
        {
            string name = addAgencyView.name.Trim();
            string phone = addAgencyView.phone.Trim();
            string address = addAgencyView.address.Trim();
            string item = addAgencyView.item.Trim();

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand("Update SUPPLIER set NAME=@name, ADDRESS=@address,PHONE=@phone, ITEM = @item where ID_SUPPLIER=@id;",
                    myConnection.sqlcon);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@item", item);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MyMessageBox.showBox("Update supplier's information successfully!", "Message");

                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into SUPPLIER(NAME,ADDRESS,PHONE,ITEM) " +
                    "values (@name,@address,@phone,@item);",
                    myConnection.sqlcon);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@item", item);


                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    //form.refeshFrom();
                    //Agency fA = (Agency)this.Owner;
                    //fA.reloadTable();
                    MyMessageBox.showBox("Add supplier's information successfully!", "Message");
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");

            }
        }


        public void openGoodAgencyForm(int id_choosed)
        {
            GoodAgency form = new GoodAgency(id_choosed);
            form.Show();
        }
        public void openAddAgencyForm(int id_choosed)
        {

            AddAgency form = new AddAgency(id_choosed);

            form.Show();
        }

        public int deleteAgency(int id)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Delete from SUPPLIER where ID_SUPPLIER=@id;", myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return 1;
            }
            else return 0;
        }


        public void setInforAgency (Guna.UI2.WinForms.Guna2TextBox txt_id, int txt_ID, Guna.UI2.WinForms.Guna2TextBox txt_Name, Guna.UI2.WinForms.Guna2TextBox txt_Address,
           Guna.UI2.WinForms.Guna2TextBox txt_Phone, Guna.UI2.WinForms.Guna2TextBox txt_Item)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            string querry = "Select * from SUPPLIER where ID_SUPPLIER = '" + txt_ID + "';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                  //  id =  row["ID_SUPPLIER"].ToString();
                    
                    txt_Name.Text = row["NAME"].ToString();
                    txt_id.Text = row["ID_SUPPLIER"].ToString();

                    txt_Phone.Text = row["PHONE"].ToString();
                    txt_Address.Text = row["ADDRESS"].ToString();

                    txt_Item.Text = row["ITEM"].ToString();
                }

            }
            myConnection.sqlcon.Close();
        }

        public void UpdateSupllier(AddAgency form, int idSup)
        {
            string name = addAgencyView.name.Trim();
            string phone = addAgencyView.phone.Trim();
            string address = addAgencyView.address.Trim();
            string item = addAgencyView.item.Trim();

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
           
                SqlCommand cmd = new SqlCommand("Update SUPPLIER set NAME=@name, ADDRESS=@address,PHONE=@phone, ITEM = @item where ID_SUPPLIER=@id;",
                    myConnection.sqlcon);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@item", item);
                cmd.Parameters.AddWithValue("@id", idSup);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MyMessageBox.showBox("Update supplier's information successfully!", "Message");

                }
            
        }

    }
}
