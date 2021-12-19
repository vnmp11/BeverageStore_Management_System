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
    public partial class TrackingNote : Form, ITrackingNote
    {
        TrackingNotePresenter presenter;
        public string search { get => txt_Search.Text; set => txt_Search.Text = value; }
        public TrackingNote()
        {
            InitializeComponent();
            presenter = new TrackingNotePresenter(this);
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
                    presenter.getDetailsTrackingNote(id_choose, fLayoutPl_Details);
                }

            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dataGV.AllowUserToAddRows = true;
            presenter.searchNote(dataGV);
            dataGV.AllowUserToAddRows = false;
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
