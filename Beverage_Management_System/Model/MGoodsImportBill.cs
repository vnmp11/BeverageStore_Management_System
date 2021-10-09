using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MGoodsImportBill
    {
        private int id;
        private int id_bartender;
        private int id_accountant;
        private int id_goods_import_form;
        private double total_price;
        private string dateCre;
        private string dateCon;
        private int status;

        public MGoodsImportBill()
        {
            this.id = 0;
            this.id_bartender = 0;
            this.id_accountant = 0;
            this.id_goods_import_form = 0;
            this.total_price = 0;
            this.dateCre = "";
            this.dateCon = "Still not have confimration date";
            this.status = 0;


        }
        public MGoodsImportBill(int ID, int ID_BARTENDER, int ID_ACCOUNTANT, int ID_GOODS_IMPORT_FORM, double TOTAL_PRICE, string DATE_CREATE)
        {
            this.id = ID;
            this.id_bartender = ID_BARTENDER;
            this.id_accountant = ID_ACCOUNTANT;
            this.id_goods_import_form = ID_GOODS_IMPORT_FORM;
            this.total_price = TOTAL_PRICE;
            this.dateCre = DATE_CREATE;
            this.dateCon = "Still not have confimration date";
            this.status = 0;

        }

        public MGoodsImportBill(int ID, int ID_BARTENDER, int ID_ACCOUNTANT, int ID_GOODS_IMPORT_FORM, double TOTAL_PRICE, string DATE_CREATE, string DATE_CON, int STATUS)
        {
            this.id = ID;
            this.id_bartender = ID_BARTENDER;
            this.id_accountant = ID_ACCOUNTANT;
            this.id_goods_import_form = ID_GOODS_IMPORT_FORM;
            this.total_price = TOTAL_PRICE;
            this.dateCre = DATE_CREATE;
            this.dateCon = DATE_CON;
            this.status = STATUS;

        }

        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }
        public int getID_BARTENDER() { return this.id_bartender; }
        public void setID_BARTENDER(int ID_BARTENDER) { this.id_bartender = ID_BARTENDER; }
        public int getID_ACCOUNTANT() { return this.id_accountant; }
        public void setID_ACCOUNTANT(int ID_ACCOUNTANT) { this.id_bartender = ID_ACCOUNTANT; }
        public int getID_GOODS_IMPORT_FORM() { return this.id_goods_import_form; }
        public void setID_GOODS_IMPORT_FORM(int ID_GOODS_IMPORT_FORM) { this.id_goods_import_form = ID_GOODS_IMPORT_FORM; }
        public int getSTATUS() { return this.status; }
        public void setSTATUS(int STATUS) { this.status = STATUS; }
        public string getDATE_CREATE() { return this.dateCre; }
        public void setDATE_CREATE(string DATE_CREATE) { this.dateCre = DATE_CREATE; }
        public string getDATE_CONFIRM() { return this.dateCon; }
        public void setDATE_CONFIRM(string DATE_CONFIRM) { this.dateCon = DATE_CONFIRM; }
        public double getTOTAL_PRICE() { return this.total_price; }
        public void setTOTAL_PRICE(double TOTAL_PRICE) { this.total_price = TOTAL_PRICE; }



    }
}
