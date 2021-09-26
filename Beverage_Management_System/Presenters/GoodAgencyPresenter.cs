﻿using Beverage_Management_System.Connection;
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

        public Agency Owner { get; private set; }

        public GoodAgencyPresenter(IAddGoodsAgency view, int ID)
        {
            addGoodsAgencyView = view;
            id = ID;
        }

        public GoodAgencyPresenter(IGoodsAgency view)
        {
            goodsAgencyView = view;
        }

        public void openAddGoodForm(int id_choosed, Form parent)
        {

            AddGoodAgency form = new AddGoodAgency(id_choosed);
            form.Owner = parent;
            form.Show();
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

                row.Cells[2].Value = list[i].getPRICE();
                row.Cells[3].Value = list[i].getUNIT();

                row.Cells[4].Value = list[i].getQUANTITY();
                dataGV.Rows.Add(row);

            }
            myConnection.sqlcon.Close();
        }


        public void addGoodAgency(AddGoodAgency form, int id)
        {
            string name = addGoodsAgencyView.name.Trim();
            string price = addGoodsAgencyView.price.Trim();
            string unit = addGoodsAgencyView.unit.Trim();
            string quantity = addGoodsAgencyView.quantity.Trim();
            int idSupplier = id;

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
           
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
                // form.refeshFrom();
                //Agency fA = (Agency)this.Owner;
                //fA.reloadTable();
                MyMessageBox.showBox("Add goods's information successfully!", "Message");
            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");

            // }


        }

        public int deleteGoodAgency(int id)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Delete from GOODS where ID_GOODS=@id;", myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return 1;
            }
            else return 0;
        }

    }
}