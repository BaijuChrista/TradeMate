using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IPurchaseService
    {
        List<Purchase> GetAllPurchaseOrder();
        List<PurchaseDetail> GetAllPurchaseOrderDetail();

        void AddPurchaseOrder(Purchase PurchaseOrder);
        void UpdatePurchaseOrder(Purchase PurchaseOrder);
        void AddPurchaseOrderDetails(PurchaseDetail PurchaseOrderDetail);
        void DeletePurchaseOrderDetails(long Id);
        Purchase GetPurchaseOrder(long Id);
        PurchaseDetail GetPurchaseOrderDetails(long Id);


        void AddPurchasePaidDetails(purchasepaiddetail item);
        List<purchasepaiddetail> GetPurchasePaidDetails();
        void UpdatePaidDetails(purchasepaiddetail item);
    }
}
