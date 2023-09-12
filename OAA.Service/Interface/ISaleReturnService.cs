using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface ISaleReturnService
    {
        List<salereturn> GetAllsalereturn();
        List<salereturnDetail> GetAllsalereturnDetail();

        void Addsalereturn(salereturn salesreturn);
        void Updatesalereturn(salereturn salesreturn);
        void AddsalereturnDetail(salereturnDetail salesreturnDetail);
        void DeletesalereturnDetails(long Id);

        salereturn Getsalereturn(long Id);
        salereturnDetail GetsalereturnDetails(long Id);
    }
}
