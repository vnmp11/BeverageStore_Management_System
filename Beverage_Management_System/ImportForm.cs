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
        public ImportForm()
        {
            InitializeComponent();
            btt_Add.Visible = false;
            bt_Delete.Visible = false;
            
            presenter = new ImportGoodsPresenter(this);
            presenter.dataGV_IGF(DtaGridView_IGF, 1);

            DtaGridView_IGF.CurrentCell = null;
        }
        int id = 0;
        ImportGoodsPresenter presenter;

        public ImportForm(int id_batender)
        {
            InitializeComponent();
            id = id_batender;
            presenter = new ImportGoodsPresenter(this);
            presenter.dataGV_IGF(DtaGridView_IGF,0);

            DtaGridView_IGF.CurrentCell = null;
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btt_Add_Click(object sender, EventArgs e)
        {
            AddImportForm frm = new AddImportForm(id);
            frm.ShowDialog();
        }


        public void refreshTable()
        {
            DtaGridView_IGF.Rows.Clear();
        }

        public void reloadTable()
        {
            ImportGoodsPresenter presenter = new ImportGoodsPresenter(this);
            refreshTable();
            presenter.dataGV_IGF(DtaGridView_IGF,0);
            DtaGridView_IGF.CurrentCell = null;
        }

        private void DtaGridView_IGF_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected_index = DtaGridView_IGF.SelectedCells[0].RowIndex;
            DataGridViewRow selected_row = DtaGridView_IGF.Rows[selected_index];
            int id_choose = Convert.ToInt32(selected_row.Cells["ID_IGF"].Value);

            ImportGoodsPresenter presenter = new ImportGoodsPresenter(this);
            if (id == 0)
            {
                presenter.openGoodsDetailFormMaster(id_choose);
            }
            else
            {
                presenter.openGoodsDetailFormBAR(id_choose);
            }
           

        }


        private void bt_Delete_Click(object sender, EventArgs e)
        {
            
            if (DtaGridView_IGF.SelectedCells.Count > 0)
            {
                int selected_index = DtaGridView_IGF.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = DtaGridView_IGF.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID_IGF"].Value);
                if (Convert.ToBoolean(DtaGridView_IGF.Rows[selected_index].Cells[3].Value) == true)
                {
                    MyMessageBox.showBox("The order has been confirmed by the master!", "Message");
                }
                else
                {
                    DtaGridView_IGF.Rows.RemoveAt(selected_index);

                    MyConnection myConnection = new MyConnection();
                    myConnection.sqlcon.Open();

                    SqlCommand cmd1 = new SqlCommand("Delete from DETAIL_GOODS_IMPORT_FORM where ID_GOODS_IMPORT_FORM=@id;", myConnection.sqlcon);
                    cmd1.Parameters.AddWithValue("@id", id_choose);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("Delete from GOODS_IMPORT_FORM where ID_GOODS_IMPORT_FORM=@id;", myConnection.sqlcon);
                    cmd.Parameters.AddWithValue("@id", id_choose);
                    cmd.ExecuteNonQuery();

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MyMessageBox.showBox("Delete import form successfully!", "Message");

                    }
                }
            }
            else
            {
                MyMessageBox.showBox("Please choose the row!", "Message");
            }
        }

        private void DtaGridView_IGF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
