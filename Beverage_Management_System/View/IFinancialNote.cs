using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    interface IFinancialNote
    {
        void setDataGVGoodsImportBill_Fill();
        void setDataGVOrderBill_Fill();
        void getDetailsOrderBill(int ID);
        void getDetailsGoodsImportBill(int ID);
        void searchOrderBill();
        void searchGoodsImportBill();
    }
}
