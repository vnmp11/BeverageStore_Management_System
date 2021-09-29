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
        StaffPresenter presenter;

        public Staff()
        {
            InitializeComponent();
            presenter = new StaffPresenter(this);
            presenter.setDataGV_Fill(dtGridView_Staff);
            dtGridView_Staff.CurrentCell = null;
          
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
            presenter.openAddStaffForm(id_choosed, this);
        }

        private void dtGridView_Staff_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
                    reloadTable();
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
            else MyMessageBox.showBox("Please choose a staff whom you want to delete!", "Message");
        }

        public void refreshTable()
        {
            dtGridView_Staff.Rows.Clear();
        }

        public void reloadTable()
        {
            StaffPresenter presenter = new StaffPresenter(this);
            refreshTable();
            presenter.setDataGV_Fill(dtGridView_Staff);
            dtGridView_Staff.CurrentCell = null;
        }

        public void bt_Reload_Click(object sender, EventArgs e)
        {
            StaffPresenter presenter = new StaffPresenter(this);
            refreshTable();
            presenter.setDataGV_Fill(dtGridView_Staff);
            dtGridView_Staff.CurrentCell = null;
            MyMessageBox.showBox("Refreshed! This table is up-to-date.", "Message");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {


        }

       
        private void Staff_Load(object sender, EventArgs e)
        {
           
         
        }

        private void Staff_Activated(object sender, EventArgs e)
        {
            
        }

        private void Staff_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            if (AddStaff.message == 1)
            {
                reloadTable();
            }
            
                MyMessageBox.showBox(AddStaff.message.ToString());
            
        }

        private void dtGridView_Staff_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtGridView_Staff.SelectedCells.Count > 0)
            {
                int selected_index = dtGridView_Staff.SelectedCells[0].RowIndex;
                DataGridViewRow selected_row = dtGridView_Staff.Rows[selected_index];
                int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                StaffPresenter presenter = new StaffPresenter(this);
                presenter.openAddStaffForm(id_choose, this);



            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            presenter.searchDataInDataGV();
        }

        public void searchData()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<Person> list = new List<Person>();
            dtGridView_Staff.Rows.Clear();

            string querry = "Select * from PERSON where NAME like '" + txt_Search.Text + "%' or ID_PERSON like '" + txt_Search.Text + "%';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    if (Convert.ToInt32(row["ROLE"]) != 0)
                    {
                        int ID = Convert.ToInt32(row["ID_PERSON"]);
                        string USERNAME = row["USERNAME"].ToString();
                        string PASSWORD = row["PASSWORD"].ToString();
                        string NAME = row["NAME"].ToString();

                        DateTime date = Convert.ToDateTime(row["DOB"]);
                        string DOB = date.ToString("dd-MM-yyyy");

                        string SEX = row["SEX"].ToString();
                        string PHONE = row["PHONE"].ToString();
                        string ADDRESS = row["ADDRESS"].ToString();
                        int ROLE = Convert.ToInt32(row["ROLE"]);

                        Person person = new Person(ID, USERNAME, PASSWORD, NAME, DOB, SEX, PHONE, ADDRESS, ROLE);
                        list.Add(person);
                    }
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dtGridView_Staff.Rows[i].Clone();
                row.Cells[0].Value = list[i].getID();
                row.Cells[1].Value = list[i].getUSERNAME();
                row.Cells[2].Value = list[i].getPASSWORD();
                row.Cells[3].Value = list[i].getNAME();
                row.Cells[4].Value = list[i].getDOB();
                row.Cells[5].Value = list[i].getSEX();
                row.Cells[6].Value = list[i].getPHONE();
                row.Cells[7].Value = list[i].getADDRESS();
                row.Cells[8].Value = presenter.getRole(list[i].getROLE());

                dtGridView_Staff.Rows.Add(row);

            }

            myConnection.sqlcon.Close();

        }
    }
}
