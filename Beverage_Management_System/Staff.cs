﻿using System;
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

        public string search { get => txt_Search.Text; set => txt_Search.Text = value; }

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
                AlertDialog dialog = new AlertDialog();
                dialog.setMessage("Do you want to delete this staff?");
                dialog.Show();
                dialog.btt_ok.Click += (s, a) =>
                {
                    int selected_index = dtGridView_Staff.SelectedCells[0].RowIndex;
                    DataGridViewRow selected_row = dtGridView_Staff.Rows[selected_index];
                    int id_choose = Convert.ToInt32(selected_row.Cells["ID"].Value);

                    StaffPresenter presenter = new StaffPresenter(this);
                    if (presenter.deleteStaff(id_choose) > 0)
                    {
                        refreshTable();
                        presenter.setDataGV_Fill(dtGridView_Staff);
                        dtGridView_Staff.CurrentCell = null;
                        MyMessageBox.showBox("Delete this staff successfully!", "Message");
                        reloadTable();
                    }
                    else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
                };



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
            presenter.searchData(dtGridView_Staff);
        }

    }
}

