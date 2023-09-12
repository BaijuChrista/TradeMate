using System;
using System.Collections.Generic;
using System.Text;
using SC.Data;
using SC.Repository;

namespace SC.Service.Interface
{
    public interface ISalesService
    {
        List<SalesOrder> GetAllSalesOrder(); List<Deliverycategory> GetAllDeliverycategory();
        SalesOrder GetSalesOrder(long Id);
        List<SalesOrderDetail> GetAllSalesOrderDetail();
        SalesOrderDetail GetSalesOrderDetail(long Id);
        void UpdateSalesOrder(SalesOrder SalesOrder);
        void UpdateSalesOrderDetails(SalesOrderDetail SalesOrderDetail);
        void AddSalesOrder(SalesOrder SalesOrder);
        void AddSalesOrderDetail(SalesOrderDetail SalesOrderDetail);
        void DeleteSalesOrderDetail(long Id);
        List<Sales> GetAllSales();
        List<SalesDetail> GetAllSalesDetail();
        void UpdateSales(Sales Sales);
        void AddSalesDetail(SalesDetail item);
        void AddSales(Sales sales);
        void DeleteSalesDetail(long Id);
        void addSalespaiddetail(Salespaiddetail item);
        void updateSalespaiddetail(Salespaiddetail item);
        List<Salespaiddetail> GetAllSalespaiddetail();
        Sales GetSales(long Id);

        void AddDeliveryItem(DeliveryItem DeliveryItem);
        DeliveryItem GetDeliveryItem(long Id);
        List<DeliveryItem> GetAllDeliveryItem();
        void UpdateDeliveryItem(DeliveryItem DeliveryItem);


        void AddDeliveryPayment(DeliveryPayment DeliveryPayment);
        DeliveryPayment GetDeliveryPayment(long Id);
        List<DeliveryPayment> GetDeliveryPayment();
        void UpdateDeliveryPayment(DeliveryPayment DeliveryPayment);
    }
}
