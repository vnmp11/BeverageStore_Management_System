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
            dtGridView_Agency.AllowUserToAddRows = false;
            if(dtGridView_Agency.Rows.Count > 0) dtGridView_Agency.CurrentCell.Selected = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddAgency frm = new AddAgency(this);
            frm.ShowDialog();
        }

        public void refreshTable()
        {
            dtGridView_Agency.Rows.Clear();
        }
     
        public void reloadTableAgency()
        {
            dtGridView_Agency.AllowUserToAddRows = true;
            AgencyPresenter presenter = new AgencyPresenter(this);
            refreshTable();
            presenter.dataGV(dtGridView_Agency);
            dtGridView_Agency.AllowUserToAddRows = false;
            if (dtGridView_Agency.Rows.Count > 1) dtGridView_Agency.CurrentCell.Selected = false;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dtGridView_Agency.SelectedCells.Count > 0)
            {
               
                AlertDialog dialog = new AlertDialog();
                dialog.setMessage("Do you want to delete this agency?");
                dialog.Show();
                dialog.btt_ok.Click += (s, a) =>
                {
                    int selected_index = dtGridView_Agency.SelectedCells[0].RowIndex;
                    DataGridViewRow selected_row = dtGridView_Agency.Rows[selected_index];
                    int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                    AgencyPresenter presenter = new AgencyPresenter(this);
                    int result = presenter.deleteAgency(id_choose);
                    if (result == 1)
                    {
                        dtGridView_Agency.AllowUserToAddRows = true;
                        refreshTable();
                        presenter.dataGV(dtGridView_Agency);
                        dtGridView_Agency.AllowUserToAddRows = false;
                        if (dtGridView_Agency.Rows.Count > 0) dtGridView_Agency.CurrentCell.Selected = false;
                        MyMessageBox.showBox("Delete this agency successfully!", "Message");
                        reloadTableAgency();
                    }
                    else if (result == 0) MyMessageBox.showBox("You cannot delete this agency because this action will affect the store's statistics", "Message");
                    else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
                };

            }
            else MyMessageBox.showBox("Please choose a agency which you want to delete!", "Message");
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
        public void refreshDataGV()
        {
            dtGridView_Agency.AllowUserToAddRows = true;
            dtGridView_Agency.Rows.Clear();
            presenter.dataGV(dtGridView_Agency);
            dtGridView_Agency.AllowUserToAddRows = false;
            if (dtGridView_Agency.Rows.Count > 0) dtGridView_Agency.CurrentCell.Selected = false;
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
