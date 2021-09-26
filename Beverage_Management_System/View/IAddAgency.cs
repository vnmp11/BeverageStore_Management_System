using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    interface IAddAgency
    { 
        string name { get; set; }
        string address { get; set; }
        string phone { get; set; }
        string item { get; set; }

    }
}
