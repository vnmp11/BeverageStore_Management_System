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
    public partial class AddProduct : Form, IAddProduct
    {
        List<MGoodsAgency> list_Goods = new List<MGoodsAgency>();
        List<MAgency> list_Agency = new List<MAgency>();
        List<KindOfProduct> list_Kinds = new List<KindOfProduct>();
        Image default_img;

        int id = 0;
        Inventory parent;

        InventoryPresenter presenter;
        public AddProduct(Inventory form)
        {
            InitializeComponent();
            this.parent = form;
            default_img = pB_Product.Image;
            presenter = new InventoryPresenter(this);
            presenter.fillDataInCombobox();

        }

        public AddProduct(int ID, Inventory form)
        {
            InitializeComponent();
            this.parent = form;
            id = ID;
            default_img = pB_Product.Image;
            presenter = new InventoryPresenter(this);
            presenter.fillDataInCombobox();
            presenter.setInformation();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pB_Product.Image = new Bitmap(open.FileName);
            }
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        //Overried methods in interface
        public void fillDataInComboBox_KindOfProduct()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string query = "Select * from KIND;";
            SqlCommand cmd = new SqlCommand(query, myConnection.sqlcon);

            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    int ID = sdr.GetInt32(0);
                    string NAME = sdr.GetString(1);
                    KindOfProduct kind = new KindOfProduct(ID, NAME);
                    list_Kinds.Add(kind);
                }
            }

            myConnection.sqlcon.Close();

            for (int i = 0; i < list_Kinds.Count(); i++)
            {
                cb_KindOfProduct.Items.Add(list_Kinds[i].getNAME());
            }
            cb_KindOfProduct.SelectedIndex = 0;
        }

        public void fillDataInComboBox_Unit()
        {
            List<string> list = new List<string> ();
            list.Add("Bottle");
            list.Add("Can");

            for(int i = 0; i < list.Count(); i++)
            {
                cb_Unit.Items.Add(list[i]);
            }

            cb_Unit.SelectedIndex = 0;
        }

        public void fillDataInComboBox_Goods()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            List<string> list = new List<string>();

            string query1 = "Select * from SUPPLIER;";
            SqlCommand cmd1 = new SqlCommand(query1, myConnection.sqlcon);

            using (SqlDataReader sdr1 = cmd1.ExecuteReader())
            {
                while (sdr1.Read())
                {
                    int ID = sdr1.GetInt32(0);
                    string NAME = sdr1.GetString(1);
                    MAgency agency = new MAgency(ID, NAME, "", "", "");
                    list_Agency.Add(agency);
                }
            }

            string query2 = "Select * from GOODS;";
            SqlCommand cmd2 = new SqlCommand(query2, myConnection.sqlcon);

            using (SqlDataReader sdr2 = cmd2.ExecuteReader())
            {
                while (sdr2.Read())
                {
                    int ID = sdr2.GetInt32(0);
                    string NAME = sdr2.GetString(1);
                    int ID_SUPLLIER = sdr2.GetInt32(5);
                    string NAME_SUPPLIER = "";

                    MGoodsAgency goods = new MGoodsAgency(ID, NAME, "", "", "");
                    list_Goods.Add(goods);

                    for(int i = 0; i < list_Agency.Count; i++)
                    {
                        if (list_Agency[i].getID() == ID_SUPLLIER) NAME_SUPPLIER = list_Agency[i].getNAME();
                    }

                    string items = NAME_SUPPLIER + " - " + goods.getNAME();
                    list.Add(items);

                }
            }

            myConnection.sqlcon.Close();

            for (int i = 0; i < list.Count(); i++)
            {
                cb_Goods.Items.Add(list[i]);
            }

            cb_Goods.SelectedIndex = 0;
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.ToString().Trim() != "" && txt_Quantity.Text.ToString().Trim() != "" && txt_Price.Text.ToString().Trim() != "" 
                && cb_Goods.SelectedIndex > -1 && cb_KindOfProduct.SelectedIndex > -1 && cb_Unit.SelectedIndex > -1)
            {
                byte[] picture = presenter.convertImageToBytes(default_img);
                byte[] img = presenter.convertImageToBytes(pB_Product.Image);
                if(picture.SequenceEqual(img) == true)
                {
                    MyMessageBox.showBox("Please upload the product's image!", "Message");
                }
                else
                {
                    int index_cb_Goods = cb_Goods.SelectedIndex;
                    int id_goods = list_Goods[index_cb_Goods].getID();
                    int id_kind = cb_KindOfProduct.SelectedIndex + 1;
                    string name = txt_Name.Text;
                    double price = Double.Parse(txt_Price.Text);
                    string unit = cb_Unit.SelectedItem.ToString();
                    int quantity = Int32.Parse(txt_Quantity.Text);
                    MProduct product = new MProduct(id, id_kind, id_goods, name, price, unit, quantity, img);
                    presenter.addProduct(product);
                    parent.refreshDataGV();
                }
               
            }
            else MyMessageBox.showBox("Please fill in the product's information completely or check whether the items are selected in comboboxes!", "Message");
        }

        public void refreshForm()
        {
            id = 0;
            txt_Name.Text = "";
            txt_Price.Text = "";
            txt_Quantity.Text = "";
            cb_Goods.SelectedIndex = 0;
            cb_KindOfProduct.SelectedIndex = 0;
            cb_Unit.SelectedIndex = 0;
            pB_Product.Image = default_img;
        }

        public void setInformation()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            string querry = "Select * from PRODUCT where ID_PRODUCT = '" + id + "';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    txt_Name.Text = row["NAME"].ToString();
                    txt_Quantity.Text = row["QUANTITY"].ToString();
                    txt_Price.Text = row["PRICE"].ToString();
                    byte[] img = (byte[])row["IMAGE"];
                    pB_Product.Image = presenter.ConvertByteArrayToImage(img);
                    int index_kind = Convert.ToInt32(row["ID_KIND"]) - 1;
                    cb_KindOfProduct.SelectedIndex = index_kind;
                    int id_goods = Convert.ToInt32(row["ID_GOODS"]);
                    int index_goods = 0;
                    for(int i = 0; i < list_Goods.Count(); i++)
                    {
                        if (list_Goods[i].getID() == id_goods) index_goods = i;
                    }
                    cb_Goods.SelectedIndex = index_goods;
                    string unit = row["UNIT"].ToString();
                    if (unit.Trim() == "Bottle") cb_Unit.SelectedIndex = 0;
                    else cb_Unit.SelectedIndex = 1;
                    
                }

            }
            myConnection.sqlcon.Close();
        }

        private void cb_KindOfProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
