using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IPurchaseReturnService
    {
        List<purchasereturn> GetAllpurchasereturn();
        List<purchasereturnDetail> GetAllpurchasereturnDetail();

        void Addpurchasereturn(purchasereturn purchasereturn);
        void Updatepurchasereturn(purchasereturn purchasereturn);
        void AddpurchasereturnDetail(purchasereturnDetail purchasereturnDetail);
        void DeletepurchasereturnDetails(long Id);

        purchasereturn Getpurchasereturn(long Id);
        purchasereturnDetail GetpurchasereturnDetails(long Id);
    }
}
