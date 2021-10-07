using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    
    class MDetailGoodsImport
    {
       

        

        private string id_Detail;
        private string id_Goods;
        private string name;
        private string status;
        private string quantity;
        private string id_Product;

        
        public MDetailGoodsImport()
        {
            this.id_Detail = "";
            this.id_Goods = "";
            this.name = "";
            this.status = "";
            this.quantity = "";
            this.id_Product = "";
        }

        public MDetailGoodsImport(string id_Detail, string id_Goods, string name, string status, string quantity, string id_Product)
        {
            this.id_Detail = id_Detail;
            this.id_Goods = id_Goods;
            this.name = name;
            this.status = status;
            this.quantity = quantity;
            this.id_Product = id_Product;
        }

        public string getid_Detail() { return this.id_Detail; }
        public void setid_Detail(string id_Detail) { this.id_Detail = id_Detail; }

        public string getname() { return this.name; }
        public void setname(string name) { this.name = name; }

        public string getquantity() { return this.quantity; }
        public void setquantity(string quantity) { this.quantity = quantity; }

        public string getstatus() { return this.status; }
        public void setstatus(string status) { this.status = status; }
    }
}
