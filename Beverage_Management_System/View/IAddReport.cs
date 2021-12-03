using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    internal interface IAddReport
    {
        string fine { get; set; }
        string reason { get; set; }
        string solution { get; set; }
    }
}
