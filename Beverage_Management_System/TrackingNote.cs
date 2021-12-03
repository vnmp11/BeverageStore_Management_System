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
            dataGV.CurrentCell.Selected = false;
        }

        private void dataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fLayoutPl_Details.Visible = true;
            if (e.RowIndex < dataGV.RowCount - 1)
            {
                int id_bill = int.Parse(dataGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                presenter.getDetailsTrackingNote(id_bill, fLayoutPl_Details);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            presenter.searchNote(dataGV);
        }
    }
}
