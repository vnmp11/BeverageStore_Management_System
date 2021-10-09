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
    public partial class OrderBill : Form, IOrderBill
    {
        OrderBillPresenter presenter;
        int id_accountant = 0;
        public OrderBill()
        {
            InitializeComponent();
            presenter = new OrderBillPresenter(this);
        }

        public OrderBill(int ID)
        {
            InitializeComponent();
            this.id_accountant = ID;
            presenter = new OrderBillPresenter(this);
            presenter.setDataGV();
            dataGV.CurrentCell.Selected = false;
        }

        public void getDetailsOrderBill(int id_order_form)
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

        public void setDataGV_Fill()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderBill> list = new List<MOrderBill>();

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
                   
                  
                    MOrderBill orderBill = new MOrderBill(ID, ID_ORDER_FORM, ID_BARTENDER, ID_ACCOUNTANT, TOTAL_PRICE_PRODUCTS, FINE, DATE_CRE, TOTAL_PRICE, STATUS);
                    list.Add(orderBill);
                }

            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getID_ORDER_FORM();
                row.Cells[2].Value = list[i].getID_BARTENDER();
                row.Cells[3].Value = list[i].getTOTAL_PRICE_PRODUCTS().ToString("###,###,##0");
                row.Cells[4].Value = list[i].getFINE();
                row.Cells[5].Value = list[i].getDATE_CREATE();
                row.Cells[6].Value = list[i].getDATE_CONFIRM();
                row.Cells[7].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fLayoutPl_Details.Visible = true;
            lb_Details.Visible = true;
            if (e.RowIndex < dataGV.RowCount - 1)
            {
                int id_order_form = int.Parse(dataGV.Rows[e.RowIndex].Cells[1].Value.ToString());
                presenter.getDetails(id_order_form);
            }
        }

        private void btt_Browse_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedCells.Count > 0)
            {
                AlertDialog dialog = new AlertDialog();
                dialog.setMessage("Do you want to browse this bill?");
                dialog.Show();
                dialog.btt_ok.Click += (s, a) =>
                {
                    int selected_index = dataGV.SelectedCells[0].RowIndex;
                    DataGridViewRow selected_row = dataGV.Rows[selected_index];
                    int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                    presenter.browseBill(id_choose);
                };
               
            }
            else MyMessageBox.showBox("Please choose a bill which you want to browse!", "Message");
        }

        public void browseBill(int ID)
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

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                dataGV.Rows.Clear();
                presenter.setDataGV();
                fLayoutPl_Details.Visible = false;
                lb_Details.Visible = false;
                MyMessageBox.showBox("Browse this bill successfully!", "Message");

            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            myConnection.sqlcon.Close();

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            presenter.searchBill();
        }

        public void serachBill()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<MOrderBill> list = new List<MOrderBill>();
            dataGV.Rows.Clear();

            string querry = "Select * from ORDER_BILL where STATUS = 0 and (ID_ORDER_BILL like '" + txt_Search.Text + "%' or ID_ORDER_FORM like '" + txt_Search.Text + "%');";
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


                    MOrderBill orderBill = new MOrderBill(ID, ID_ORDER_FORM, ID_BARTENDER, ID_ACCOUNTANT, TOTAL_PRICE_PRODUCTS, FINE, DATE_CRE, TOTAL_PRICE, 0);
                    list.Add(orderBill);
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getID_ORDER_FORM();
                row.Cells[2].Value = list[i].getID_BARTENDER();
                row.Cells[3].Value = list[i].getTOTAL_PRICE_PRODUCTS().ToString("###,###,##0");
                row.Cells[4].Value = list[i].getFINE();
                row.Cells[5].Value = list[i].getDATE_CREATE();
                row.Cells[6].Value = list[i].getDATE_CONFIRM();
                row.Cells[7].Value = list[i].getTOTAL_PRICE().ToString("###,###,##0");

                dataGV.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }
    }
}
