using Beverage_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    interface IAddProduct
    {
        string name { get; set; }
        string price { get; set; }
        string quantity { get; set; }

    }
}
