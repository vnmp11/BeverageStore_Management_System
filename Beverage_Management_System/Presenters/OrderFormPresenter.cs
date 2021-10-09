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
        int id_tracking_note = 0;
        int id_order_form = 0;
        public void updateTotalOrderForm(int id, int total_price)
        {
            this.id_order_form = id;
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update ORDERFORM set TOTAL_PRICE=@total_price Where ID_ORDERFORM like'" + id + "%';",
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@total_price", total_price);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                string date_confirm = DateTime.Now.ToString("yyyy-MM-dd");
                SqlCommand cmd1 = new SqlCommand("Insert into TRACKING_NOTE(KIND, DATE_CON, ID_BILL) values (@kind, @date_con, @id_bill);", myConnection.sqlcon);
                cmd1.Parameters.AddWithValue("@kind", 1);
                cmd1.Parameters.AddWithValue("@date_con", date_confirm);
                cmd1.Parameters.AddWithValue("@id_bill", id);
                int result1 = cmd1.ExecuteNonQuery();
                if(result1 > 0) {
                    string query2 = "Select MAX(ID_TRACKING_NOTE) as MAX from TRACKING_NOTE;";
                    SqlCommand cmd2 = new SqlCommand(query2, myConnection.sqlcon);
                    SqlDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        this.id_tracking_note = Convert.ToInt32(dr["MAX"]);
                        dr.Close();
                    }
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            myConnection.sqlcon.Close();

        }

        public int getID_TRACKING_NOTE() { return this.id_tracking_note; }
        public int getID_ORDER_FORM() { return this.id_order_form; }

        public void deleteOrderForm(int id_order)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string query = "Select ID_TRACKING_NOTE from TRACKING_NOTE where KIND ='" + 1 + "' and ID_BILL ='" + id_order + "';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.Read())
            {
                int id_tracking_note = Convert.ToInt32(sdr["ID_TRACKING_NOTE"]);
                sdr.Close();
                SqlCommand cmd1 = new SqlCommand("Delete from DETAILS_TRACKING_NOTE where ID_TRACKING_NOTE='" + id_tracking_note + "';", myConnection.sqlcon);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("Delete from TRACKING_NOTE where ID_TRACKING_NOTE='" + id_tracking_note + "';", myConnection.sqlcon);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("Delete from ORDERFORM where ID_ORDERFORM=@id_order;", myConnection.sqlcon);
                cmd3.Parameters.AddWithValue("@id_order", id_order);
                cmd3.ExecuteNonQuery();


            }

            myConnection.sqlcon.Close();
        }

        public void updateStatusOrderForm(int id_order)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update ORDERFORM set STATUS=@status where ID_ORDERFORM=@id_orderform",
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@status", "1");
            cmd.Parameters.AddWithValue("@id_orderform", id_order);
            cmd.ExecuteNonQuery();

            myConnection.sqlcon.Close();
        }

        public void showOrderForm(DataGridView dt)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderForm> orderlist = new List<MOrderForm>();
            dt.Rows.Clear();

            string query = "Select * from ORDERFORM Where STATUS=@status";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@status", "0");
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id = (int)sdr["ID_ORDERFORM"];
                int id_person = (int)sdr["ID_WAITER"];
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
            myConnection.sqlcon.Close();
        }

        public void addDetailsTrackingNote(int id_order_form, int id_tracking_note)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MProduct> list = new List<MProduct> ();

            string query = "Select D.ID_PRODUCT, D.QUANTITY, P.NAME from DETAILS_ORDERFORM D join PRODUCT P on D.ID_PRODUCT = P.ID_PRODUCT where ID_ORDERFORM ='" + id_order_form + "';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id_product = Convert.ToInt32(sdr["ID_PRODUCT"]);
                int quantity = Convert.ToInt32(sdr["QUANTITY"]);
                string name = sdr["NAME"].ToString();

                MProduct product = new MProduct(id_product, 0, 0, name, 0, "", quantity, null);
                list.Add(product);
            }
            sdr.Close();

            for(int i = 0; i < list.Count(); i++)
            {
                SqlCommand cmd1 = new SqlCommand("Insert into DETAILS_TRACKING_NOTE(ID_PRODUCT,ID_TRACKING_NOTE, NAME, QUANTITY) values (@id_product,@id_tracking_note,@name,@quantity);",
                    myConnection.sqlcon);
                cmd1.Parameters.AddWithValue("@id_product", list[i].getID());
                cmd1.Parameters.AddWithValue("@id_tracking_note", id_tracking_note);
                cmd1.Parameters.AddWithValue("@name", list[i].getNAME());
                cmd1.Parameters.AddWithValue("@quantity", list[i].getQUANTITY());

                cmd1.ExecuteNonQuery();
            }
        }
    }
}
