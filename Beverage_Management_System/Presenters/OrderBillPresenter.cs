using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Presenters
{
    class OrderBillPresenter
    {
        IOrderBill orderBillView;

        public OrderBillPresenter(IOrderBill view)
        {
            this.orderBillView = view;
        }
        public OrderBillPresenter()
        {
        }

        public void addOrderBill(int id_order, int batender)
        {
            double total_price_products = 0;
            double fine = 0;
            string date_create = DateTime.Now.ToString("yyyy-MM-dd");
            double total_price = 0;

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string querry = "SELECT TOTAL_PRICE from ORDERFORM where ID_ORDERFORM ='" + id_order + "';";
            SqlCommand sqlCommand = new SqlCommand(querry, myConnection.sqlcon);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                total_price_products = Convert.ToDouble(dr["TOTAL_PRICE"]);
            }
            dr.Close();
            total_price = total_price_products + fine;
            MOrderBill orderBill = new MOrderBill(0, id_order, batender, 4, total_price_products, fine, date_create, total_price, 0);

            SqlCommand cmd = new SqlCommand("Insert into ORDER_BILL(ID_ORDER_FORM, ID_BARTENDER, ID_ACCOUNTANT, TOTAL_PRICE_PRODUCTS, FINE," +
                "DATE_CRE, TOTAL_PRICE,STATUS) " +
                "values (@id_order_form, @id_bartender, @id_accountant, @total_price_products, @fine, @date_cre, @total_price, @stautus);",
                myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_order_form", orderBill.getID_ORDER_FORM());
            cmd.Parameters.AddWithValue("@id_bartender", orderBill.getID_BARTENDER());
            cmd.Parameters.AddWithValue("@id_accountant", orderBill.getID_ACCOUNTANT());
            cmd.Parameters.AddWithValue("@total_price_products", orderBill.getTOTAL_PRICE_PRODUCTS());
            cmd.Parameters.AddWithValue("@fine", orderBill.getFINE());
            cmd.Parameters.AddWithValue("@date_cre", orderBill.getDATE_CREATE());
            cmd.Parameters.AddWithValue("@total_price", orderBill.getTOTAL_PRICE());
            cmd.Parameters.AddWithValue("@stautus", orderBill.getSTATUS());

            cmd.ExecuteNonQuery();
            myConnection.sqlcon.Close();
        }

        public void setDataGV()
        {
            orderBillView.setDataGV_Fill();
        }

        public void getDetails(int ID)
        {
            orderBillView.getDetailsOrderBill(ID);
        }

        public void browseBill(int ID)
        {
            orderBillView.browseBill(ID);
        }
        
        public void searchBill()
        {
            orderBillView.serachBill();
        }
    }
}
