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
        public GoodsInImportForm(int id,int temp)
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
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            for (int i = 0; i < DtaGridView_Goods.RowCount -1; i++)
            {               
                int id1= Convert.ToInt32(DtaGridView_Goods.Rows[i].Cells["ID"].Value);

                SqlCommand cmd = new SqlCommand("Update DETAIL_GOODS_IMPORT_FORM set STATUS=@status where ID_DETAIL_GOODS_IMPORT_FORM=@idForm;", myConnection.sqlcon);

                if (Convert.ToBoolean(DtaGridView_Goods.Rows[i].Cells["STATUS"].Value) == true)
                {
                    cmd.Parameters.AddWithValue("@status", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@status", 0);
                }
                cmd.Parameters.AddWithValue("@idForm", id1);

                int result = cmd.ExecuteNonQuery();
                if (result > 0) { } 
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }

            SqlCommand cmd1 = new SqlCommand("Update GOODS_IMPORT_FORM set STATUS=1 where ID_GOODS_IMPORT_FORM=@id;", myConnection.sqlcon);
            cmd1.Parameters.AddWithValue("@id", idTemp);
            int result1 = cmd1.ExecuteNonQuery();
            if (result1 > 0) { }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
