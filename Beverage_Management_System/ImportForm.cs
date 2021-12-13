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

            DtaGridView_IGF.CurrentCell = null;
        }
        public ImportForm(int id_batender)
        {
            InitializeComponent();
            id = id_batender;
            presenter = new ImportGoodsPresenter(this);
            presenter.dataGV_IGF(DtaGridView_IGF, 0);
            DtaGridView_IGF.CurrentCell = null;

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        //public void refreshTable()
        //{
        //    DtaGridView_IGF.Rows.Clear();
        //}

        //public void reloadTable()
        //{
        //    AgencyPresenter presenter = new AgencyPresenter(this);
        //    refreshTable();
        //    presenter.dataGV(dtGridView_Agency);
        //    dtGridView_Agency.CurrentCell = null;
        //}
        private void btt_Add_Click(object sender, EventArgs e)
        {
            AddImportForm frm = new AddImportForm(id,this);
            frm.ShowDialog();
        }

        public void refreshDataGV()
        {
            Console.WriteLine("aabc test");
            DtaGridView_IGF.Rows.Clear();
           
            presenter.dataGV_IGF(DtaGridView_IGF, 0);

            DtaGridView_IGF.CurrentCell = null;
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
                    if (presenter.deleteImportForm(id_choose) == true)
                    {
                        DtaGridView_IGF.Rows.RemoveAt(selected_index);
                    }



                }
            }
            else
            {
                MyMessageBox.showBox("Please choose the row!", "Message");
            }
        }

        private void DtaGridView_IGF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected_index = DtaGridView_IGF.SelectedCells[0].RowIndex;
            DataGridViewRow selected_row = DtaGridView_IGF.Rows[selected_index];
            int id_choose = Convert.ToInt32(selected_row.Cells["ID_IGF"].Value);

            ImportGoodsPresenter presenter = new ImportGoodsPresenter(this);
            if (id == 0)
            {
                GoodsInImportForm form = new GoodsInImportForm(id_choose, 0);
                form.Show();
            }
            else
            {
                GoodsInImportForm form = new GoodsInImportForm(id_choose);
                form.Show();
            }
        }

      
    }
}
