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
    class OrderBillPresenter
    {
        IOrderBill orderBillView;
        List<Person> bartenders = new List<Person>();

        public OrderBillPresenter(IOrderBill view)
        {
            this.orderBillView = view;
        }
        public OrderBillPresenter()
        {
        }
        //them total quantity vao day(total quantity OB)
        public void addOrderBill(int id_order, int batender)
        {
            double total_price_products = 0;
            int total_quantity = 0;
            double fine = 0;
            string date_create = DateTime.Now.ToString("yyyy-MM-dd");
            double total_price = 0;

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string querry = "SELECT * from ORDERFORM where ID_ORDERFORM ='" + id_order + "';";
            SqlCommand sqlCommand = new SqlCommand(querry, myConnection.sqlcon);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                total_price_products = Convert.ToDouble(dr["TOTAL_PRICE"]);
                total_quantity = Convert.ToInt32(dr["TOTAL_QUANTITY"]);

            }
            dr.Close();
            total_price = total_price_products + fine;
            MOrderBill orderBill = new MOrderBill(0, id_order, batender, 4, total_price_products, fine, date_create, total_price, 0, total_quantity);

            SqlCommand cmd = new SqlCommand("Insert into ORDER_BILL(ID_ORDER_FORM, ID_BARTENDER, ID_ACCOUNTANT, TOTAL_PRICE_PRODUCTS, FINE," +
                "DATE_CRE, TOTAL_PRICE,STATUS, TOTAL_QUANTITY) " +
                "values (@id_order_form, @id_bartender, @id_accountant, @total_price_products, @fine, @date_cre, @total_price, @stautus, @total_quantity);",
                myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_order_form", orderBill.getID_ORDER_FORM());
            cmd.Parameters.AddWithValue("@id_bartender", orderBill.getID_BARTENDER());
            cmd.Parameters.AddWithValue("@id_accountant", orderBill.getID_ACCOUNTANT());
            cmd.Parameters.AddWithValue("@total_price_products", orderBill.getTOTAL_PRICE_PRODUCTS());
            cmd.Parameters.AddWithValue("@fine", orderBill.getFINE());
            cmd.Parameters.AddWithValue("@date_cre", orderBill.getDATE_CREATE());
            cmd.Parameters.AddWithValue("@total_price", orderBill.getTOTAL_PRICE());
            cmd.Parameters.AddWithValue("@stautus", orderBill.getSTATUS());
            cmd.Parameters.AddWithValue("@total_quantity", orderBill.getTOTAL_QUANTITY());

            cmd.ExecuteNonQuery();
            myConnection.sqlcon.Close();
        }

        public void setDataGV(Guna.UI2.WinForms.Guna2DataGridView dataGV)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderBill> list = new List<MOrderBill>();

            bartenders = new List<Person>();

            string query5 = "Select * from PERSON where ROLE = 2";
            SqlCommand cmd5 = new SqlCommand(query5, myConnection.sqlcon);
            SqlDataReader sdr5 = cmd5.ExecuteReader();
            while (sdr5.Read())
            {
                int id = (int)sdr5["ID_PERSON"];
                string name = sdr5["NAME"].ToString();

                Person person = new Person(id, "", "", name, "", "", "", "", 0);
                bartenders.Add(person);
            }
            sdr5.Close();


            DataTable dt = new DataTable();
            string querry = "Select * from ORDER_BILL where STATUS = 0;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_ORDER_BILL"]);
                    int ID_ORDER_FORM = Convert.ToInt32(row["ID_ORDER_FORM"]);
                    int ID_BARTENDER = Convert.ToInt32(row["ID_BARTENDER"]);
                    int ID_ACCOUNTANT = Convert.ToInt32(row["ID_ACCOUNTANT"]);
                    double TOTAL_PRICE_PRODUCTS = Convert.ToDouble(row["TOTAL_PRICE_PRODUCTS"]);
                    double FINE = Convert.ToDouble(row["FINE"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CRE"]);
                    string DATE_CRE = date.ToString("dd-MM-yyyy");
                    double TOTAL_PRICE = Convert.ToDouble(row["TOTAL_PRICE"]);

                    int STATUS = 0;
                    int TOTAL_QUANTITY = Convert.ToInt32(row["TOTAL_QUANTITY"]);

                    MOrderBill orderBill = new MOrderBill(ID, ID_ORDER_FORM, ID_BARTENDER, ID_ACCOUNTANT, TOTAL_PRICE_PRODUCTS, FINE, DATE_CRE, TOTAL_PRICE, STATUS, TOTAL_QUANTITY);
                    list.Add(orderBill);
                }

            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getID_ORDER_FORM();
                for (int j = 0; j < bartenders.Count(); j++)
                {
                    if (bartenders[j].getID() == list[i].getID_BARTENDER()) row.Cells[2].Value = bartenders[j].getNAME();
                }
                row.Cells[3].Value = list[i].getFINE().ToString("###,###,##0");
                row.Cells[4].Value = list[i].getDATE_CREATE();
                row.Cells[5].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        public void getDetailsOrderBill(int id_order_form, System.Windows.Forms.FlowLayoutPanel fLayoutPl_Details)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            fLayoutPl_Details.Controls.Clear();

            string query = "Select P.ID_PRODUCT, P.NAME, DO.QUANTITY, DO.TOTAL_PRICE from " +
                "(ORDERFORM O join DETAILS_ORDERFORM DO on O.ID_ORDERFORM = DO.ID_ORDERFORM) join " +
                "PRODUCT P on DO.ID_PRODUCT = P.ID_PRODUCT where O.ID_ORDERFORM ='" + id_order_form + "';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id_product = Convert.ToInt32(sdr["ID_PRODUCT"]);
                string name = sdr["NAME"].ToString();
                int quantity = Convert.ToInt32(sdr["QUANTITY"]);
                double total_price = Convert.ToDouble(sdr["TOTAL_PRICE"]);

                DetailsBill i = new DetailsBill();
                i.lb_ID_Product.Text = id_product.ToString();
                i.lb_NameProduct.Text = name;
                i.lb_quantity.Text = quantity.ToString();
                i.lb_total.Text = total_price.ToString("###,###,##0");

                fLayoutPl_Details.Controls.Add(i);
            }
            myConnection.sqlcon.Close();
        }

        public List<DetailsBill> detailsBills= new List<DetailsBill>();
        public void printBill(int id_order_form)
        {
            detailsBills.Clear();
             MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            //fLayoutPl_Details.Controls.Clear();

            string query = "Select P.ID_PRODUCT, P.NAME, DO.QUANTITY, DO.TOTAL_PRICE from " +
                "(ORDERFORM O join DETAILS_ORDERFORM DO on O.ID_ORDERFORM = DO.ID_ORDERFORM) join " +
                "PRODUCT P on DO.ID_PRODUCT = P.ID_PRODUCT where O.ID_ORDERFORM ='" + id_order_form + "';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id_product = Convert.ToInt32(sdr["ID_PRODUCT"]);
                string name = sdr["NAME"].ToString();
                int quantity = Convert.ToInt32(sdr["QUANTITY"]);
                double total_price = Convert.ToDouble(sdr["TOTAL_PRICE"]);

                DetailsBill i = new DetailsBill();
                i.lb_ID_Product.Text = id_product.ToString();
                i.lb_NameProduct.Text = name;
                i.lb_quantity.Text = quantity.ToString();
                i.lb_total.Text = total_price.ToString("###,###,##0");

                detailsBills.Add(i);
                //fLayoutPl_Details.Controls.Add(i);
            }
            myConnection.sqlcon.Close();
        }

        public void browseBill(int ID, int id_accountant,
            Guna.UI2.WinForms.Guna2DataGridView dataGV, int id_form)
        {

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string date_confirm = DateTime.Now.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("Update ORDER_BILL set ID_ACCOUNTANT=@id_accountant, DATE_CON=@date_con, STATUS=@status where ID_ORDER_BILL=@id;",
                myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_accountant", id_accountant);
            cmd.Parameters.AddWithValue("@date_con", date_confirm);
            cmd.Parameters.AddWithValue("@status", 1);
            cmd.Parameters.AddWithValue("@id", ID);


            SqlCommand cmd2 = new SqlCommand("Update DETAILS_ORDERFORM set STATUSb=@status, DATEb =@date where ID_ORDERFORM=@id_orderform",
            myConnection.sqlcon);
            cmd2.Parameters.AddWithValue("@status", "1");
            cmd2.Parameters.AddWithValue("@date", date_confirm);
            cmd2.Parameters.AddWithValue("@id_orderform", id_form);
            cmd2.ExecuteNonQuery();

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                dataGV.Rows.Clear();
                setDataGV(dataGV);
                MyMessageBox.showBox("Browse this bill successfully!", "Message");

            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            
            myConnection.sqlcon.Close();
        }


        public void searchBill(Guna.UI2.WinForms.Guna2DataGridView dataGV)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderBill> list = new List<MOrderBill>();
            dataGV.Rows.Clear();

            int id = 0;
            for (int j = 0; j < bartenders.Count; j++)
            {
                if (bartenders[j].getNAME().Contains(orderBillView.search) == true)
                {
                    id = bartenders[j].getID();
                }
            }


            string querry = "Select * from ORDER_BILL where STATUS = 0 and (ID_ORDER_BILL like '" + orderBillView.search + "%' or " +
                "ID_ORDER_FORM like '" + orderBillView.search + "%' or " +
                "ID_BARTENDER = '" + id + "');";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_ORDER_BILL"]);
                    int ID_ORDER_FORM = Convert.ToInt32(row["ID_ORDER_FORM"]);
                    int ID_BARTENDER = Convert.ToInt32(row["ID_BARTENDER"]);
                    int ID_ACCOUNTANT = Convert.ToInt32(row["ID_ACCOUNTANT"]);
                    double TOTAL_PRICE_PRODUCTS = Convert.ToDouble(row["TOTAL_PRICE_PRODUCTS"]);
                    double FINE = Convert.ToDouble(row["FINE"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CRE"]);
                    string DATE_CRE = date.ToString("dd-MM-yyyy");
                    double TOTAL_PRICE = Convert.ToDouble(row["TOTAL_PRICE"]);
                    int TOTAL_QUANTITY = Convert.ToInt32(row["TOTAL_QUANTITY"]);

                    MOrderBill orderBill = new MOrderBill(ID, ID_ORDER_FORM, ID_BARTENDER, ID_ACCOUNTANT, TOTAL_PRICE_PRODUCTS, FINE, DATE_CRE, TOTAL_PRICE, 0, TOTAL_QUANTITY);
                    list.Add(orderBill);
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getID_ORDER_FORM();
                for (int j = 0; j < bartenders.Count(); j++)
                {
                    if (bartenders[j].getID() == list[i].getID_BARTENDER()) row.Cells[2].Value = bartenders[j].getNAME();
                }
                row.Cells[3].Value = list[i].getFINE().ToString("###,###,##0");
                row.Cells[4].Value = list[i].getDATE_CREATE();
                row.Cells[5].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        public int customer;
        public double total;
        public int total_quantity;

        public void loadListOrderBill(int d, int m, int y)
        {
            customer = 0;
            total = 0;
            total_quantity = 0;

            //List<MOrderBill> list = new List<MOrderBill>();
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            string querryD = "SELECT * from ORDER_BILL where STATUS = 1 and DAY(DATE_CON) = " + d.ToString() + "and MONTH(DATE_CON) =" + m.ToString() + "and MONTH(DATE_CON) =" + m.ToString() + ";";    
            string querryM = "SELECT * from ORDER_BILL where STATUS = 1 and MONTH(DATE_CON) =" + m.ToString() + "and YEAR(DATE_CON) =" + y.ToString() + ";";
            string querryY = "SELECT * from ORDER_BILL where STATUS = 1 and YEAR(DATE_CON) = '" + y.ToString() + "';";

            if(d!=0 && m != 0 && y != 0)
            {
                SqlCommand sqlCommand = new SqlCommand(querryD, myConnection.sqlcon);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    total = total + (double)dr["TOTAL_PRICE_PRODUCTS"];  
                    total_quantity = total_quantity + (int)dr["TOTAL_QUANTITY"];
                    customer += 1;
                }
                dr.Close();
                myConnection.sqlcon.Close();
            }
            else if (d==0 && m != 0 && y!=0)
            {
                SqlCommand sqlCommand = new SqlCommand(querryM, myConnection.sqlcon);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    total = total + (double)dr["TOTAL_PRICE_PRODUCTS"];
                    total_quantity = total_quantity + (int)dr["TOTAL_QUANTITY"];
                    customer += 1;
                }
                dr.Close();
                myConnection.sqlcon.Close();

            }
            else if (d == 0 && m == 0 && y != 0)
            {
                SqlCommand sqlCommand = new SqlCommand(querryY, myConnection.sqlcon);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    total = total + (double)dr["TOTAL_PRICE_PRODUCTS"];
                    total_quantity = total_quantity + (int)dr["TOTAL_QUANTITY"];
                    customer += 1;
                }
                dr.Close();
                myConnection.sqlcon.Close();

            }

        }
    }
}
