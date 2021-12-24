using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
        List<Person> waiters = new List<Person>();

        //them total quantity vao day ( total quantity cua OF)
        public void updateTotalOrderForm(int id, int total_price, int total_quantity)
        {
            this.id_order_form = id;
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update ORDERFORM set TOTAL_PRICE=@total_price,TOTAL_QUANTITY = @quantity Where ID_ORDERFORM like'" + id + "%';",
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@total_price", total_price);
            cmd.Parameters.AddWithValue("@quantity", total_quantity);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
               
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

            SqlCommand cmd3 = new SqlCommand("Delete from ORDERFORM where ID_ORDERFORM=@id_order;", myConnection.sqlcon);
            cmd3.Parameters.AddWithValue("@id_order", id_order);
            cmd3.ExecuteNonQuery();

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

        public bool getItemOrderForm(String id_order)
        {
            bool check = false;
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Select * from DETAILS_ORDERFORM where ID_ORDERFORM=@id_orderform",
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_orderform", id_order);

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
               check = true;
            }
            myConnection.sqlcon.Close();
            return check;

            
        }

        public string getNameOfWaiter(int id_waiter)
        {
            string name = "";
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Select * from PERSON where ID_PERSON=@id_person",
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_person", id_waiter);

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                name = sdr["NAME"].ToString();
            }
            myConnection.sqlcon.Close();
            return name;

            
        }

        public void updateStatusDetailOrderForm(int id_order)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string query = "Select * from DETAILS_ORDERFORM  where ID_ORDERFORM=@id_orderform ;";

            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_orderform", id_order);

            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {



                SqlCommand cmd1 = new SqlCommand("Update DETAILS_ORDERFORM set STATUSb=@status where ID_ORDERFORM=@id_orderform",
                myConnection.sqlcon);
                cmd1.Parameters.AddWithValue("@status", "1");
                cmd1.Parameters.AddWithValue("@id_orderform", id_order);
                cmd1.ExecuteNonQuery();




            }
            sdr.Close();
            myConnection.sqlcon.Close();
        }

        public void showOrderForm(DataGridView dt)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderForm> orderlist = new List<MOrderForm>();
            dt.Rows.Clear();

            waiters = new List<Person>();
            string query5 = "Select * from PERSON where ROLE = 1";
            SqlCommand cmd5 = new SqlCommand(query5, myConnection.sqlcon);
            SqlDataReader sdr5 = cmd5.ExecuteReader();
            while (sdr5.Read())
            {
                int id = (int)sdr5["ID_PERSON"];
                string name = sdr5["NAME"].ToString();

                Person person = new Person(id, "", "", name, "", "", "", "", 0);
                waiters.Add(person);
            }
            sdr5.Close();

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
                for (int j = 0; j < waiters.Count(); j++)
                {
                    if(waiters[j].getID() == orderlist[i].getID_PERSON()) row.Cells[1].Value = waiters[j].getNAME();
                }
     
                row.Cells[2].Value = orderlist[i].getTOTAL_PRICE().ToString("###,###,##0");

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

       

        public int[] a;
        //V1
     

        public void getOrderFormList(int d, int m, int y)
        {
            a = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0 };

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
                    
            if (d != 0 && m != 0 && y != 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    string querryD = "SELECT SUM(QUANTITY) AS TOTAL from DETAILS_ORDERFORM where STATUSb = 1 and KIND ="+i+" and DAY(DATEb) = " + d.ToString() + "and MONTH(DATEb) =" + m.ToString() + "and YEAR(DATEb) =" + y.ToString() + ";";
                    SqlCommand sqlCommand = new SqlCommand(querryD, myConnection.sqlcon);
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.IsDBNull(0) == true)
                        {
                            a[i] = 0;
                            Console.WriteLine(a[0].ToString());
                        }
                        else
                        {
                            a[i] = Convert.ToInt32(dr[0].ToString());
                            Console.WriteLine(a[0].ToString());
                        }

                    }
                    dr.Close();
                }

            }
            else if (d == 0 && m != 0 && y != 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    string querryD = "SELECT SUM(QUANTITY) AS TOTAL from DETAILS_ORDERFORM where STATUSb = 1 and KIND =" + i + "and MONTH(DATEb) =" + m.ToString() + "and YEAR(DATEb) =" + y.ToString() + ";";
                    SqlCommand sqlCommand = new SqlCommand(querryD, myConnection.sqlcon);
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.IsDBNull(0) == true)
                        {
                            a[i] = 0;
                           
                        }
                        else
                        {
                            a[i] = Convert.ToInt32(dr[0].ToString());
                           
                        }

                    }
                    dr.Close();
                }

            }else if (d == 0 && m == 0 && y != 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    string querryD = "SELECT SUM(QUANTITY) AS TOTAL from DETAILS_ORDERFORM where STATUSb = 1 and KIND =" + i + "and YEAR(DATEb) =" + y.ToString() + ";";
                    SqlCommand sqlCommand = new SqlCommand(querryD, myConnection.sqlcon);
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.IsDBNull(0) == true)
                        {
                            a[i] = 0;

                        }
                        else
                        {
                            a[i] = Convert.ToInt32(dr[0].ToString());

                        }

                    }
                    dr.Close();
                }

            }
            myConnection.sqlcon.Close();

        }

        public void searchData(Guna.UI2.WinForms.Guna2DataGridView dtGridView_OrderForm, string search)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderForm> orderlist = new List<MOrderForm>();
            dtGridView_OrderForm.Rows.Clear();

            string querry = "Select O.ID_ORDERFORM, O.ID_WAITER, O.STATUS, O.TOTAL_PRICE, P.NAME " +
                "from ORDERFORM O join PERSON P on O.ID_WAITER = P.ID_PERSON " +
                "where (ID_ORDERFORM like '" + search + "%' and STATUS = 0 and TOTAL_PRICE != 0) or (P.NAME like '" + search + "%' and STATUS = 0 and TOTAL_PRICE != 0);";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_ORDERFORM"]);
                    int ID_WAITER = Convert.ToInt32(row["ID_WAITER"]);
                    int STATUS = Convert.ToInt32(row["STATUS"]);
                    int TOTAL_PRICE = Convert.ToInt32(row["TOTAL_PRICE"]);

                    MOrderForm i = new MOrderForm(ID, ID_WAITER, STATUS, TOTAL_PRICE);
                    orderlist.Add(i);
                }
            }

            for (int i = 0; i < orderlist.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dtGridView_OrderForm.Rows[i].Clone();
                row.Cells[0].Value = orderlist[i].getID();
                for (int j = 0; j < waiters.Count(); j++)
                {
                    if (waiters[j].getID() == orderlist[i].getID_PERSON()) row.Cells[1].Value = waiters[j].getNAME();
                }

                row.Cells[2].Value = orderlist[i].getTOTAL_PRICE().ToString("###,###,##0");

                dtGridView_OrderForm.Rows.Add(row);

            }

            myConnection.sqlcon.Close();

        }
    }
}
