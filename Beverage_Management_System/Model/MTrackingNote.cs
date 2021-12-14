using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MTrackingNote
    {
        private int id;
        private string bartender;
        private string date_con;
        private int id_bill;

        public MTrackingNote()
        {
            this.id = 0;
            this.bartender = "";
            this.date_con = "";
            this.id_bill = 0;
        }

        public MTrackingNote(int ID, string BARTENDER, string DATE_CON, int ID_BILL)
        {
            this.id = ID;
            this.bartender = BARTENDER;
            this.date_con = DATE_CON;
            this.id_bill = ID_BILL;
        }

        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }
        public string getBARTENDER() { return this.bartender; }
        public void setKIND(string BARTENDER) { this.bartender = BARTENDER; }
        public int getID_BILL() { return this.id_bill; }
        public void setID_BILL(int ID_BILL) { this.id_bill = ID_BILL; }
        public string getDATE_CONFIRM() { return this.date_con; }
        public void setDATE_CONFIRM(string DATE_CONFIRM) { this.date_con = DATE_CONFIRM; }
    }
}
