using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Model
{
    class MDetailsGoodsImportBill
    {
        private int id;
        private int id_goods_import_bill;
        private int id_goods;
        private int quantity;
        private double total_price;

        public MDetailsGoodsImportBill()
        {
            this.id = 0;
            this.id_goods_import_bill = 0;
            this.id_goods = 0;
            this.quantity = 0;
            this.total_price = 0;

        }
        public MDetailsGoodsImportBill(int ID, int ID_GOODS_IMPORT_BILL, int ID_GOODS, int QUANTITY, double TOTAL_PRICE)
        {
            this.id = 0;
            this.id_goods_import_bill = ID_GOODS_IMPORT_BILL;
            this.id_goods = ID_GOODS;
            this.quantity = QUANTITY;
            this.total_price = TOTAL_PRICE;

        }

        public int getID() { return this.id; }
        public void setID(int ID) { this.id = ID; }
        public int getID_GOODS_IMPORT_BILL() { return this.id_goods_import_bill; }
        public void setID_GOODS_IMPORT_BILL(int ID_GOODS_IMPORT_BILL) { this.id_goods_import_bill = ID_GOODS_IMPORT_BILL; }
        public int getID_GOODS() { return this.id_goods; }
        public void setID_GOODS(int ID_GOODS) { this.id_goods = ID_GOODS; }
        public int getQUANTITY() { return this.quantity; }
        public void setQUANTITY(int QUANTITY) { this.quantity = QUANTITY; }
        public double getTOTAL_PRICE() { return this.total_price; }
        public void setTOTAL_PRICE(double TOTAL_PRICE) { this.total_price = TOTAL_PRICE; }

    }
}
