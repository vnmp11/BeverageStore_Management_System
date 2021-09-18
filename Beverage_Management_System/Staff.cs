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
        public Staff()
        {
            InitializeComponent();
            StaffPresenter presenter = new StaffPresenter(this);
            presenter.setDataGV_Fill(dtGridView_Staff);

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
            AddStaff frm = new AddStaff();
            frm.ShowDialog();
        }

    }
}
