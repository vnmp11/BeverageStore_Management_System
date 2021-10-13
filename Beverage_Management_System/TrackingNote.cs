using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System
{
    public partial class TrackingNote : Form, ITrackingNote
    {
        TrackingNotePresenter presenter;
        public TrackingNote()
        {
            InitializeComponent();
            presenter = new TrackingNotePresenter(this);
            presenter.setDataGV();
            dataGV.CurrentCell.Selected = false;
        }

        public void getDetailsTrackingNote(int ID)
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

        public void searchNote()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MTrackingNote> list = new List<MTrackingNote>();
            dataGV.Rows.Clear();

            string querry = "Select * from TRACKING_NOTE where ID_TRACKING_NOTE like '" + txt_Search.Text + "%' or ID_BILL like '" + txt_Search.Text + "%';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_TRACKING_NOTE"]);
                    int KIND = Convert.ToInt32(row["KIND"]);
                    int ID_BILL = Convert.ToInt32(row["ID_BILL"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CON"]);
                    string DATE_CON = date.ToString("dd-MM-yyyy");

                    MTrackingNote trackingNote = new MTrackingNote(ID, KIND, DATE_CON, ID_BILL);
                    list.Add(trackingNote);
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                if (list[i].getKIND() == 1)
                {
                    row.Cells[1].Value = "Import Products";
                }
                else if (list[i].getKIND() == 2)
                {
                    row.Cells[1].Value = "Sell Products";
                }
                row.Cells[2].Value = list[i].getDATE_CONFIRM();
                row.Cells[3].Value = list[i].getID_BILL();

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        public void setDataGV_Fill()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MTrackingNote> list = new List<MTrackingNote>();

            DataTable dt = new DataTable();
            string querry = "Select * from TRACKING_NOTE;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_TRACKING_NOTE"]);
                    int KIND = Convert.ToInt32(row["KIND"]);
                    int ID_BILL = Convert.ToInt32(row["ID_BILL"]);
                    DateTime date = Convert.ToDateTime(row["DATE_CON"]);
                    string DATE_CON = date.ToString("dd-MM-yyyy");

                    MTrackingNote trackingNote = new MTrackingNote(ID, KIND, DATE_CON, ID_BILL);
                    list.Add(trackingNote);
                }

            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                if(list[i].getKIND() == 1)
                {
                    row.Cells[1].Value = "Import Products";
                }
                else if(list[i].getKIND() == 2)
                {
                    row.Cells[1].Value = "Sell Products";
                }
                row.Cells[2].Value = list[i].getDATE_CONFIRM();
                row.Cells[3].Value = list[i].getID_BILL();

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fLayoutPl_Details.Visible = true;
            if (e.RowIndex < dataGV.RowCount - 1)
            {
                int id_bill = int.Parse(dataGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                presenter.getDetails(id_bill);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            presenter.search();
        }
    }
}
