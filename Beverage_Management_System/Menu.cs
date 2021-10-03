using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System
{
    public partial class Menu : Form
    {
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        List<KindOfProduct> list_Kinds = new List<KindOfProduct>();
        int id_kind = 0;
        ProductPresenter p = new ProductPresenter();
        OrderFormPresenter o = new OrderFormPresenter();
        int idperson;

        public Menu(int id_person)
        {
            InitializeComponent();

            idperson = id_person;
            showDataCBbox();
            txb_IdOrder.Text = p.show_id();
            p.showItemOrder( txb_IdOrder.Text, pl_Order);
            showTotal();
            
        }

        public void showTotal()
        {
            int qty = 0;
            int total = 0;

            //for (int i = 0; i < dtGridView_Menu.RowCount - 1; i++)
            //{
            //    qty += int.Parse(dtGridView_Menu.Rows[i].Cells[3].Value.ToString());
            //    total += int.Parse(dtGridView_Menu.Rows[i].Cells[4].Value.ToString().Replace(",", ""));
            //}
            //double tax = 0.01 * total;

            //lb_QtyItem.Text = qty.ToString();
            //lb_subTotal.Text = total.ToString();
            //lb_total.Text = (tax + total).ToString();
            //lb_Tax.Text = tax.ToString();

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand("Select * from DETAILS_ORDERFORM where ID_ORDERFORM like '" + txb_IdOrder.Text + "';",
                   myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
           
                int quantity = (int)sdr["QUANTITY"];
                int total_price = (int)sdr["TOTAL_PRICE"];
                qty += quantity;
                total += total_price;
            }

            myConnection.sqlcon.Close();
            double tax = 0.01 * total;
            lb_QtyItem.Text = qty.ToString();
            lb_subTotal.Text = total.ToString();
            lb_total.Text = (tax + total).ToString();
            lb_Tax.Text = tax.ToString();
        }
        void showDataCBbox()
        {
            showProduct(id_kind);
            String query1 = "Select * from KIND;";

            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            SqlCommand cmd = new SqlCommand(query1, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                int ID = sdr.GetInt32(0);
                string NAME = sdr.GetString(1);
                KindOfProduct kind = new KindOfProduct(ID, NAME);
                list_Kinds.Add(kind);

            }

            myConnection.sqlcon.Close();
            for (int i = 0; i < list_Kinds.Count(); i++)
            {
                cb_KindofDrink.Items.Add(list_Kinds[i].getNAME());
            }

        }

        void showProduct(int kind)
        {
            String query;

            if (id_kind != 0)
            {
                query = "Select * from PRODUCT where ID_KIND like '" + id_kind + "%'" + "and NAME like '" + txb_searchMenu.Text + "%';";
            }
            else
            {
                query = "Select * from PRODUCT where NAME like '" + txb_searchMenu.Text + "%';";
            }
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
          
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                String name_product = (String)sdr["NAME"];
                int price_product = (int)sdr["PRICE"];
                int id_product = (int)sdr["ID_PRODUCT"];
                byte[] image_product = (byte[])sdr["IMAGE"];
                int qty = (int)sdr["QUANTITY"];

                //add product to flowlayoutpanel
                Product pro = new Product();
                pro.Parent = this;
                pro.p_Price = price_product;
                pro.Quantity = qty;
                pro.idProduct = id_product;
                pro.LabelProduct = name_product;
                pro.LabelPrice = price_product.ToString();

                if (qty == 0)
                {
                    pro.BackColor = Color.FromArgb(242, 156, 157);
                }

                Image x = (Bitmap)((new ImageConverter()).ConvertFrom(image_product));
                pro.ImageProduct = x;

                layoutPl_product.Controls.Add(pro);


            }
        }

        public void reloadFlowLayout()
        {

            pl_Order.Controls.Clear();
            p.showItemOrder(txb_IdOrder.Text, pl_Order);
            showTotal();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Dock = DockStyle.Fill;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            layoutPl_product.Controls.Clear();
            showProduct(id_kind);
        }

        private void cb_KindofDrink_TextChanged(object sender, EventArgs e)
        {
            id_kind = cb_KindofDrink.SelectedIndex;
            layoutPl_product.Controls.Clear();
            showProduct(id_kind);
           
        }
        private void layoutPl_product_Paint(object sender, PaintEventArgs e)
        {

        }

        private void layoutPl_product_Click(object sender, EventArgs e)
        {
            
        }

        private void dtGridView_Menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btt_Pay_Click(object sender, EventArgs e)
        {
            o.addOrderForm(int.Parse(txb_IdOrder.Text), int.Parse(lb_total.Text.Replace(",", "")));
            MyMessageBox.showBox("Successfully");
          
            p.addOrderForm(idperson);
            txb_IdOrder.Text = p.show_id();
            reloadFlowLayout();
        }

        public void btt_clearAll_Click(object sender, EventArgs e)
        {
            p.removeAll(int.Parse(txb_IdOrder.Text));
            reloadFlowLayout();
            showTotal();
        }

        private void lb_subTotal_TextChanged(object sender, EventArgs e)
        { 
            decimal value = decimal.Parse(lb_subTotal.Text, System.Globalization.NumberStyles.AllowThousands);
            lb_subTotal.Text = String.Format(culture, "{0:N0}", value);
        }

        private void lb_Tax_TextChanged(object sender, EventArgs e)
        {
            decimal value = decimal.Parse(lb_Tax.Text, System.Globalization.NumberStyles.AllowThousands);
            lb_Tax.Text = String.Format(culture, "{0:N0}", value);
        }

        private void lb_total_TextChanged(object sender, EventArgs e)
        {
            decimal value = decimal.Parse(lb_total.Text, System.Globalization.NumberStyles.AllowThousands);
            lb_total.Text = String.Format(culture, "{0:N0}", value);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
