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
    class TrackingNotePresenter
    {
        ITrackingNote trackingNoteView;

        List<MTrackingNote> trackingNotes = new List<MTrackingNote>();

        public TrackingNotePresenter(ITrackingNote view)
        {
            this.trackingNoteView = view;
        }
        public TrackingNotePresenter()
        {
        }
        public void setDataGV(Guna.UI2.WinForms.Guna2DataGridView dataGV)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            trackingNotes = new List<MTrackingNote>();

            DataTable dt = new DataTable();
            string querry = "Select * from TRACKING_NOTE;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_TRACKING_NOTE"]);
                    string BARTENDER = row["BARTENDER"].ToString();
                    int ID_BILL = Convert.ToInt32(row["ID_BILL"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CON"]);
                    string DATE_CON = date.ToString("dd-MM-yyyy");

                    MTrackingNote trackingNote = new MTrackingNote(ID, BARTENDER, DATE_CON, ID_BILL);
                    trackingNotes.Add(trackingNote);
                }

            }

            for (int i = 0; i < trackingNotes.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = trackingNotes[i].getID();
                row.Cells[1].Value = trackingNotes[i].getBARTENDER();
                row.Cells[2].Value = trackingNotes[i].getDATE_CONFIRM();
                row.Cells[3].Value = trackingNotes[i].getID_BILL();

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }
        public void getDetailsTrackingNote(int ID, System.Windows.Forms.FlowLayoutPanel fLayoutPl_Details)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            fLayoutPl_Details.Controls.Clear();

            string query = "Select ID_PRODUCT, NAME, QUANTITY from DETAILS_TRACKING_NOTE where ID_TRACKING_NOTE ='" + ID + "';";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int id_product = Convert.ToInt32(sdr["ID_PRODUCT"]);
                string name = sdr["NAME"].ToString();
                int quantity = Convert.ToInt32(sdr["QUANTITY"]);

                ItemTrackingNote i = new ItemTrackingNote();
                i.lb_ID_Product.Text = id_product.ToString();
                i.lb_NameProduct.Text = name;
                i.lb_quantity.Text = quantity.ToString();
                fLayoutPl_Details.Controls.Add(i);
            }
            myConnection.sqlcon.Close();
        }
        public void searchNote(Guna.UI2.WinForms.Guna2DataGridView dataGV)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MTrackingNote> list = new List<MTrackingNote>();
            dataGV.Rows.Clear();

            string querry = "Select * from TRACKING_NOTE where ID_TRACKING_NOTE like '" + trackingNoteView.search + "%' or " +
                "ID_BILL like '" + trackingNoteView.search + "%' or " +
                "BARTENDER like '" + trackingNoteView.search + "%';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_TRACKING_NOTE"]);
                    string BARTENDER = row["BARTENDER"].ToString();
                    int ID_BILL = Convert.ToInt32(row["ID_BILL"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CON"]);
                    string DATE_CON = date.ToString("dd-MM-yyyy");

                    MTrackingNote trackingNote = new MTrackingNote(ID, BARTENDER, DATE_CON, ID_BILL);
                    list.Add(trackingNote);
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getBARTENDER();
                row.Cells[2].Value = list[i].getDATE_CONFIRM();
                row.Cells[3].Value = list[i].getID_BILL();

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }
    }
}
