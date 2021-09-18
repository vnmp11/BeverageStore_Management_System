using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;

namespace Beverage_Management_System
{
    public partial class Staff : Form, IStaff
    {
        int id_choosed = 0;
        public Staff()
        {
            InitializeComponent();
            StaffPresenter presenter = new StaffPresenter(this);
            presenter.setDataGV_Fill(dtGridView_Staff);
            dtGridView_Staff.CurrentCell = null;
            /*SqlConnection con = new SqlConnection("Data Source=beverage-stores-erver.database.windows.net;Initial Catalog=beverage-store;User ID=votrungtin;Password=Trungtin0701@");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select NAME from PERSON where ID_PERSON = @ID", con);
            cmd.Parameters.AddWithValue("@ID", 2);
            SqlDataReader da = cmd.ExecuteReader();
            if(da.Read()) 
            {
                guna2TextBox5.Text = da["NAME"].ToString();
            }
            con.Close();*/
          
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StaffPresenter presenter = new StaffPresenter(this);
            presenter.openAddStaffForm(id_choosed);
        }

        private void dtGridView_Staff_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGridView_Staff.SelectedCells.Count > 0)
            {
                int selected_index = dtGridView_Staff.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dtGridView_Staff.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                StaffPresenter presenter = new StaffPresenter(this);
                presenter.openAddStaffForm(id_choose);
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (dtGridView_Staff.SelectedCells.Count > 0)
            {
                int selected_index = dtGridView_Staff.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dtGridView_Staff.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                StaffPresenter presenter = new StaffPresenter(this);
                if(presenter.deleteStaff(id_choose) > 0)
                {
                    refreshTable();
                    presenter.setDataGV_Fill(dtGridView_Staff);
                    dtGridView_Staff.CurrentCell = null;
                    MyMessageBox.showBox("Delete this staff successfully!", "Message");
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
            else MyMessageBox.showBox("Please choose a staff whom you want to delete!", "Message");
        }

        public void refreshTable()
        {
            dtGridView_Staff.Rows.Clear();
        }

        private void bt_Reload_Click(object sender, EventArgs e)
        {
            StaffPresenter presenter = new StaffPresenter(this);
            refreshTable();
            presenter.setDataGV_Fill(dtGridView_Staff);
            dtGridView_Staff.CurrentCell = null;
            MyMessageBox.showBox("Refreshed! This table is up-to-date.", "Message");
        }
    }
}
