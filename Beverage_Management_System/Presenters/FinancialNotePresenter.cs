using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Presenters
{
    class FinancialNotePresenter
    {
        IFinancialNote financialNoteView;

        public FinancialNotePresenter(IFinancialNote view)
        {
            this.financialNoteView = view;
        }
        public FinancialNotePresenter()
        {
        }
        public void setDataGV()
        {
            financialNoteView.setDataGVOrderBill_Fill();
            financialNoteView.setDataGVGoodsImportBill_Fill();
        }

        public void getDetailsGoodsImportBill(int ID)
        {
            financialNoteView.getDetailsGoodsImportBill(ID);
        }
        public void getDetailsOrderBill(int ID)
        {
            financialNoteView.getDetailsOrderBill(ID);
        }
        public void searchGoodsImportBill()
        {
            financialNoteView.searchGoodsImportBill();
        }
        public void searchOrderBill()
        {
            financialNoteView.searchOrderBill();
        }
    }
}
