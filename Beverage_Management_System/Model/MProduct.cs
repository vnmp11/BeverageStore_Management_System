using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MProduct
    {
        private int id;
        private int id_kind;
        private int id_goods;
        private string name;
        private double price;
        private string unit;
        private int quantity;
        private byte[] img;

        public MProduct()
        {
            this.id = 0;
            this.id_kind = 0;
            this.id_goods = 0;
            this.name = "";
            this.price = 0;
            this.unit = "";
            this.quantity = 0;
            this.img = null;

        }
        public MProduct(int ID, int ID_KIND, int ID_GOODS, string NAME, double PRICE, string UNIT, int QUANTITY, byte[] IMAGE)
        {
            this.id = ID;
            this.id_kind = ID_KIND;
            this.id_goods = ID_GOODS;
            this.name = NAME;
            this.price = PRICE;
            this.unit = UNIT;
            this.quantity = QUANTITY;
            this.img = IMAGE;


        }
        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }

        public int getID_KIND() { return this.id_kind; }
        public void setID_KIND(int ID) { this.id_kind = ID; }

        public int getID_GOODS() { return this.id_goods; }
        public void setID_GOODS(int ID) { this.id_goods = ID; }

        public string getNAME() { return this.name; }
        public void setNAME(string NAME) { this.name = NAME; }

        public double getPRICE() { return this.price; }
        public void setPRICE(double PRICE) { this.price = PRICE; }

        public string getUNIT() { return this.unit; }
        public void setUNIT(string UNIT) { this.unit = UNIT; }

        public int getQUANTITY() { return this.quantity; }
        public void setQUANTITY(int QUANTITY) { this.quantity = QUANTITY; }

        public byte[] getIMAGE() { return this.img; }
        public void setIMAGE(byte[] IMAGE) { this.img = IMAGE; }
    }
}
