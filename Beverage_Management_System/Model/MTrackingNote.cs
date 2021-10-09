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
        private int kind;
        private string date_con;
        private int id_bill;

        public MTrackingNote()
        {
            this.id = 0;
            this.kind = 0;
            this.date_con = "";
            this.id_bill = 0;
        }

        public MTrackingNote(int ID, int KIND, string DATE_CON, int ID_BILL)
        {
            this.id = ID;
            this.kind = KIND;
            this.date_con = DATE_CON;
            this.id_bill = ID_BILL;
        }

        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }
        public int getKIND() { return this.kind; }
        public void setKIND(int KIND) { this.kind = KIND; }
        public int getID_BILL() { return this.id_bill; }
        public void setID_BILL(int ID_BILL) { this.id_bill = ID_BILL; }
        public string getDATE_CONFIRM() { return this.date_con; }
        public void setDATE_CONFIRM(string DATE_CONFIRM) { this.date_con = DATE_CONFIRM; }
    }
}
