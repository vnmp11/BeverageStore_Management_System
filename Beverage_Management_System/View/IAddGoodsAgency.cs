using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    interface IAddGoodsAgency
    {

        string name { get; set; }
        string price { get; set; }
        string unit { get; set; }
        string quantity { get; set; }
    }
}
