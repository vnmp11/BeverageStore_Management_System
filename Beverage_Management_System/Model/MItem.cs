using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MItem
    {
        private int id;
        private string name;
        private int quantity;
        private int total_price;
        private int in_stock;
        public MItem()
        {
            this.id = 0;
            this.name = "";
            this.quantity = 0;
            this.total_price = 0;
            this.in_stock = 0;

        }
        public MItem(int ID, string NAME, int QUANTITY, int TOTAL_PRICE, int IN_STOCK)
        {
            this.id = ID;
            this.name = NAME;
            this.quantity = QUANTITY;
            this.total_price = TOTAL_PRICE;
            this.in_stock = IN_STOCK;

        }
        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }

        public string getNAME() { return this.name; }
        public void setNAME(string NAME) { this.name = NAME; }

        public int getQUANTITY() { return this.quantity; }
        public void setQUANTITY(int QUANTITY) { this.quantity = QUANTITY; }

        public int getTOTAL_PRICE() { return this.total_price; }
        public void setTOTAL_PRICE(int TOTAL_PRICE) { this.total_price = TOTAL_PRICE; }

        public int getIN_STOCK() { return this.in_stock; }
        public void setIN_STOCK(int IN_STOCK) { this.in_stock = IN_STOCK; }

    
}
}
