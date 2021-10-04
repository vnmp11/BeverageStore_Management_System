using Beverage_Management_System.Connection;
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
        public void addOrderBill(int id_order, int batender, int waiter)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Insert into ORDERBILL(ID_ORDERFORM,TOTAL_PRICE,STATUS,ID_WAITER,ID_BATENDER) " +
                "values (@id_orderform, @total_price, @stautus,@id_waiter,@id_batender);",
                myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_orderform", id_order);
            cmd.Parameters.AddWithValue("@total_price", "0");
            cmd.Parameters.AddWithValue("@stautus", "1");
            cmd.Parameters.AddWithValue("@id_waiter", waiter);
            cmd.Parameters.AddWithValue("@id_batender", batender);

            cmd.ExecuteNonQuery();
            myConnection.sqlcon.Close();
        }
    }
}
