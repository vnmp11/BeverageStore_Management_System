using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.View;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System.Presenters
{
    class IncidentReportPresenter
    {
        IAddReport addReportView;
        public IncidentReportPresenter(IAddReport view)
        {
            addReportView = view;
        }
        public IncidentReportPresenter()
        {
        }
        public void showId(Guna2ComboBox cb)
        {
            String query1 = "Select ID_ORDER_FORM from ORDER_BILL Where STATUS = 0;";

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand(query1, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id = (int)sdr["ID_ORDER_FORM"];

                cb.Items.Add(id.ToString());
            }

            myConnection.sqlcon.Close();

        }

        public void addReport(String id_orderform, DateTime date)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Insert into INCIDENT_REPORT(ID_ORDERFORM, REASON, SOLUTION, FINE, DATE) " +
                "values (@id_orderform, @reason ,@solution, @fine, @date);",
                myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_orderform", id_orderform);
            cmd.Parameters.AddWithValue("@reason", addReportView.reason);
            cmd.Parameters.AddWithValue("@solution", addReportView.solution);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@fine", addReportView.fine);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MyMessageBox.showBox("Submitted.");
                updateFine(id_orderform, addReportView.fine);
            }

            myConnection.sqlcon.Close();

        }

        public void updateReport(String idreport)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update INCIDENT_REPORT set FINE=@fine, SOLUTION=@solution, REASON=@reason where ID_ORDERFORM like '" + idreport + "';",
                  myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@fine", addReportView.fine);
            cmd.Parameters.AddWithValue("@reason", addReportView.reason);
            cmd.Parameters.AddWithValue("@solution", addReportView.solution);
            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MyMessageBox.showBox("Updated.");
                updateFine2(idreport,addReportView.fine);
            }

            myConnection.sqlcon.Close();
        }

        public bool checkReport(String idreport)
        {
            bool check = false;
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Select * from INCIDENT_REPORT where ID_ORDERFORM=@id_orderform",
                   myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_orderform", idreport);

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                check = true;
            }
            return check;

            myConnection.sqlcon.Close();
        }


        public void showListReport(DataGridView dt)
        {


            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MReport> reportlist = new List<MReport>();
            dt.Rows.Clear();

            string query = "Select * from INCIDENT_REPORT";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                int id = (int)sdr["ID_INCIDENT_REPORT"];
                int id_order_form = (int)sdr["ID_ORDERFORM"];
                string reason = (string)sdr["REASON"];
                string solution = (string)sdr["SOLUTION"];
                int fine = (int)sdr["FINE"];
                DateTime date = (DateTime)sdr["DATE"];

                MReport i = new MReport(id, id_order_form, reason, solution, fine, date);
                reportlist.Add(i);
            }

            myConnection.sqlcon.Close();

            for (int i = 0; i < reportlist.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dt.Rows[i].Clone();
                row.Cells[0].Value = reportlist[i].getID();
                row.Cells[1].Value = reportlist[i].getID_ORDER_FORM();
                row.Cells[2].Value = reportlist[i].getREASON();
                row.Cells[3].Value = reportlist[i].getSOLUTION();
                row.Cells[4].Value = reportlist[i].getFINE().ToString("###,###,##0");
                row.Cells[5].Value = reportlist[i].getDATE().ToString("dd/MM/yyyy");

                dt.Rows.Add(row);
            }
        }

        int getFine(String id_orderbill)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string query = "Select FINE from ORDER_BILL Where ID_ORDER_FORM=@id";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id", id_orderbill);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();

            int fine = int.Parse(sdr["FINE"].ToString());
            myConnection.sqlcon.Close();
            return fine;

        }
        void updateFine(String id_orderbill, String fine)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update ORDER_BILL set FINE=@fine, TOTAL_PRICE=@total_price where ID_ORDER_FORM like '" + id_orderbill + "';",
                  myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@fine", int.Parse(fine) + getFine(id_orderbill));
            cmd.Parameters.AddWithValue("@total_price", int.Parse(fine) + getTotalBill(id_orderbill));
            cmd.ExecuteNonQuery();

            myConnection.sqlcon.Close();

        }

        void updateFine2(String id_orderbill, String fine)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update ORDER_BILL set FINE=@fine, TOTAL_PRICE=@total_price where ID_ORDER_FORM like '" + id_orderbill + "';",
                  myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@fine", int.Parse(fine));
            cmd.Parameters.AddWithValue("@total_price", int.Parse(fine) + (getTotalBill(id_orderbill) - getFine(id_orderbill)));
            cmd.ExecuteNonQuery();

            myConnection.sqlcon.Close();

        }

        void updateFine3(String id_orderbill)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Update ORDER_BILL set FINE=@fine, TOTAL_PRICE=@total_price where ID_ORDER_FORM like '" + id_orderbill + "';",
                  myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@fine", 0);
            cmd.Parameters.AddWithValue("@total_price", getTotalBill(id_orderbill) - getFine(id_orderbill));
            cmd.ExecuteNonQuery();

            myConnection.sqlcon.Close();

        }

        int getTotalBill(String id_orderbill)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string query = "Select TOTAL_PRICE from ORDER_BILL Where ID_ORDER_FORM=@id";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id", id_orderbill);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();

            int total = int.Parse(sdr["TOTAL_PRICE"].ToString());
            myConnection.sqlcon.Close();
            return total;

        }

        public void searchReport(DataGridView dt, string search)
        {


            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MReport> reportlist = new List<MReport>();
            dt.Rows.Clear();

            string query = "Select * from INCIDENT_REPORT Where ID_ORDERFORM=@id_orderform";

            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id_orderform", search);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                int id = (int)sdr["ID_INCIDENT_REPORT"];
                int id_order_form = (int)sdr["ID_ORDERFORM"];
                string reason = (string)sdr["REASON"];
                string solution = (string)sdr["SOLUTION"];
                int fine = (int)sdr["FINE"];
                DateTime date = (DateTime)sdr["DATE"];

                MReport i = new MReport(id, id_order_form, reason, solution, fine, date);
                reportlist.Add(i);
            }

            myConnection.sqlcon.Close();

            for (int i = 0; i < reportlist.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dt.Rows[i].Clone();
                row.Cells[0].Value = reportlist[i].getID();
                row.Cells[1].Value = reportlist[i].getID_ORDER_FORM();
                row.Cells[2].Value = reportlist[i].getREASON();
                row.Cells[3].Value = reportlist[i].getSOLUTION();
                row.Cells[4].Value = reportlist[i].getFINE().ToString("###,###,##0");
                row.Cells[5].Value = reportlist[i].getDATE();

                dt.Rows.Add(row);
            }
        }

        public void setInformation(int id_orderform, String reason, String solution, int fine, DateTime date,
            Guna.UI2.WinForms.Guna2TextBox txb_Fine, System.Windows.Forms.RichTextBox txb_Reason,
            System.Windows.Forms.RichTextBox txb_Solution, Guna.UI2.WinForms.Guna2ComboBox cb_idOrderBill,
            Guna.UI2.WinForms.Guna2DateTimePicker dateTime)
        {
            txb_Fine.Text = fine.ToString();
            txb_Reason.Text = reason;
            txb_Solution.Text = solution;
            cb_idOrderBill.Items.Add(id_orderform.ToString());
            cb_idOrderBill.SelectedIndex = 1;
            dateTime.Value = date;
        }

        public int deleteReport(String id, String id_order)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Delete from INCIDENT_REPORT where ID_INCIDENT_REPORT=@id;", myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                updateFine3(id_order);
                myConnection.sqlcon.Close();
                return 1;
            }
            else
            {
                myConnection.sqlcon.Close();
                return 0;
            }

        }
    }
}
