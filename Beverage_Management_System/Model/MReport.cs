using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MReport
    {
        private int id;
        private int id_order_form;
        private string reason;
        private string solution;
        private int fine;
        private DateTime dateTime;

        public MReport(int id, int id_order_form, string reason, string solution, int fine, DateTime dateTime)
        {
            this.id = id;
            this.id_order_form = id_order_form;
            this.reason = reason;
            this.solution = solution;
            this.fine = fine;
            this.dateTime = dateTime;
        }

        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }

        public int getID_ORDER_FORM() { return this.id_order_form; }
        public void setID_ORDER_FORM(int ID) { this.id_order_form = ID; }

        public string getREASON() { return this.reason; }
        public void setREASON(string REASON) { this.reason = REASON; }

        public string getSOLUTION() { return this.solution; }
        public void setSOLUTION(string SOLUTION) { this.solution = SOLUTION; }

        public int getFINE() { return this.fine; }
        public void setFINE(int FINE) { this.fine = FINE; }

        public DateTime getDATE() { return this.dateTime; }
        public void setDATE(DateTime DATE) { this.dateTime = DATE; }


    }
}
