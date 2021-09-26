using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MGoodsAgency
    {

        private int id;
        private string name;
        private string price;
        private string unit;
        private string quantity;
        public MGoodsAgency()
        {
            this.id = 0;
            this.name = "";
            this.price = "";
            this.unit = "";
            this.quantity = "";

        }
        public MGoodsAgency(int ID, string NAME, string PRICE, string UNIT, string QUANTITY)
        {
            this.id = ID;
            this.name = NAME;
            this.price = PRICE;
            this.unit = UNIT;
            this.quantity = QUANTITY;

        }
        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }

        public string getNAME() { return this.name; }
        public void setNAME(string NAME) { this.name = NAME; }

        public string getPRICE() { return this.price; }
        public void setPRICE(string PRICE) { this.price = PRICE; }

        public string getUNIT() { return this.unit; }
        public void setUNIT(string UNIT) { this.unit = UNIT; }

        public string getQUANTITY() { return this.quantity; }
        public void setQUANTITY(string QUANTITY) { this.quantity = QUANTITY; }

    }


}

