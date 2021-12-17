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
        InventoryPresenter presenter;

        public string search { get => txt_Search.Text; set => txt_Search.Text = value; }

        public Inventory()
        {
            InitializeComponent();
            dataGV.RowTemplate.Height = 100;
            presenter = new InventoryPresenter(this);
            presenter.getListOfKind();
            presenter.setDataGV(dataGV);
            if (dataGV.Rows.Count > 1) dataGV.CurrentCell.Selected = false;
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
                presenter.openAddProductForm(id_choose, this);

            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedCells.Count > 0)
            {
                AlertDialog dialog = new AlertDialog();
                dialog.setMessage("Do you want to delete this product?");
                dialog.Show();
                dialog.btt_ok.Click += (s, a) =>
                {
                    int selected_index = dataGV.SelectedCells[0].RowIndex;
                    DataGridViewRow selected_row = dataGV.Rows[selected_index];
                    int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);
                    int result = presenter.deleteProduct(id_choose);
                    if (result == 1)
                    {
                        dataGV.Rows.Clear();
                        presenter.setDataGV(dataGV);
                        if (dataGV.Rows.Count > 1) dataGV.CurrentCell.Selected = false;
                        MyMessageBox.showBox("Delete this product successfully!", "Message");
                    }
                    else if (result == 0) MyMessageBox.showBox("You cannot delete this product because this action will affect the store's statistics", "Message");
                    else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
                };

            }
            else MyMessageBox.showBox("Please choose a product which you want to delete!", "Message");
        }
        public void refreshDataGV()
        {
            dataGV.Rows.Clear();
            presenter.setDataGV(dataGV);
            if (dataGV.Rows.Count > 1) dataGV.CurrentCell.Selected = false;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            presenter.searchData(dataGV);
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
