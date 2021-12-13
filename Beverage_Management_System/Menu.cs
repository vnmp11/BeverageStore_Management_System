using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        Print printBill;
        public Menu(int id_person)
        {
            InitializeComponent();

            idperson = id_person;
            showDataCBbox();
            txb_IdOrder.Text = p.show_id();
            p.showItemOrder(txb_IdOrder.Text, pl_Order);
        }

        public void showTotal()
        {
            int qty = 0;
            int total = 0;

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

        private void label3_Click(object sender, EventArgs e)
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

        private void btt_Pay_Click(object sender, EventArgs e)
        {
            printBill = new Print();
            printBill.Show();

            ProductPresenter pre = new ProductPresenter();

            printBill.btt_yes.Click += (s, a) =>
            {
                p.printMenu(txb_IdOrder.Text);
                
               
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();

                }
                printBill.Close();
                o.updateTotalOrderForm(int.Parse(txb_IdOrder.Text), int.Parse(lb_total.Text.Replace(",", "")), int.Parse(lb_QtyItem.Text));
                MyMessageBox.showBox("Created Order No." + txb_IdOrder.Text);
                o.addDetailsTrackingNote(o.getID_ORDER_FORM(), o.getID_TRACKING_NOTE());
                p.addOrderForm(idperson);
                txb_IdOrder.Text = p.show_id();
                reloadFlowLayout();

                
            };
            printBill.btt_no.Click += (s, a) =>
            {
                printBill.Close();
                o.updateTotalOrderForm(int.Parse(txb_IdOrder.Text), int.Parse(lb_total.Text.Replace(",", "")), int.Parse(lb_QtyItem.Text));
                MyMessageBox.showBox("Created Order No." + txb_IdOrder.Text);
                o.addDetailsTrackingNote(o.getID_ORDER_FORM(), o.getID_TRACKING_NOTE());
                p.addOrderForm(idperson);
                txb_IdOrder.Text = p.show_id();
                reloadFlowLayout();
            };
           





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

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        //btt print
        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var fnt = new Font("Times new Roman", 14, FontStyle.Bold);
            var fnt1 = new Font("Times new Roman", 14, FontStyle.Regular);
            int x = 200, y = 200;
            int dy = (int)fnt.GetHeight(e.Graphics) * 1;

            e.Graphics.DrawString("ORDER BILL", new Font("Times new Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(350, 50));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToString(), fnt, Brushes.Black, new PointF(200, 90));
            e.Graphics.DrawString("Waiter: "+ idperson.ToString(), fnt, Brushes.Black, new PointF(200, 90 + dy));
            e.Graphics.DrawString("NUMBER ORDER: "+txb_IdOrder.Text, fnt, Brushes.Black, new PointF(200, 90 + dy+dy));

            e.Graphics.DrawString("Name", fnt, Brushes.Black, new PointF(200, 170));
            e.Graphics.DrawString("Price", fnt, Brushes.Black, new PointF(400, 170));
            e.Graphics.DrawString("Quantity", fnt, Brushes.Black, new PointF(500, 170));
            e.Graphics.DrawString("Total", fnt, Brushes.Black, new PointF(600, 170));

            for (int i = 0; i < p.listitemPrint.Count(); i++)
            {
                e.Graphics.DrawString(p.listitemPrint[i].LabelName, fnt1, Brushes.Black, new PointF(200, y));
               // 
                e.Graphics.DrawString(p.listitemPrint[i].LabelPrice, fnt1, Brushes.Black, new PointF(400, y));
                
                e.Graphics.DrawString(p.listitemPrint[i].NumberRicQuantity, fnt1, Brushes.Black, new PointF(500, y));
              
                e.Graphics.DrawString(p.listitemPrint[i].LabelTotal_Price, fnt1, Brushes.Black, new PointF(600, y));
                y += dy;
            }

            e.Graphics.DrawString("------------------------------------------------------------------------", fnt, Brushes.Black, new PointF(200, y += dy));



            e.Graphics.DrawString("Sub total: " + lb_subTotal.Text, fnt, Brushes.Black, new PointF(x, y += dy));
            y += dy;
            e.Graphics.DrawString("Tax: " + lb_Tax.Text, fnt, Brushes.Black, new PointF(x, y));
            y += dy;
            e.Graphics.DrawString("Total Payable: " + lb_total.Text, fnt, Brushes.Black, new PointF(x, y));
            y += dy;
            e.Graphics.DrawString("Items Quantity: " + lb_QtyItem.Text, fnt, Brushes.Black, new PointF(x, y));
            y += dy;
            e.Graphics.DrawString("Thanks and see you next time!" , fnt, Brushes.Black, new PointF(320, y += dy));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
