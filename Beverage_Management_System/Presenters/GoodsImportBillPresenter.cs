using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Management_System.Presenters
{
    class GoodsImportBillPresenter
    {
        IGoodsImportBill goodsImportBillView;

        public GoodsImportBillPresenter(IGoodsImportBill view)
        {
            this.goodsImportBillView = view;
        }
        public GoodsImportBillPresenter()
        {
        }
        public void setDataGV()
        {
            goodsImportBillView.setDataGV_Fill();
        }
        public void getDetails(int ID)
        {
            goodsImportBillView.getDetailsGoodsImportBill(ID);
        }
        public void browseBill(int ID)
        {
            goodsImportBillView.browseBill(ID);
        }
        public void searchBill()
        {
            goodsImportBillView.serachBill();
        }
    }
}
