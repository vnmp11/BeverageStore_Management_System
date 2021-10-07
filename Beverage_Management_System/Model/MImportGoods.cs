using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MImportGoods
    {
        private string id;
        private string id_Person;
        private string status;
        private string dateCre;

        public MImportGoods()
        {
            this.id = "";
            this.id_Person = "";
            this.status = "";
            this.dateCre = "";
            

        }
        public MImportGoods(string ID, string ID_P, string STATUS, string DATE)
        {
            this.id = ID;
            this.id_Person = ID_P;
            this.status = STATUS;
            this.dateCre = DATE;

        }

        public string getID() { return this.id; }
        public void setID(string ID) { this.id = ID; }
        public string getID_P() { return this.id_Person; }
        public void setID_P(string ID_P) { this.id_Person = ID_P; }
        public string getSTATUS() { return this.status; }
        public void setSTATUS(string STATUS) { this.status = STATUS; }
        public string getDATE() { return this.dateCre; }
        public void setDATE(string DATE) { this.dateCre = DATE; }



    }
}
