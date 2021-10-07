using System;
using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Beverage_Management_System
{
    public partial class AddImportForm : Form, IAddImportGoods
    {

        int id;
        int idForm;
         string idProduct;
        string dateCre;
        string nameIG;
        string quantityIG;
        
        List<MProduct> list_product = new List<MProduct>();
        List<KindOfProduct> list_kind = new List<KindOfProduct>();
        ImportGoodsPresenter presenter;

        public string id_IG { get => txt_ID_GIForm.Text; set => throw new NotImplementedException(); }
        public string id_Person { get => id.ToString(); set => throw new NotImplementedException(); }
        public string status { get => "0"; set => throw new NotImplementedException(); }
        public string date { get => dateCre; set => throw new NotImplementedException(); }
       
        public string statusDetail { get => "0"; set => throw new NotImplementedException(); }
        public string id_Product { get => idProduct; set => throw new NotImplementedException(); }
        public string name { get => nameIG; set => throw new NotImplementedException(); }
        public string quantity { get => quantityIG; set => throw new NotImplementedException(); }

        public AddImportForm()
        {
            InitializeComponent();
        }

     
        public AddImportForm(int id_batender)
        {
            InitializeComponent();
            id = id_batender;
            presenter = new ImportGoodsPresenter(this, id_batender);
            presenter.setDataGV();
            idForm = presenter.show_id();
            txt_ID_GIForm.Text = idForm.ToString();
        }

        private void DtaGridView_Warehouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void setDataGV_Fill_ImportGoods()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            list_product = new List<MProduct>();

            DataTable dt = new DataTable();
            string querry = "Select ID_PRODUCT, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY from PRODUCT where QUANTITY < 100;";
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
                DataGridViewRow row = (DataGridViewRow)DtaGridView_Warehouse.Rows[i].Clone();
                row.Cells[0].Value = list_product[i].getID_GOODS(); 
                row.Cells[1].Value = list_product[i].getNAME();
                row.Cells[2].Value = list_product[i].getQUANTITY();   
                DtaGridView_Warehouse.Rows.Add(row);
            }

            myConnection.sqlcon.Close();
        }

        private void DtaGridView_Warehouse_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DtaGridView_Warehouse.Rows[e.RowIndex];
            UpdateItem update = new UpdateItem(int.Parse(row.Cells["ID_PRODUCT"].Value.ToString()), row.Cells["NAME"].Value.ToString(), 1, dtaGV_GIForm);          
            update.Show();

        }

        private void btt_clearAll_Click(object sender, EventArgs e)
        {
            dtaGV_GIForm.Rows.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dtaGV_GIForm.SelectedCells.Count > 0) 
            {
                dtaGV_GIForm.Rows.RemoveAt(dtaGV_GIForm.SelectedRows[0].Index);
            } 
        }

        private void btt_Pay_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dtaGV_GIForm.RowCount-1 ; i++)
           
            {
               
                dateCre = DateTime.Now.ToString();
                idProduct = dtaGV_GIForm.Rows[i].Cells["ID_GIF"].Value.ToString();
                nameIG = dtaGV_GIForm.Rows[i].Cells["NAME_GIF"].Value.ToString();
                quantityIG = dtaGV_GIForm.Rows[i].Cells["QUANTITY_GIF"].Value.ToString();

                presenter.addDetailImportForm();
                

                
                
            }
            presenter.updateImportForm();
            presenter.addImportForm();
            dtaGV_GIForm.Rows.Clear();
            txt_ID_GIForm.Text = presenter.show_id().ToString();
            

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
   

        private void AddImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        //    ImportForm f = (ImportForm)this.Owner;
           
        //    f.reloadTable();
        }
    }
}
