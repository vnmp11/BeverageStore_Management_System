using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MOrderForm
    {
        private int id;
        private int id_person;
        private int total_price;
        private int status;

        public MOrderForm()
        {
            this.id = 0;
            this.id_person = 0;
            this.total_price = 0;
            this.status = 0;
        }

        public MOrderForm(int ID, int ID_PERSON, int STATUS, int TOTAL_PRICE)
        {
            this.id = ID;
            this.id_person = ID_PERSON;
            this.status = STATUS;
            this.total_price = TOTAL_PRICE;
        }

        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }

        public int getID_PERSON() { return this.id_person; }
        public void setID_PERSON(int ID_PERSON) { this.id_person = ID_PERSON; }
        public int getSTATUS() { return this.status; }
        public void setSTATUS(int STATUS) { this.status= STATUS; }

        public int getTOTAL_PRICE() { return this.total_price; }
        public void setTOTAL_PRICE(int TOTAL_PRICE) { this.total_price = TOTAL_PRICE; }

    }
}
