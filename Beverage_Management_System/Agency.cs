using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;
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
    public partial class Agency : Form, IAgency
    {
        AgencyPresenter presenter;
        public Agency()
        {
            InitializeComponent();
            presenter = new AgencyPresenter(this);
            presenter.dataGV(dtGridView_Agency);
            dtGridView_Agency.CurrentCell = null;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddAgency frm = new AddAgency(this);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        

        public void refreshTable()
        {
            dtGridView_Agency.Rows.Clear();
        }
     
        public void reloadTableAgency()
        {
            AgencyPresenter presenter = new AgencyPresenter(this);
            refreshTable();
            presenter.dataGV(dtGridView_Agency);
            dtGridView_Agency.CurrentCell = null;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dtGridView_Agency.SelectedCells.Count > 0)
            {
                int selected_index = dtGridView_Agency.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dtGridView_Agency.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                AgencyPresenter presenter = new AgencyPresenter(this);
                if (presenter.deleteAgency(id_choose) > 0)
                {
                    refreshTable();
                    presenter.dataGV(dtGridView_Agency);
                    dtGridView_Agency.CurrentCell = null;
                    MyMessageBox.showBox("Delete this agency successfully!", "Message");
                    reloadTableAgency();
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
            else MyMessageBox.showBox("Please choose a agency whom you want to delete!", "Message");
        }

        private void dtGridView_Agency_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected_index = dtGridView_Agency.SelectedCells[0].RowIndex;
            DataGridViewRow selected_row = dtGridView_Agency.Rows[selected_index];
            int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

            AgencyPresenter presenter = new AgencyPresenter(this);
            openGoodAgencyForm(id_choose);
        }
        GoodAgency good ;

        public void openGoodAgencyForm(int id_choosed)
        {
            GoodAgency form = new GoodAgency(id_choosed);
            form.Show();
        }
        private void Agency_Load(object sender, EventArgs e)
        {

        }

        private void dtGridView_Agency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void refreshDataGV()
        {
            dtGridView_Agency.Rows.Clear();
            presenter.dataGV(dtGridView_Agency);
            dtGridView_Agency.CurrentCell = null;
        }
        private void btt_Update_Click(object sender, EventArgs e)
        {
            if (dtGridView_Agency.SelectedCells.Count > 0)
            {
                int selected_index = dtGridView_Agency.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dtGridView_Agency.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                AgencyPresenter presenter = new AgencyPresenter(this);
                openAddAgencyForm(id_choose,this);
            }
            else
            {
                MyMessageBox.showBox("Please choose a agency whom you want to delete!", "Message");
            }
        }
        public void openAddAgencyForm(int id_choosed, Agency form)
        {

            AddAgency form1 = new AddAgency(id_choosed,form);

            form1.Show();
        }
        private void Agency_Load_1(object sender, EventArgs e)
        {

        }
    }
}
