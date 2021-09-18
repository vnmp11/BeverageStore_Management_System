using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    interface IAddStaff
    {
        string username { get; set; }
        string password { get; set; }
        string name { get; set; }
        DateTime dob  { get; set; }
        string sex { get; set; }
        string phone { get; set; }
        string address { get; set; }
        int role { get; set; }
    }
}
