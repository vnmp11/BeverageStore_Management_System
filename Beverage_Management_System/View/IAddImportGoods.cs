using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    interface IAddImportGoods
    {

        string id_IG { get; set; }
        string id_Person { get; set; }
        string status { get; set; }
        string date { get; set; }


        //string id_Detail_IG { get; set; }
        string statusDetail { get; set; }
        string id_Product { get; set; }

        string name { get; set; }
        string quantity { get; set; }

       
        string search { get; set; }

    }
}
