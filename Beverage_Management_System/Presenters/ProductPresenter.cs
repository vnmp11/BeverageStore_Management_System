using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
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
    class ProductPresenter
    {
        public string show_id()
        {
            String query1 = "Select Max(ID_ORDERFORM) from ORDERFORM;";

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand(query1, myConnection.sqlcon);
            int id_order = (int)cmd.ExecuteScalar();

            myConnection.sqlcon.Close();
            return id_order.ToString();

        }

        public bool checkItem(int id, string id_order)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Select * from DETAILS_ORDERFORM where ID_PRODUCT like '" + id + "%' and ID_ORDERFORM like '" + id_order + "%';",
                   myConnection.sqlcon);
            SqlDataReader reader = cmd.ExecuteReader(); 

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

            myConnection.sqlcon.Close();
        }
        //add kind vo day
        public void addItem(int id, String id_orderform, int quantity)
        {
            updateQuantity(id, quantity);

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            if (checkItem(id, id_orderform))
            {
                int qty = getQuantity(id, id_orderform);
                MessageBox.Show("qty hiện tại: "+ qty.ToString());


                SqlCommand cmd = new SqlCommand("Update DETAILS_ORDERFORM set QUANTITY=@quantity, TOTAL_PRICE=@total_price where ID_PRODUCT like '"+ id + "';",
                    myConnection.sqlcon);
                cmd.Parameters.AddWithValue("@quantity", qty+quantity);
                cmd.Parameters.AddWithValue("@total_price", (qty + quantity)*getPrice(id));
                cmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("vao else");

                string date_create = DateTime.Now.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand("Insert into DETAILS_ORDERFORM( ID_PRODUCT, ID_ORDERFORM,QUANTITY,TOTAL_PRICE, STATUSb,KIND) " +
                    "values (@id_product,@id_orderform,@quantity, @total_price, @status, @kind );",
                    myConnection.sqlcon);

                SqlCommand cmd1  = new SqlCommand("Select * from PRODUCT where ID_PRODUCT like '" + id + "%' ;",
                   myConnection.sqlcon);
                SqlDataReader sdr = cmd1.ExecuteReader();
                int temp = 0;
                if (sdr.Read())
                {
                    Console.WriteLine(id.ToString());
                    int kind = Convert.ToInt32(sdr["ID_KIND"]);
                    temp = kind;
                    sdr.Close();
                }
                
                cmd.Parameters.AddWithValue("@id_product", id);
                cmd.Parameters.AddWithValue("@id_orderform", id_orderform);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@total_price", getPrice(id) * quantity);
                cmd.Parameters.AddWithValue("@status", 0);
                //XLy
                cmd.Parameters.AddWithValue("@kind", temp);
                
             

                cmd.ExecuteNonQuery();
            }

            myConnection.sqlcon.Close();
        }

        public void removeItem(int id, int id_order)
        {
            updateInStock(id, getQuantity(id, id_order.ToString()));

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Delete from DETAILS_ORDERFORM where ID_PRODUCT=@id and ID_ORDERFORM=@id_order;", myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_order", id_order);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
          
            myConnection.sqlcon.Close();
        }

        public void removeAll(int id_order)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select ID_PRODUCT from DETAILS_ORDERFORM where ID_ORDERFORM like '" + id_order + "%'; ", myConnection.sqlcon);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_PRODUCT"]);
                    removeItem(ID, id_order);
                }
            }

            myConnection.sqlcon.Close();
        }

          
        void updateQuantity(int id_product, int qty_buy)
        {
            int qty = getIn_Stock(id_product);

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update PRODUCT set QUANTITY=@quantity Where ID_PRODUCT like'" + id_product + "%';" ,
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@quantity", qty-qty_buy);
            cmd.ExecuteNonQuery();

            myConnection.sqlcon.Close();
        }
        void updateInStock(int id_product, int qty_buy)
        {
            int qty = getIn_Stock(id_product);

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update PRODUCT set QUANTITY=@quantity Where ID_PRODUCT like'" + id_product + "%';",
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@quantity", qty + qty_buy);
            cmd.ExecuteNonQuery();

            myConnection.sqlcon.Close();
        }

        public int getIn_Stock(int id_product)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Select * from PRODUCT where ID_PRODUCT like '" + id_product + "';",
                   myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            int quantity = (int)sdr["QUANTITY"];

            myConnection.sqlcon.Close();

            return quantity;

        }

        int getPrice(int id_product)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Select * from PRODUCT where ID_PRODUCT like '" + id_product + "';",
                   myConnection.sqlcon);

            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            int price = (int)sdr["PRICE"];

            myConnection.sqlcon.Close();

            return price;
        }

        public int getQuantity(int id_product, String id_orderform)
        {

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Select * from DETAILS_ORDERFORM where ID_PRODUCT=@id and ID_ORDERFORM=@id_order;",
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id", id_product);
            cmd.Parameters.AddWithValue("@id_order", id_orderform);

            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            int quantity = (int)sdr["QUANTITY"];

            myConnection.sqlcon.Close();

            return quantity;

        }
        //add them thuoc tinh moi total quantity
        public void addOrderForm(int id_person)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Insert into ORDERFORM(ID_WAITER, TOTAL_PRICE, STATUS) " +
                "values (@id_waiter,@total_price,@status);",
                myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_waiter", id_person);
            cmd.Parameters.AddWithValue("@total_price", "0");
            cmd.Parameters.AddWithValue("@status", "0");

            int result = cmd.ExecuteNonQuery();

            myConnection.sqlcon.Close();
        }

        public void showItemOrder( String idOrder, FlowLayoutPanel pl)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MItem> item = new List<MItem>();
            List<DetailOrder> listitem = new List<DetailOrder>();

            string query = "Select * from DETAILS_ORDERFORM where ID_ORDERFORM like '" +idOrder + "%';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id_product = (int)sdr["ID_PRODUCT"];
                int quantity = (int)sdr["QUANTITY"];
                int price_product = (int)sdr["TOTAL_PRICE"];
                

                MyConnection myConnection2 = new MyConnection();
                myConnection2.sqlcon.Open();

                //getkind ơ day
                string query1 = "Select * from PRODUCT where ID_PRODUCT like '" + id_product.ToString() + "%';";
                SqlCommand cmd2 = new SqlCommand(query1, myConnection2.sqlcon);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                sdr2.Read();

                String name_product = (String)sdr2["NAME"];
                int kind = (int)sdr2["ID_KIND"];
                int in_stock = (int)sdr2["QUANTITY"];
                int price = (int)sdr2["PRICE"];

                DetailOrder it = new DetailOrder();
                it.LabelName = name_product;
                it.id = id_product;

                //them kind
                it.id_order = int.Parse(idOrder);
                it.kind = kind;
                it.LabelPrice = price.ToString("###,###,##0");
                it.NumberRicQuantity = quantity.ToString("###,###,##0");
                it.LabelTotal_Price = price_product.ToString("###,###,##0");
                it.LabelIn_Stock = in_stock.ToString();

                listitem.Add(it);

            }

            myConnection.sqlcon.Close();

            pl.Controls.Clear();
            for (int i = 0; i < listitem.Count(); i++)
            {
                pl.Controls.Add(listitem[i]);
            }
        }
        public List<DetailOrder> listitemPrint = new List<DetailOrder>();
        public void printMenu(String idOrder)
        {
            listitemPrint.Clear();

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            //List<MItem> item = new List<MItem>();
            //List<DetailOrder> listitem = new List<DetailOrder>();

            string query = "Select * from DETAILS_ORDERFORM where ID_ORDERFORM like '" + idOrder + "%';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id_product = (int)sdr["ID_PRODUCT"];
                int quantity = (int)sdr["QUANTITY"];
                int price_product = (int)sdr["TOTAL_PRICE"];


                MyConnection myConnection2 = new MyConnection();
                myConnection2.sqlcon.Open();

                //getkind ơ day
                string query1 = "Select * from PRODUCT where ID_PRODUCT like '" + id_product.ToString() + "%';";
                SqlCommand cmd2 = new SqlCommand(query1, myConnection2.sqlcon);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                sdr2.Read();

                String name_product = (String)sdr2["NAME"];
                int kind = (int)sdr2["ID_KIND"];
                int in_stock = (int)sdr2["QUANTITY"];
                int price = (int)sdr2["PRICE"];

                DetailOrder it = new DetailOrder();

               
                it.LabelName = name_product;

                it.id = id_product;

                it.id_order = int.Parse(idOrder);

                it.kind = kind;

                it.LabelPrice = price.ToString("###,###,##0");

                it.NumberRicQuantity = quantity.ToString("###,###,##0");

                it.LabelTotal_Price = price_product.ToString("###,###,##0");

                it.LabelIn_Stock = in_stock.ToString();

                listitemPrint.Add(it);
            }

            myConnection.sqlcon.Close();
        }
    }
}
