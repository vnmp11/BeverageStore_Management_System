﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.View
{
    interface ITrackingNote
    {
        void setDataGV_Fill();
        void getDetailsTrackingNote(int ID);
        void searchNote();
    }
}
