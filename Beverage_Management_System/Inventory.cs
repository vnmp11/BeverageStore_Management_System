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
    public partial class Inventory : Form, IInventory
    {
        List<MProduct> list_product = new List<MProduct>();
        List<KindOfProduct> list_kind = new List<KindOfProduct>();

        InventoryPresenter presenter;

        public Inventory()
        {
            InitializeComponent();
            dataGV.RowTemplate.Height = 100;
            presenter = new InventoryPresenter(this);
            list_kind = presenter.getListOfKind();
            presenter.setDataGV();
            dataGV.CurrentCell = null;
        }

        public void setDataGV_Fill()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            list_product = new List<MProduct>();

            DataTable dt = new DataTable();
            string querry = "Select ID_PRODUCT, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY from PRODUCT;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_PRODUCT"]);
                    int ID_KIND = Convert.ToInt32(row["ID_KIND"]);
                    int ID_GOODS = Convert.ToInt32(row["ID_GOODS"]);
                    string NAME = row["NAME"].ToString();
                    double PRICE = Convert.ToDouble(row["PRICE"]);
                    string UNIT = row["UNIT"].ToString();
                    int QUANTITY = Convert.ToInt32(row["QUANTITY"]);
                    byte[] IMAGE = null;


                    MProduct product = new MProduct(ID, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY, IMAGE);
                    list_product.Add(product);
                }

            }

            for (int i = 0; i < list_product.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list_product[i].getID();
                row.Cells[1].Value = presenter.getKind(list_kind, list_product[i].getID_KIND());
                row.Cells[2].Value = list_product[i].getID_GOODS();
                row.Cells[3].Value = list_product[i].getNAME();
                row.Cells[4].Value = list_product[i].getPRICE().ToString("###,###,##0");
                row.Cells[5].Value = list_product[i].getUNIT();
                row.Cells[6].Value = list_product[i].getQUANTITY();

                dataGV.Rows.Add(row);

            }

            myConnection.sqlcon.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct(this);
            frm.ShowDialog();
        }

        private void dataGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGV.SelectedCells.Count > 0)
            {
                int selected_index = dataGV.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dataGV.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                presenter.openAddStaffForm(id_choose, this);

            }
        }

        

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedCells.Count > 0)
            {
                int selected_index = dataGV.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dataGV.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                InventoryPresenter presenter = new InventoryPresenter(this);
                if (presenter.deleteProduct(id_choose) > 0)
                {
                    dataGV.Rows.Clear();
                    presenter.setDataGV();
                    dataGV.CurrentCell = null;
                    MyMessageBox.showBox("Delete this product successfully!", "Message");
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
            else MyMessageBox.showBox("Please choose a product which you want to delete!", "Message");
        }

        public void refreshDataGV()
        {
            dataGV.Rows.Clear();
            presenter.setDataGV();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            presenter.searchDataInDataDV();
        }

        public void searchData()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            list_product = new List<MProduct>();
            dataGV.Rows.Clear();

            DataTable dt = new DataTable();
            string querry = "Select ID_PRODUCT, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY from PRODUCT where NAME like '" + txt_Search.Text + "%'" +
                "or ID_PRODUCT like '" + txt_Search.Text + "%';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_PRODUCT"]);
                    int ID_KIND = Convert.ToInt32(row["ID_KIND"]);
                    int ID_GOODS = Convert.ToInt32(row["ID_GOODS"]);
                    string NAME = row["NAME"].ToString();
                    double PRICE = Convert.ToDouble(row["PRICE"]);
                    string UNIT = row["UNIT"].ToString();
                    int QUANTITY = Convert.ToInt32(row["QUANTITY"]);
                    byte[] IMAGE = null;


                    MProduct product = new MProduct(ID, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY, IMAGE);
                    list_product.Add(product);
                }

            }

            for (int i = 0; i < list_product.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list_product[i].getID();
                row.Cells[1].Value = presenter.getKind(list_kind, list_product[i].getID_KIND());
                row.Cells[2].Value = list_product[i].getID_GOODS();
                row.Cells[3].Value = list_product[i].getNAME();
                row.Cells[4].Value = list_product[i].getPRICE().ToString("###,###,##0");
                row.Cells[5].Value = list_product[i].getUNIT();
                row.Cells[6].Value = list_product[i].getQUANTITY();

                dataGV.Rows.Add(row);

            }

            myConnection.sqlcon.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
