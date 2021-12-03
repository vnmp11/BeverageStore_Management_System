using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beverage_Management_System.Connection;
using System.Data.SqlClient;
using Beverage_Management_System.Model;

namespace Beverage_Management_System
{
    public partial class GoodsInImportForm : Form, IImportGoods
    {
        public GoodsInImportForm()
        {
            InitializeComponent();
        }
        ImportGoodsPresenter pre;
        int idTemp;

        public GoodsInImportForm(int id)
        {
            InitializeComponent();
            pre = new ImportGoodsPresenter(this);
            pre.dataGV_Detail(DtaGridView_Goods, id);
            bt_Save.Visible = false;

        }
        public GoodsInImportForm(int id, int temp)
        {
            InitializeComponent();
            pre = new ImportGoodsPresenter(this);
            pre.dataGV_Detail(DtaGridView_Goods, id);
            idTemp = id;

        }
        private void GoodsInImportForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            int result = pre.confirm(idTemp, DtaGridView_Goods);
            if (result == 0)
            {
                MyMessageBox.showBox("Please choose at least a good before confirming", "Message");
            }
            else if (result == -1)
            {
                MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
            else if (result == 1)
            {
                MyMessageBox.showBox("Confirmed successfully!", "Message");
                this.Close();
            }

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
