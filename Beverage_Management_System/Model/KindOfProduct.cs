using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class KindOfProduct
    {
        private int id_kind;
        private string name;

        public KindOfProduct()
        {
            this.id_kind = 0;
            this.name = "";
        }

        public KindOfProduct(int ID, string NAME)
        {
            this.id_kind = ID;
            this.name = NAME;
        }

        public int getID() { return this.id_kind; }
        public void setID(int ID) { this.id_kind = ID; }

        public string getNAME() { return this.name; }
        public void setNAME(string NAME) { this.name = NAME; }
    }
}
