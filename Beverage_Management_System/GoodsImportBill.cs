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
    public partial class GoodsImportBill : Form, IGoodsImportBill
    {
        int id_accountant = 0;
        GoodsImportBillPresenter presenter;

        public string search { get => txt_Search.Text; set => txt_Search.Text = value; }

        public GoodsImportBill()
        {
            InitializeComponent();
        }
        public GoodsImportBill(int ID)
        {
            InitializeComponent();
            this.id_accountant = ID;
            presenter = new GoodsImportBillPresenter(this);
            presenter.setDataGV(dataGV);
            dataGV.AllowUserToAddRows = false;
            if (dataGV.Rows.Count > 0) dataGV.CurrentCell.Selected = false;
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV.SelectedCells.Count > 0)
            {
                int selected_index = dataGV.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dataGV.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                if (id_choose > 0)
                {
                    presenter.getDetailsGoodsImportBill(id_choose, fLayoutPl_Details);
                }

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
                    int id_choose = Convert.ToInt32(selected_row.Cells[0].Value);
                    dataGV.AllowUserToAddRows = true;
                    presenter.browseBill(id_choose, id_accountant, dataGV, fLayoutPl_Details);
                    dataGV.AllowUserToAddRows = false;
                    if (dataGV.Rows.Count > 0) dataGV.CurrentCell.Selected = false;
                };

            }
            else MyMessageBox.showBox("Please choose a bill which you want to browse!", "Message");
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if(txt_Search.Text != "")
            {
                dataGV.AllowUserToAddRows = true;
                presenter.searchBill(dataGV);
                dataGV.AllowUserToAddRows = false;
            }
            else
            {
                dataGV.AllowUserToAddRows = true;
                dataGV.Rows.Clear();
                presenter.setDataGV(dataGV);
                if (dataGV.Rows.Count > 0) dataGV.CurrentCell.Selected = false;
                dataGV.AllowUserToAddRows = false;
            }
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {

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
