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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pB_avt.Image = new Bitmap(open.FileName);
            }    
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btt_visible_Click(object sender, EventArgs e)
        {
            btt_visible.Hide();
            btt_unvisible.Show();
            txb_passRegister.UseSystemPasswordChar = true;
        }

        private void btt_unvisible_Click(object sender, EventArgs e)
        {
            btt_visible.Show();
            btt_unvisible.Hide();
            txb_passRegister.UseSystemPasswordChar = false;
        }
    }
}
