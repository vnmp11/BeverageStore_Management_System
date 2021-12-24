using Beverage_Management_System.Connection;
using Beverage_Management_System.Model;
using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System.Presenters
{
    class InventoryPresenter
    {
        IAddProduct addProductView;
        IInventory inventoryView;

        List<MProduct> list_product = new List<MProduct>();
        List<KindOfProduct> list_kind = new List<KindOfProduct>();
        List<MAgency> list_Agency = new List<MAgency>();
        List<MGoodsAgency> list_Goods = new List<MGoodsAgency>();
        List<string> list = new List<string>();

        int selected_productID = 0;

        public InventoryPresenter(IAddProduct view)
        {
            addProductView = view;
        }

        public InventoryPresenter(IInventory view)
        {
            inventoryView = view;
        }

        public void fillDataInCombobox(Guna.UI2.WinForms.Guna2ComboBox cb_KindOfProduct,
            Guna.UI2.WinForms.Guna2ComboBox cb_Unit, Guna.UI2.WinForms.Guna2ComboBox cb_Goods)
        {
            fillDataInComboBox_KindOfProduct(cb_KindOfProduct);
            fillDataInComboBox_Unit(cb_Unit);
            fillDataInComboBox_Goods(cb_Goods);
        }


        public byte[] convertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public int handle_AddProduct(int id,
            Guna.UI2.WinForms.Guna2ComboBox cb_Goods, Guna.UI2.WinForms.Guna2ComboBox cb_KindOfProduct,
            Guna.UI2.WinForms.Guna2ComboBox cb_Unit, Guna.UI2.WinForms.Guna2CirclePictureBox pB_Product,
            Image default_img)
        {
            selected_productID = id;
            if (addProductView.name.ToString().Trim() != "" && addProductView.price.ToString().Trim() != "" && addProductView.quantity.ToString().Trim() != ""
                && cb_Goods.SelectedIndex > -1 && cb_KindOfProduct.SelectedIndex > -1 && cb_Unit.SelectedIndex > -1)
            {
                byte[] picture = convertImageToBytes(default_img);
                byte[] img = convertImageToBytes(pB_Product.Image);
                if (picture.SequenceEqual(img) == true)
                {
                    MyMessageBox.showBox("Please upload the product's image!", "Message");
                    return 0;
                }
                else
                {
                    int index_cb_Goods = cb_Goods.SelectedIndex;
                    int id_goods = list_Goods[index_cb_Goods].getID();
                    int id_kind = cb_KindOfProduct.SelectedIndex + 1;
                    string name = addProductView.name;
                    double price = Double.Parse(addProductView.price);
                    string unit = cb_Unit.SelectedItem.ToString();
                    int quantity = Int32.Parse(addProductView.quantity);
                    MProduct product = new MProduct(selected_productID, id_kind, id_goods, name, price, unit, quantity, img);
                    int result = addProduct(product, cb_Goods,
                        cb_KindOfProduct, cb_Unit, pB_Product, default_img);
                    if (result > 0) return result;
                    else return -1;
                }

            }
            else
            {
                MyMessageBox.showBox("Please fill in the product's information completely!", "Message");
                return -1;
            }
        }
        public int addProduct(MProduct product,
            Guna.UI2.WinForms.Guna2ComboBox cb_Goods, Guna.UI2.WinForms.Guna2ComboBox cb_KindOfProduct,
            Guna.UI2.WinForms.Guna2ComboBox cb_Unit, Guna.UI2.WinForms.Guna2CirclePictureBox pB_Product,
            Image default_img)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();
            if (product.getID() > 0)
            {
                SqlCommand cmd = new SqlCommand("Update PRODUCT set ID_KIND=@id_kind, ID_GOODS=@id_goods, NAME=@name, " +
                    "PRICE=@price, UNIT=@unit, QUANTITY=@quantity, IMAGE=@image where ID_PRODUCT=@id;",
                    myConnection.sqlcon);
                cmd.Parameters.AddWithValue("@id_kind", product.getID_KIND());
                cmd.Parameters.AddWithValue("@id_goods", product.getID_GOODS());
                cmd.Parameters.AddWithValue("@name", product.getNAME());
                cmd.Parameters.AddWithValue("@price", product.getPRICE());
                cmd.Parameters.AddWithValue("@unit", product.getUNIT());
                cmd.Parameters.AddWithValue("@quantity", product.getQUANTITY());
                cmd.Parameters.AddWithValue("@image", product.getIMAGE());
                cmd.Parameters.AddWithValue("@id", product.getID());

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    myConnection.sqlcon.Close();
                    MyMessageBox.showBox("Update product's information successfully!", "Message");
                    return 2;

                }
                else
                {
                    myConnection.sqlcon.Close();
                    MyMessageBox.showBox("Failed! Please check your networking.", "Message");
                    return -1;
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into PRODUCT(ID_KIND,ID_GOODS,NAME,PRICE,UNIT,QUANTITY,IMAGE) " +
                    "values (@id_kind,@id_goods,@name,@price,@unit,@quantity,@image);",
                    myConnection.sqlcon);
                cmd.Parameters.AddWithValue("@id_kind", product.getID_KIND());
                cmd.Parameters.AddWithValue("@id_goods", product.getID_GOODS());
                cmd.Parameters.AddWithValue("@name", product.getNAME());
                cmd.Parameters.AddWithValue("@price", product.getPRICE());
                cmd.Parameters.AddWithValue("@unit", product.getUNIT());
                cmd.Parameters.AddWithValue("@quantity", product.getQUANTITY());
                cmd.Parameters.AddWithValue("@image", product.getIMAGE());

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    myConnection.sqlcon.Close();
                    MyMessageBox.showBox("Add product's information successfully!", "Message");
                    return 1;
                }
                else
                {
                    myConnection.sqlcon.Close();
                    MyMessageBox.showBox("Failed! Please check your networking.", "Message");
                    return -1;
                }

            }
        }

        public void fillDataInComboBox_KindOfProduct(Guna.UI2.WinForms.Guna2ComboBox cb_KindOfProduct)
        {
            getListOfKind();
            for (int i = 0; i < list_kind.Count(); i++)
            {
                cb_KindOfProduct.Items.Add(list_kind[i].getNAME());
            }
            if(cb_KindOfProduct.Items.Count > 0) cb_KindOfProduct.SelectedIndex = 0;
        }

        public void fillDataInComboBox_Unit(Guna.UI2.WinForms.Guna2ComboBox cb_Unit)
        {
            List<string> list = new List<string>();
            list.Add("Bottle");
            list.Add("Can");

            for (int i = 0; i < list.Count(); i++)
            {
                cb_Unit.Items.Add(list[i]);
            }

            if(cb_Unit.Items.Count > 0) cb_Unit.SelectedIndex = 0;
        }

        public void fillDataInComboBox_Goods(Guna.UI2.WinForms.Guna2ComboBox cb_Goods)
        {
            getListOfAgency();
            for (int i = 0; i < list.Count(); i++)
            {
                cb_Goods.Items.Add(list[i]);
            }
            if (list.Count > 0) cb_Goods.SelectedIndex = 0;
        }

        public void getListOfKind()
        {
            list_kind = new List<KindOfProduct>();
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string querry = "Select * from KIND;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_KIND"]);
                    string NAME = row["NAME"].ToString();


                    KindOfProduct kind = new KindOfProduct(ID, NAME);
                    list_kind.Add(kind);
                }

            }
            myConnection.sqlcon.Close();
        }

        public string getKind(int ID)
        {
            String name = "";
            for (int i = 0; i < list_kind.Count(); i++)
            {
                if (list_kind[i].getID() == ID) name = list_kind[i].getNAME();
            }
            return name;
        }

        public void getListOfAgency()
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

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

            string query2 = "SELECT * FROM GOODS WHERE ID_GOODS NOT IN (SELECT ID_GOODS FROM PRODUCT);";
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

                    for (int i = 0; i < list_Agency.Count; i++)
                    {
                        if (list_Agency[i].getID() == ID_SUPLLIER) NAME_SUPPLIER = list_Agency[i].getNAME();
                    }

                    string items = NAME_SUPPLIER + " - " + goods.getNAME();
                    list.Add(items);

                }
            }

            myConnection.sqlcon.Close();
        }

        public string getGoods(int id_product)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            string name = "";
            string goods = "";
            string supplier = "";

            string query1 = "Select S.NAME AS SNAME, G.NAME AS GNAME from " +
                "SUPPLIER S JOIN GOODS G ON S.ID_SUPPLIER = G.ID_SUPPLIER JOIN PRODUCT P ON " +
                "G.ID_GOODS = P.ID_GOODS WHERE P.ID_PRODUCT = '" + id_product + "';";
            SqlCommand cmd1 = new SqlCommand(query1, myConnection.sqlcon);

            using (SqlDataReader sdr1 = cmd1.ExecuteReader())
            {
                while (sdr1.Read())
                {
                    supplier = sdr1.GetString(0);
                    goods = sdr1.GetString(1);
                }
            }
            
            myConnection.sqlcon.Close();
            name = supplier + " - " + goods;
            return name;
        }

        public void setDataGV(Guna.UI2.WinForms.Guna2DataGridView dataGV)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            list_product = new List<MProduct>();

            DataTable dt = new DataTable();
            string querry = "Select ID_PRODUCT, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY from PRODUCT;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_PRODUCT"]);
                    int ID_KIND = Convert.ToInt32(row["ID_KIND"]);
                    int ID_GOODS = Convert.ToInt32(row["ID_GOODS"]);
                    string NAME = row["NAME"].ToString();
                    double PRICE = Convert.ToDouble(row["PRICE"]);
                    string UNIT = row["UNIT"].ToString();
                    int QUANTITY = Convert.ToInt32(row["QUANTITY"]);
                    byte[] IMAGE = null;

                    MProduct product = new MProduct(ID, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY, IMAGE);
                    list_product.Add(product);
                }

            }

            for (int i = 0; i < list_product.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list_product[i].getID();
                row.Cells[1].Value = getKind(list_product[i].getID_KIND());
                row.Cells[2].Value = list_product[i].getID_GOODS();
                row.Cells[3].Value = list_product[i].getNAME();
                row.Cells[4].Value = list_product[i].getPRICE().ToString("###,###,##0");
                row.Cells[5].Value = list_product[i].getUNIT();
                row.Cells[6].Value = list_product[i].getQUANTITY();

                dataGV.Rows.Add(row);

            }

            myConnection.sqlcon.Close();
        }

        public void openAddProductForm(int id_choosed, Inventory parent)
        {
            AddProduct form = new AddProduct(id_choosed, parent);
            form.Owner = parent;
            form.ShowDialog();
        }

        public void setInformation(int id, Guna.UI2.WinForms.Guna2TextBox txt_Name,
            Guna.UI2.WinForms.Guna2TextBox txt_Quantity, Guna.UI2.WinForms.Guna2TextBox txt_Price,
            Guna.UI2.WinForms.Guna2CirclePictureBox pB_Product, Guna.UI2.WinForms.Guna2ComboBox cb_KindOfProduct,
            Guna.UI2.WinForms.Guna2ComboBox cb_Unit, Guna.UI2.WinForms.Guna2ComboBox cb_Goods)
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
                    pB_Product.Image = ConvertByteArrayToImage(img);
                    int index_kind = Convert.ToInt32(row["ID_KIND"]) - 1;
                    cb_KindOfProduct.SelectedIndex = index_kind;
                    int id_goods = Convert.ToInt32(row["ID_GOODS"]);
                    int index_goods = 0;
                    for (int i = 0; i < list_Goods.Count(); i++)
                    {
                        if (list_Goods[i].getID() == id_goods) index_goods = i;
                    }
                    if(cb_Goods.Items.Count < index_goods || cb_Goods.Items.Count == 0)
                    {
                        cb_Goods.Items.Add(getGoods(id));
                        cb_Goods.SelectedIndex = cb_Goods.Items.Count - 1;
                        MGoodsAgency goods = new MGoodsAgency(id_goods, "", "", "", "");
                        list_Goods.Add(goods);
                    }
                    string unit = row["UNIT"].ToString();
                    if (unit.Trim() == "Bottle") cb_Unit.SelectedIndex = 0;
                    else cb_Unit.SelectedIndex = 1;

                }

            }
            myConnection.sqlcon.Close();
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        public int deleteProduct(int id)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            bool sign = false;
            int iCount = 0;

            SqlCommand cmd1 = new SqlCommand("SELECT P.ID_PRODUCT FROM (PRODUCT P JOIN GOODS G ON P.ID_GOODS = G.ID_GOODS) WHERE " +
                "(P.ID_PRODUCT = '" + id + "' AND P.ID_PRODUCT IN (SELECT ID_PRODUCT FROM DETAIL_GOODS_IMPORT_FORM)) OR " +
                "(P.ID_PRODUCT = '" + id + "' AND G.ID_GOODS IN (SELECT ID_GOODS FROM DETAILS_GOODS_IMPORT_BILL)) OR " +
                "(P.ID_PRODUCT = '" + id + "' AND P.ID_PRODUCT IN (SELECT ID_PRODUCT FROM DETAILS_ORDERFORM))", myConnection.sqlcon);
            object oCount = cmd1.ExecuteScalar();
            if (oCount != null) sign = true;
            else sign = false;

            if (sign == true)
            {
                myConnection.sqlcon.Close();
                return 0;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Delete from PRODUCT where ID_PRODUCT=@id;", myConnection.sqlcon);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    myConnection.sqlcon.Close();
                    return 1;
                }
                else
                {
                    myConnection.sqlcon.Close();
                    return -1;
                }
            }

        }

        public void searchData(Guna.UI2.WinForms.Guna2DataGridView dataGV)
        {
            MyConnection myConnection = new MyConnection();
            myConnection.sqlcon.Open();

            list_product = new List<MProduct>();
            dataGV.Rows.Clear();

            DataTable dt = new DataTable();
            string querry = "Select ID_PRODUCT, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY from PRODUCT where NAME like '" + inventoryView.search + "%'" +
                "or ID_PRODUCT like '" + inventoryView.search + "%';";
            SqlDataAdapter sda = new SqlDataAdapter(querry, myConnection.sqlcon);
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int ID = Convert.ToInt32(row["ID_PRODUCT"]);
                    int ID_KIND = Convert.ToInt32(row["ID_KIND"]);
                    int ID_GOODS = Convert.ToInt32(row["ID_GOODS"]);
                    string NAME = row["NAME"].ToString();
                    double PRICE = Convert.ToDouble(row["PRICE"]);
                    string UNIT = row["UNIT"].ToString();
                    int QUANTITY = Convert.ToInt32(row["QUANTITY"]);
                    byte[] IMAGE = null;


                    MProduct product = new MProduct(ID, ID_KIND, ID_GOODS, NAME, PRICE, UNIT, QUANTITY, IMAGE);
                    list_product.Add(product);
                }

            }

            for (int i = 0; i < list_product.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGV.Rows[i].Clone();
                row.Cells[0].Value = list_product[i].getID();
                row.Cells[1].Value = getKind(list_product[i].getID_KIND());
                row.Cells[2].Value = list_product[i].getID_GOODS();
                row.Cells[3].Value = list_product[i].getNAME();
                row.Cells[4].Value = list_product[i].getPRICE().ToString("###,###,##0");
                row.Cells[5].Value = list_product[i].getUNIT();
                row.Cells[6].Value = list_product[i].getQUANTITY();

                dataGV.Rows.Add(row);

            }

            myConnection.sqlcon.Close();
        }
        public void refreshForm(Guna.UI2.WinForms.Guna2TextBox txt_Name,
            Guna.UI2.WinForms.Guna2TextBox txt_Price, Guna.UI2.WinForms.Guna2TextBox txt_Quantity,
            Guna.UI2.WinForms.Guna2ComboBox cb_Goods, Guna.UI2.WinForms.Guna2ComboBox cb_KindOfProduct,
            Guna.UI2.WinForms.Guna2ComboBox cb_Unit, Guna.UI2.WinForms.Guna2CirclePictureBox pB_Product,
            Image default_img)
        {
            selected_productID = 0;
            txt_Name.Text = "";
            txt_Price.Text = "";
            txt_Quantity.Text = "";
            if (cb_Goods.Items.Count > 0) cb_Goods.SelectedIndex = 0;
            if(cb_KindOfProduct.Items.Count > 0) cb_KindOfProduct.SelectedIndex = 0;
            if(cb_Unit.Items.Count > 0) cb_Unit.SelectedIndex = 0;
            pB_Product.Image = default_img;
        }

    }


}
