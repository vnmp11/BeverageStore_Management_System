using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MAgency
    {

        private int id;
        private string name;
        private string address;
        private string phone;
        private string item;
        public MAgency()
        {
            this.id = 0;
            this.name = "";
            this.address = "";
            this.phone = "";
            this.item = "";

        }
        public MAgency(int ID, string NAME, string ADDRESS, string PHONE, string ITEM)
        {
            this.id = ID;
            this.name = NAME;
            this.address = ADDRESS;
            this.phone = PHONE;
            this.item = ITEM;

        }
        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }

        public string getNAME() { return this.name; }
        public void setNAME(string NAME) { this.name = NAME; }

        public string getADDRESS() { return this.address; }
        public void setADDRESS(string ADDRESS) { this.address = ADDRESS; }

        public string getPHONE() { return this.phone; }
        public void setPHONE(string PHONE) { this.phone = PHONE; }

        public string getITEM() { return this.item; }
        public void setITEM(string ITEM) { this.item = ITEM; }

    }
}
