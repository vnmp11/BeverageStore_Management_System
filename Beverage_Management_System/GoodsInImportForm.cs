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
            List<MDetailsGoodsImportBill> list_detailsImportBill = new List<MDetailsGoodsImportBill>();
            double bill_totalPrice = 0;
            bool sign = false;
            int id_bartender = 0;
            int id_goods_import_form = 0;

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            for (int i = 0; i < DtaGridView_Goods.RowCount -1; i++)
            {               
                int id1= Convert.ToInt32(DtaGridView_Goods.Rows[i].Cells["ID"].Value);

                SqlCommand cmd = new SqlCommand("Update DETAIL_GOODS_IMPORT_FORM set STATUS=@status where ID_DETAIL_GOODS_IMPORT_FORM=@idForm;", myConnection.sqlcon);

                if (Convert.ToBoolean(DtaGridView_Goods.Rows[i].Cells["STATUS"].Value) == true)
                {
                    cmd.Parameters.AddWithValue("@status", 1);
                    sign = true;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@status", 0);
                    sign = false;
                }
                cmd.Parameters.AddWithValue("@idForm", id1);

                int result = cmd.ExecuteNonQuery();
                if (result > 0) {
                    if (sign == true)
                    {
                        string querry = "Select G.ID_GOODS, D.QUANTITY, G.PRICE, GI.ID_PERSON, GI.ID_GOODS_IMPORT_FORM from " +
                            "((DETAIL_GOODS_IMPORT_FORM D join PRODUCT P on D.ID_PRODUCT = P.ID_PRODUCT) join " +
                            "GOODS G on P.ID_GOODS = G.ID_GOODS) join " +
                            "GOODS_IMPORT_FORM GI on D.ID_GOODS_IMPORT_FORM = GI.ID_GOODS_IMPORT_FORM where D.ID_DETAIL_GOODS_IMPORT_FORM ='" + id1 + "'; ";
                        SqlCommand sqlCommand = new SqlCommand(querry, myConnection.sqlcon);
                        SqlDataReader dr = sqlCommand.ExecuteReader();
                        if(dr.Read())
                        {
                            int id_goods = Convert.ToInt32(dr["ID_GOODS"]);
                            int quantity = Convert.ToInt32(dr["QUANTITY"]);
                            double price = Convert.ToDouble(dr["PRICE"]);
                            double total_price = price * quantity;
                            id_bartender = Convert.ToInt32(dr["ID_PERSON"]);
                            id_goods_import_form = Convert.ToInt32(dr["ID_GOODS_IMPORT_FORM"]);
                            MDetailsGoodsImportBill details_GIB = new MDetailsGoodsImportBill(0, 0, id_goods, quantity, total_price);
                            list_detailsImportBill.Add(details_GIB);
                            dr.Close();
                        }
                    }
                } 
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
               
            }

            SqlCommand cmd1 = new SqlCommand("Update GOODS_IMPORT_FORM set STATUS=1 where ID_GOODS_IMPORT_FORM=@id;", myConnection.sqlcon);
            cmd1.Parameters.AddWithValue("@id", idTemp);
            int result1 = cmd1.ExecuteNonQuery();
            if (result1 > 0) {

                string date_create = DateTime.Now.ToString("yyyy-MM-dd");

                for (int i = 0; i < list_detailsImportBill.Count(); i++)
                {
                    bill_totalPrice += list_detailsImportBill[i].getTOTAL_PRICE();
                }

                SqlCommand cmd2 = new SqlCommand("INSERT INTO GOODS_IMPORT_BILL (ID_BARTENDER, ID_ACCOUNTANT, ID_GOODS_IMPORT_FORM, TOTAL_PRICE, DATE_CRE, STATUS) VALUES(@id_bartender, @id_accountant, @id_goods_import_form, @total_price, @date_cre, @status);", myConnection.sqlcon);
                cmd2.Parameters.AddWithValue("@id_bartender", id_bartender);
                cmd2.Parameters.AddWithValue("@id_accountant", 4);
                cmd2.Parameters.AddWithValue("@id_goods_import_form", id_goods_import_form);
                cmd2.Parameters.AddWithValue("@total_price", bill_totalPrice);
                cmd2.Parameters.AddWithValue("@date_cre", date_create);
                cmd2.Parameters.AddWithValue("@status", 0);

                int result2 = cmd2.ExecuteNonQuery();
                if (result2 > 0)
                {
                    string query3 = "Select MAX(ID_GOODS_IMPORT_BILL) as MAX from GOODS_IMPORT_BILL;";
                    SqlCommand cmd3 = new SqlCommand(query3, myConnection.sqlcon);
                    SqlDataReader dr = cmd3.ExecuteReader();
                    if (dr.Read())
                    {
                        int id_goods_import_bill = Convert.ToInt32(dr["MAX"]);
                        dr.Close();
                        for (int i = 0; i < list_detailsImportBill.Count(); i++)
                        {
                            list_detailsImportBill[i].setID_GOODS_IMPORT_BILL(id_goods_import_bill);
                            SqlCommand cmd4 = new SqlCommand("INSERT INTO DETAILS_GOODS_IMPORT_BILL (ID_GOODS_IMPORT_BILL, ID_GOODS, QUANTITY, TOTAL_PRICE) " +
                                "VALUES(@id_gib, @id_goods, @quantity, @total_price);", myConnection.sqlcon);
                            cmd4.Parameters.AddWithValue("@id_gib", list_detailsImportBill[i].getID_GOODS_IMPORT_BILL());
                            cmd4.Parameters.AddWithValue("@id_goods", list_detailsImportBill[i].getID_GOODS());
                            cmd4.Parameters.AddWithValue("@quantity", list_detailsImportBill[i].getQUANTITY());
                            cmd4.Parameters.AddWithValue("@total_price", list_detailsImportBill[i].getTOTAL_PRICE());

                            int result4 = cmd4.ExecuteNonQuery();
                            if(result4 > 0) { }
                            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");

                        }
                    }
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            }
            else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
            myConnection.sqlcon.Close();
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
