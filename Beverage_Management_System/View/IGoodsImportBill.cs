using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    interface IGoodsImportBill
    {
        void setDataGV_Fill();
        void getDetailsGoodsImportBill(int ID);
        void browseBill(int ID);
        void serachBill();
    }
}
