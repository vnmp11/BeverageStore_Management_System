using Beverage_Management_System.View;
using Beverage_Management_System.Presenters;
using Beverage_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System
{
    public partial class GoodAgency : Form, IGoodsAgency
    {
        GoodAgencyPresenter presenter;
        
        public GoodAgency()
        {
            InitializeComponent();
            
        }

        public static int idtemp;
        public GoodAgency(int ID)
        {
            InitializeComponent();

            presenter = new GoodAgencyPresenter(this);
            presenter.dataGVGood(dataGridView_Goods, ID);
            idtemp = ID;
            if (dataGridView_Goods.Rows.Count > 1) dataGridView_Goods.CurrentCell.Selected = false;

        }
        public void refreshDataGV()
        {
            dataGridView_Goods.Rows.Clear();
            presenter.dataGVGood(dataGridView_Goods, idtemp);
            if (dataGridView_Goods.Rows.Count > 1) dataGridView_Goods.CurrentCell.Selected = false;
        }
        public void refreshTable()
        {
            dataGridView_Goods.Rows.Clear();
        }

        public void reloadTable()
        {
            GoodAgencyPresenter presenter = new GoodAgencyPresenter(this);
            refreshTable();
            presenter.dataGVGood(dataGridView_Goods, idtemp);
            if (dataGridView_Goods.Rows.Count > 1) dataGridView_Goods.CurrentCell.Selected = false;
        }

       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddGoodAgency frm = new AddGoodAgency(idtemp,this);
            frm.ShowDialog();
        }
       
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Goods.SelectedCells.Count > 0)
            {
                AlertDialog dialog = new AlertDialog();
                dialog.setMessage("Do you want to delete this goods?");
                dialog.Show();
                dialog.btt_ok.Click += (s, a) =>
                {
                    int selected_index = dataGridView_Goods.SelectedCells[0].RowIndex;
                    DataGridViewRow selected_row = dataGridView_Goods.Rows[selected_index];
                    int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                    GoodAgencyPresenter presenter = new GoodAgencyPresenter(this);
                    int result = presenter.deleteGoodAgency(id_choose);
                    if (result == 1)
                    {
                        refreshTable();
                        presenter.dataGVGood(dataGridView_Goods, idtemp);
                        if (dataGridView_Goods.Rows.Count > 1) dataGridView_Goods.CurrentCell.Selected = false;
                        MyMessageBox.showBox("Delete this product successfully!", "Message");
                        reloadTable();
                    }
                    else if (result == 0) MyMessageBox.showBox("You cannot delete this goods because this action will affect the store's statistics", "Message");
                    else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
                };

            }
            else MyMessageBox.showBox("Please choose a product whom you want to delete!", "Message");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (guna2TextBox1.Text == "")
                {
                    MyMessageBox.showBox("Please enter something before searching", "Message");
                }
                else MyMessageBox.showBox("The result of searching is below", "Message");
            }
        }
    }
}
