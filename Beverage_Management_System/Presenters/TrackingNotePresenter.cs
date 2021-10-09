using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Presenters
{
    class TrackingNotePresenter
    {
        ITrackingNote trackingNoteView;

        public TrackingNotePresenter(ITrackingNote view)
        {
            this.trackingNoteView = view;
        }
        public TrackingNotePresenter()
        {
        }
        public void setDataGV()
        {
            trackingNoteView.setDataGV_Fill();
        }
        public void getDetails(int ID)
        {
            trackingNoteView.getDetailsTrackingNote(ID);
        }
        public void search()
        {
            trackingNoteView.searchNote();
        }
    }
}
