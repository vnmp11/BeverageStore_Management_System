using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    interface IOrderBill
    {
        void setDataGV_Fill();
        void getDetailsOrderBill(int ID);
        void browseBill(int ID);
        void serachBill();
    }
}
