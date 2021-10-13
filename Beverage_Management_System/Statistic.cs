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
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void Sale_Click(object sender, EventArgs e)
        {

        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].Points.AddXY(1, 10);
            chart1.Series["Series1"].Points.AddXY(1, 20);
            chart1.Series["Series1"].Points.AddXY(1, 30);
            chart1.Series["Series1"].Points.AddXY(1, 40);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
