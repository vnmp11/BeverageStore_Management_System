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
    public partial class ImportForm : Form, IImportGoods
    {
        int id = 0;
        ImportGoodsPresenter presenter;
        public ImportForm()
        {
            InitializeComponent();
            btt_Add.Visible = false;
            bt_Delete.Visible = false;
           
            presenter = new ImportGoodsPresenter(this);
            presenter.dataGV_IGF(DtaGridView_IGF, 1);
            DtaGridView_IGF.AllowUserToAddRows = false;

            if(DtaGridView_IGF.Rows.Count > 0) DtaGridView_IGF.CurrentCell.Selected = false;
        }
        public ImportForm(int id_batender)
        {
            InitializeComponent();
            id = id_batender;
            presenter = new ImportGoodsPresenter(this);
            presenter.dataGV_IGF(DtaGridView_IGF, 0);
            DtaGridView_IGF.AllowUserToAddRows = false;
            if (DtaGridView_IGF.Rows.Count > 0) DtaGridView_IGF.CurrentCell.Selected = false;

        }
        private void btt_Add_Click(object sender, EventArgs e)
        {
            AddImportForm frm = new AddImportForm(id,this);
            frm.ShowDialog();
        }

        public void refreshDataGV()
        {
            DtaGridView_IGF.AllowUserToAddRows = true;
            DtaGridView_IGF.Rows.Clear();
           
            presenter.dataGV_IGF(DtaGridView_IGF, 0);
            DtaGridView_IGF.AllowUserToAddRows = false;

            if (DtaGridView_IGF.Rows.Count > 0) DtaGridView_IGF.CurrentCell.Selected = false;
        }

        public void refreshDataGVAdmin()
        {
            DtaGridView_IGF.AllowUserToAddRows = true;
            DtaGridView_IGF.Rows.Clear();

            presenter.dataGV_IGF(DtaGridView_IGF, 1);
            DtaGridView_IGF.AllowUserToAddRows = false;

            if (DtaGridView_IGF.Rows.Count > 0) DtaGridView_IGF.CurrentCell.Selected = false;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            DtaGridView_IGF.AllowUserToAddRows = true;
            if (DtaGridView_IGF.SelectedCells.Count > 0)
            {
                int selected_index = DtaGridView_IGF.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = DtaGridView_IGF.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID_IGF"].Value);
                if (Convert.ToBoolean(DtaGridView_IGF.Rows[selected_index].Cells[4].Value) == true)
                {
                    MyMessageBox.showBox("The order has been confirmed by the master!", "Message");
                }
                else
                {
                    if (presenter.deleteImportForm(id_choose) == true)
                    {
                        DtaGridView_IGF.Rows.RemoveAt(selected_index);
                    }


                }
            }
            else
            {
                MyMessageBox.showBox("Please choose the import form which you want to delete!", "Message");
            }
            DtaGridView_IGF.AllowUserToAddRows = false;
        }

        private void DtaGridView_IGF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DtaGridView_IGF.SelectedCells.Count > 0)
            {
                int selected_index = DtaGridView_IGF.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = DtaGridView_IGF.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID_IGF"].Value);

                if (id_choose > 0)
                {
                    ImportGoodsPresenter presenter = new ImportGoodsPresenter(this);
                    if (id == 0)
                    {
                        GoodsInImportForm form = new GoodsInImportForm(id_choose, 0, this);
                        form.Show();
                    }
                    else
                    {
                        GoodsInImportForm form = new GoodsInImportForm(id_choose, this);
                        form.Show();
                    }
                }
            }
            
            
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if(txt_Search.Text != "")
            {
                DtaGridView_IGF.AllowUserToAddRows = true;
                if (id == 0) presenter.searchDataInImporForms(DtaGridView_IGF, 1, txt_Search.Text);
                else presenter.searchDataInImporForms(DtaGridView_IGF, 0, txt_Search.Text);
                DtaGridView_IGF.AllowUserToAddRows = false;
            }
            else
            {
                DtaGridView_IGF.AllowUserToAddRows = true;
                if (id == 0) presenter.searchDataInImporForms(DtaGridView_IGF, 1, txt_Search.Text);
                else presenter.searchDataInImporForms(DtaGridView_IGF, 0, txt_Search.Text);
                if (DtaGridView_IGF.Rows.Count > 0) DtaGridView_IGF.CurrentCell.Selected = false;
                DtaGridView_IGF.AllowUserToAddRows = false;
            }
           
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Search.Text == "")
                {
                    MyMessageBox.showBox("Please enter something before searching", "Message");
                }
                else MyMessageBox.showBox("The result of searching is below", "Message");
            }
        }
    }
}
