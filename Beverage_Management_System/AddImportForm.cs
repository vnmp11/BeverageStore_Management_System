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
        ImportForm parent;

        int id;
        int idForm;
        string idProduct;
        string dateCre;
        string nameIG;
        string quantityIG;

        ImportGoodsPresenter presenter;

        public string id_IG { get => txt_ID_GIForm.Text; set => throw new NotImplementedException(); }
        public string id_Person { get => id.ToString(); set => throw new NotImplementedException(); }
        public string status { get => "0"; set => throw new NotImplementedException(); }
        public string date { get => dateCre; set => throw new NotImplementedException(); }

        public string statusDetail { get => "0"; set => throw new NotImplementedException(); }
        public string id_Product { get => idProduct; set => throw new NotImplementedException(); }
        public string name { get => nameIG; set => throw new NotImplementedException(); }
        public string quantity { get => quantityIG; set => throw new NotImplementedException(); }
        public string search { get => guna2TextBox1.Text; set => guna2TextBox1.Text = value; }

        public AddImportForm(ImportForm form)
        {
            InitializeComponent();
            this.parent = form;
        }


        public AddImportForm(int id_batender, ImportForm form )
        {
            InitializeComponent();
            this.parent = form;
            id = id_batender;
            presenter = new ImportGoodsPresenter(this, id_batender);
            presenter.setDataGV(DtaGridView_Warehouse);
            DtaGridView_Warehouse.AllowUserToAddRows = false;
            if (DtaGridView_Warehouse.Rows.Count > 0) DtaGridView_Warehouse.CurrentCell.Selected = false;
            idForm = presenter.show_id();
            txt_ID_GIForm.Text = idForm.ToString();
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
            if (dtaGV_GIForm.Rows.Count==1)
            {
                MyMessageBox.showBox("Choose goods you want to import !", "Message");
            }
            else
            {
                for (int i = 0; i < dtaGV_GIForm.RowCount - 1; i++)
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
                parent.refreshDataGV();

            }
        }
        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DtaGridView_Warehouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DtaGridView_Warehouse.Rows[e.RowIndex];
            AddQuatity update = new AddQuatity(int.Parse(row.Cells["ID_PRODUCT"].Value.ToString()), row.Cells["NAME"].Value.ToString(), 1, dtaGV_GIForm);
            update.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DtaGridView_Warehouse.AllowUserToAddRows = true;
            presenter.searchData(DtaGridView_Warehouse);
            DtaGridView_Warehouse.AllowUserToAddRows = false;
        }
    }
}
