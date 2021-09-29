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

        public InventoryPresenter(IAddProduct view)
        {
            addProductView = view;
        }

        public InventoryPresenter(IInventory view)
        {
            inventoryView = view;
        }

        public void fillDataInCombobox()
        {
            addProductView.fillDataInComboBox_KindOfProduct();
            addProductView.fillDataInComboBox_Unit();
            addProductView.fillDataInComboBox_Goods();
        }


        public byte[] convertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public void addProduct(MProduct product)
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
                    addProductView.refreshForm();
                    MyMessageBox.showBox("Update product's information successfully!", "Message");

                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");
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
                    addProductView.refreshForm();
                    MyMessageBox.showBox("Add product's information successfully!", "Message");
                }
                else MyMessageBox.showBox("Failed! Please check your networking.", "Message");

            }
        }

        public List<KindOfProduct> getListOfKind()
        {
            List<KindOfProduct> list = new List<KindOfProduct>();
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
                    list.Add(kind);
                }

            }
            return list;

            myConnection.sqlcon.Close();
        }

        public string getKind(List<KindOfProduct> list, int ID)
        {
            String name = "";
            for(int i = 0; i < list.Count(); i++)
            {
                if (list[i].getID() == ID) name = list[i].getNAME();
            }
            return name;
        }

        public void setDataGV()
        {
            inventoryView.setDataGV_Fill();
        }

        public void openAddStaffForm(int id_choosed, Inventory parent)
        {

            AddProduct form = new AddProduct(id_choosed, parent);
            form.Owner = parent;
            form.ShowDialog();
        }

        public void setInformation()
        {
            addProductView.setInformation();
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
            SqlCommand cmd = new SqlCommand("Delete from PRODUCT where ID_PRODUCT=@id;", myConnection.sqlcon);
            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return 1;
            }
            else return 0;
        }

        public void searchDataInDataDV()
        {
            inventoryView.searchData();
        }

    }
}
