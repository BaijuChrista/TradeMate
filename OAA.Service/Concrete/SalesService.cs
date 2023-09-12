using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SC.Data;
using SC.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SC.Service.Interface;

namespace SC.Service.Concrete
{
   public class SalesService : ISalesService
    {
        private IRepository<SalesOrder> SalesOrderRepository;
        private IRepository<Receipt> ReceiptRepository;
        private IRepository<SalesOrderDetail> SalesOrderDetailRepository;
        private IRepository<Sales> SalesRepository;
        private IRepository<SalesDetail> SalesDetailRepository;
        private IRepository<Salespaiddetail> SalespaiddetailRepository;
        private IRepository<DeliveryItem> DeliveryItemRepo;
        private IRepository<Deliverycategory> DeliverycategoryRepo;
        private IRepository<DeliveryPayment> DeliveryPaymentRepo;
        public SalesService(IRepository<SalesOrder> salesOrderRepository,IRepository<Salespaiddetail> sailspaid, IRepository<SalesOrderDetail> salesOrderDetailRepository, IRepository<Receipt> receiptRepository, 
            IRepository<Sales> salesRepository,IRepository<SalesDetail> salesDetailrepo,IRepository<DeliveryItem> deliveryItemRepo,
            IRepository<Deliverycategory> Deliverycategoryrepository, IRepository<DeliveryPayment> deliveryPaymentrepository)
        {
            this.SalesOrderRepository = salesOrderRepository;
            this.SalesOrderDetailRepository = salesOrderDetailRepository;
            this.ReceiptRepository = receiptRepository;
            this.SalesRepository = salesRepository;
            this.SalesDetailRepository = salesDetailrepo;
            SalespaiddetailRepository = sailspaid;
            DeliveryItemRepo = deliveryItemRepo;
            DeliveryPaymentRepo = deliveryPaymentrepository;
            DeliverycategoryRepo = Deliverycategoryrepository;
        }
        public List<SalesOrder> GetAllSalesOrder()
        {
            return SalesOrderRepository.GetQueryable().Include(b => b.Customer).Include(x=>x.ApplicationUser).ToList();
        }
        public void AddSalesOrder(SalesOrder SalesOrder)
        {
            SalesOrderRepository.Insert(SalesOrder);
        }
        public SalesOrder GetSalesOrder(long Id)
        {
            return SalesOrderRepository.Get(Id);
        }
        public List<SalesOrderDetail> GetAllSalesOrderDetail()
        {
            return SalesOrderDetailRepository.GetQueryable().Include(b=>b.ItemMaster).Include(b => b.SalesOrder).ThenInclude(x=>x.Customer).ThenInclude(x=>x.City).ToList();
        }
        public SalesOrderDetail GetSalesOrderDetail(long Id)
        {
            return SalesOrderDetailRepository.Get(Id);
        }
        public void UpdateSalesOrder(SalesOrder SalesOrder)
        {
            SalesOrderRepository.Update(SalesOrder);
        }
        public void AddSalesOrderDetail(SalesOrderDetail SalesOrderDetail)
        {
            SalesOrderDetailRepository.Insert(SalesOrderDetail);
        }


        public void AddDeliveryItem(DeliveryItem DeliveryItem)
        {
            DeliveryItemRepo.Insert(DeliveryItem);
        }
        public DeliveryItem GetDeliveryItem(long Id)
        {
            return DeliveryItemRepo.Get(Id);
        }
        public List<DeliveryItem> GetAllDeliveryItem()
        {
            return DeliveryItemRepo.GetQueryable().Include(b => b.UserAssigned).Include(x => x.ApplicationUser).ToList();
        }

        public void UpdateDeliveryItem(DeliveryItem DeliveryItem)
        {
            DeliveryItemRepo.Update(DeliveryItem);
        }



        public void DeleteSalesOrderDetail(long Id)
        {
            var items = SalesOrderDetailRepository.GetAll().Where(x => x.SalesOrderId == Id).ToList().ToList();
            foreach (var item in items)
            {
                item.Status = 0;
                SalesOrderDetailRepository.Update(item);
            }
        }
        public List<Sales> GetAllSales()
        {
            return SalesRepository.GetQueryable().Include(b=>b.SalesOrder).ThenInclude(x=>x.ApplicationUser).Include(b => b.Customer).ThenInclude(x => x.City).ToList();
        }
        public List<SalesDetail> GetAllSalesDetail()
        {
            return SalesDetailRepository.GetQueryable().Include(b => b.ItemMaster).Include(b => b.Sales).ThenInclude(x=>x.SalesOrder).ThenInclude(x => x.Customer).ThenInclude(x => x.City).ToList();
        }
        public void UpdateSales(Sales Sales)
        {
            SalesRepository.Update(Sales);
        }
        public void AddSalesDetail(SalesDetail item)
        {
            SalesDetailRepository.Insert(item);
        }       
        public void AddSales(Sales sales)
        {
            SalesRepository.Insert(sales);
        }
        public void DeleteSalesDetail(long Id)
        {
            var items = SalesDetailRepository.GetAll().Where(x => x.SalesId == Id).ToList().ToList();
            foreach (var item in items)
            {
                item.Status = 0;
                SalesDetailRepository.Update(item);
            }
        }
        public void addSalespaiddetail(Salespaiddetail item)
        {
            SalespaiddetailRepository.Insert(item);
        }

        public Sales GetSales(long Id)
        {
            return SalesRepository.Get(Id);
        }

        public void UpdateSalesOrderDetails(SalesOrderDetail SalesOrderDetail)
        {
            SalesOrderDetailRepository.Update(SalesOrderDetail);
        }

        public List<Salespaiddetail> GetAllSalespaiddetail()
        {
            return SalespaiddetailRepository.GetQueryable().Include(b => b.Sales).ThenInclude(x=>x.Customer).Include(x => x.ApplicationUser).ToList();
        }

        public void updateSalespaiddetail(Salespaiddetail item)
        {
            SalespaiddetailRepository.Update(item);
        }

        public List<Deliverycategory> GetAllDeliverycategory()
        {
           return DeliverycategoryRepo.GetQueryable().ToList();
        }

        public void AddDeliveryPayment(DeliveryPayment DeliveryPayment)
        {
            DeliveryPaymentRepo.Insert(DeliveryPayment);
        }

        public DeliveryPayment GetDeliveryPayment(long Id)
        {
            return DeliveryPaymentRepo.Get(Id);
        }

        public List<DeliveryPayment> GetDeliveryPayment()
        {
            return DeliveryPaymentRepo.GetAll().Include(x=>x.DeliveryItem).ToList();
        }

        public void UpdateDeliveryPayment(DeliveryPayment DeliveryPayment)
        {
            DeliveryPaymentRepo.Update(DeliveryPayment);
        }
    }
}
