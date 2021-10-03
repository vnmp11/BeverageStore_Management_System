using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System.Presenters
{
    class OrderFormPresenter
    {
        public void addOrderForm(int id, int total_price)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update ORDERFORM set TOTAL_PRICE=@total_price Where ID_ORDERFORM like'" + id + "%';",
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@total_price", total_price);
            cmd.ExecuteNonQuery();
        }

        public void showOrderForm(DataGridView dt)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderForm> orderlist = new List<MOrderForm>();
            dt.Rows.Clear();

            string query = "Select * from ORDERFORM ;";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id = (int)sdr["ID_ORDERFORM"];
                int id_person = (int)sdr["ID_PERSON"];
                int total_price = (int)sdr["TOTAL_PRICE"];
                int status = (int)sdr["STATUS"];

                MOrderForm i = new MOrderForm(id, id_person, status, total_price);
                orderlist.Add(i);
            }

            myConnection.sqlcon.Close();

            for (int i = 0; i < orderlist.Count() - 1; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dt.Rows[i].Clone();
                row.Cells[0].Value = orderlist[i].getID();
                row.Cells[1].Value = orderlist[i].getID_PERSON();
                row.Cells[2].Value = orderlist[i].getTOTAL_PRICE().ToString("###,###,##0");
                row.Cells[3].Value = orderlist[i].getSTATUS();

                dt.Rows.Add(row);
            }
        }

        public void showDetailOrderForm(FlowLayoutPanel pl, int id_order)
        {

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            pl.Controls.Clear();

            string query = "Select * from DETAILS_ORDERFORM where ID_ORDERFORM like '" + id_order + "%';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id_product = (int)sdr["ID_PRODUCT"];
                int quantity = (int)sdr["QUANTITY"];
                int total_price = (int)sdr["TOTAL_PRICE"];

                MyConnection myConnection2 = new MyConnection();
                myConnection2.sqlcon.Open();

                string query1 = "Select * from PRODUCT where ID_PRODUCT like '" + id_product.ToString() + "%';";
                SqlCommand cmd2 = new SqlCommand(query1, myConnection2.sqlcon);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                sdr2.Read();

                String name_product = (String)sdr2["NAME"];
                int price = (int)sdr2["PRICE"];
                byte[] image_product = (byte[])sdr2["IMAGE"];

                Image x = (Bitmap)((new ImageConverter()).ConvertFrom(image_product));

                Item i = new Item();
                i.LabelName = name_product;
                i.LabelPrice = price.ToString("###,###,##0");
                i.LabelQuantity = quantity.ToString();
                i.LabelTotal_Price = total_price.ToString("###,###,##0");
                i.PbItem = x;

                pl.Controls.Add(i);
            }
        }
    }
}
