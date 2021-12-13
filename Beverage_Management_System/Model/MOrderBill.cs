using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MOrderBill
    {
        private int id;
        private int id_order_form;
        private int id_bartender;
        private int id_accountant;
        private double total_price_products;
        private double fine;
        private string date_cre;
        private string date_con;
        private double total_price;
        private int total_quantity;
        private int status;

        public MOrderBill()
        {
            this.id = 0;
            this.id_order_form = 0;
            this.id_bartender = 0;
            this.id_accountant = 0;
            this.total_price_products = 0;
            this.fine = 0;
            this.date_cre = "";
            this.date_con = "Still not have confirmation date";
            this.total_price = 0;
            this.status = 0;
            this.total_quantity = 0;
        }

        public MOrderBill(int ID, int ID_ORDER_FORM, int ID_BARTENDER, int ID_ACCOUNTANT, double TOTAL_PRICE_PRODUCTS, double FINE, string DATE_CREATE, double TOTAL_PRICE, int STATUS, int TOTAL_QUANTITY)
        {
            this.id = ID;
            this.id_order_form = ID_ORDER_FORM;
            this.id_bartender = ID_BARTENDER;
            this.id_accountant = ID_ACCOUNTANT;
            this.total_price_products = TOTAL_PRICE_PRODUCTS;
            this.fine = FINE;
            this.date_cre = DATE_CREATE;
            this.date_con = "Still not have confirmation date";
            this.total_price = TOTAL_PRICE;
            this.status = STATUS;
            this.total_quantity = TOTAL_QUANTITY;
        }

        public MOrderBill(int ID, int ID_ORDER_FORM, int ID_BARTENDER, int ID_ACCOUNTANT, double TOTAL_PRICE_PRODUCTS, double FINE, string DATE_CREATE, string DATE_CON, double TOTAL_PRICE, int STATUS)
        {
            this.id = ID;
            this.id_order_form = ID_ORDER_FORM;
            this.id_bartender = ID_BARTENDER;
            this.id_accountant = ID_ACCOUNTANT;
            this.total_price_products = TOTAL_PRICE_PRODUCTS;
            this.fine = FINE;
            this.date_cre = DATE_CREATE;
            this.date_con = DATE_CON;
            this.total_price = TOTAL_PRICE;
            this.status = STATUS;
        }

        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }
        public int getID_ORDER_FORM() { return this.id_order_form; }
        public void setID_ORDER_FORM(int ID_ORDER_FORM) { this.id_order_form = ID_ORDER_FORM; }
        public int getID_BARTENDER() { return this.id_bartender; }
        public void setID_BARTENDER(int ID_BARTENDER) { this.id_bartender = ID_BARTENDER; }
        public int getID_ACCOUNTANT() { return this.id_accountant; }
        public void setID_ACCOUNTANT(int ID_ACCOUNTANT) { this.id_accountant = ID_ACCOUNTANT; }
        public double getTOTAL_PRICE_PRODUCTS() { return this.total_price_products ; }
        public void setTOTAL_PRICE_PRODUCTS(double TOTAL_PRICE_PRODUCTS) { this.total_price_products = TOTAL_PRICE_PRODUCTS; }
        public double getFINE() { return this.fine; }
        public void setFINE(double FINE) { this.fine = FINE; }
        public string getDATE_CREATE() { return this.date_cre; }
        public void setDATE_CREATE(string DATE_CREATE) { this.date_cre = DATE_CREATE; }
        public string getDATE_CONFIRM() { return this.date_con; }
        public void setDATE_CONFIRM(string DATE_CONFIRM) { this.date_con = DATE_CONFIRM; }
        public double getTOTAL_PRICE() { return this.total_price; }
        public void setTOTAL_PRICE(double TOTAL_PRICE) { this.total_price = TOTAL_PRICE; }
        public int getSTATUS() { return this.status; }
        public void setSTATUS(int STATUS) { this.status = STATUS; }

        public int getTOTAL_QUANTITY() { return this.total_quantity; }
        public void setTOTAL_QUANTITY(int TOTAL_QUANTITY) { this.total_quantity = TOTAL_QUANTITY; }

    }
}
