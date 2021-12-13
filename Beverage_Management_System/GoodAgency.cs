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

        }
        public void refreshDataGV()
        {
            dataGridView_Goods.Rows.Clear();
            presenter.dataGVGood(dataGridView_Goods, idtemp);
            dataGridView_Goods.CurrentCell = null;
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
            dataGridView_Goods.CurrentCell = null;
        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddGoodAgency frm = new AddGoodAgency(idtemp,this);
            frm.ShowDialog();
        }
        public void openAddGoodForm(int id_choosed, GoodAgency form)
        {
            AddGoodAgency form1 = new AddGoodAgency(id_choosed, form);

            form1.Show();
            //AddGoodAgency form = new AddGoodAgency(id_choosed, this);
            //form.Owner = parent;
            //form.Show();
        }
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Goods.SelectedCells.Count > 0)
            {
                int selected_index = dataGridView_Goods.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dataGridView_Goods.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                GoodAgencyPresenter presenter = new GoodAgencyPresenter(this);
                if (presenter.deleteGoodAgency(id_choose) > 0)
                {
                    refreshTable();
                    presenter.dataGVGood(dataGridView_Goods, idtemp);
                    dataGridView_Goods.CurrentCell = null;
                    MyMessageBox.showBox("Delete this product successfully!", "Message");
                    reloadTable();
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
            else MyMessageBox.showBox("Please choose a product whom you want to delete!", "Message");
        }

        private void GoodAgency_Load(object sender, EventArgs e)
        {

        }

       

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
