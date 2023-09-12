using Microsoft.EntityFrameworkCore;
using SC.Data;
using SC.Repository;
using SC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SC.Service.Concrete
{
    public class PurchaseService : IPurchaseService
    {
        private IRepository<Purchase> PurchaseOrderRepository;
        private IRepository<Payment> PaymentRepository;
        private IRepository<PurchaseDetail> PurchaseOrderDetailRepository;
        private IRepository<purchasepaiddetail> purchasepaiddetailRepository;
        public PurchaseService(IRepository<Purchase> purchaseOrderRepository, IRepository<PurchaseDetail> purchaseOrderDetailRepository, IRepository<Payment> PaymentRepository,
            IRepository<purchasepaiddetail> purchasepaiddetail)
        {
            this.PurchaseOrderDetailRepository = purchaseOrderDetailRepository;
            this.PurchaseOrderRepository = purchaseOrderRepository;
            this.PaymentRepository = PaymentRepository;
            purchasepaiddetailRepository = purchasepaiddetail;
        }

        public void AddPurchaseOrder(Purchase PurchaseOrder)
        {
            PurchaseOrderRepository.Insert(PurchaseOrder);
        }

        public List<Purchase> GetAllPurchaseOrder()
        {
            return PurchaseOrderRepository.GetQueryable().Include(b => b.Supplier).ToList();
        }
        public List<PurchaseDetail> GetAllPurchaseOrderDetail()
        {
            return PurchaseOrderDetailRepository.GetQueryable().Include(b => b.ItemMaster).Include(x=>x.Purchase).ThenInclude(x=>x.Supplier).ThenInclude(x=>x.City).ToList();
        }

        public void UpdatePurchaseOrder(Purchase PurchaseOrder)
        {
            PurchaseOrderRepository.Update(PurchaseOrder);
        }
        public void AddPurchaseOrderDetails(PurchaseDetail PurchaseOrderDetail)
        {
            PurchaseOrderDetailRepository.Insert(PurchaseOrderDetail);
        }

        public void DeletePurchaseOrderDetails(long Id)
        {
            var items = PurchaseOrderDetailRepository.GetAll().Where(x => x.PurchaseOrderId == Id).ToList().ToList();
            foreach (var item in items)
            {
                item.Status = 0;
                PurchaseOrderDetailRepository.Update(item);
            }
        }

        public Purchase GetPurchaseOrder(long Id)
        {
            return PurchaseOrderRepository.Get(Id);
        }

        public PurchaseDetail GetPurchaseOrderDetails(long Id)
        {
            return PurchaseOrderDetailRepository.Get(Id);
        }

        public void AddPurchasePaidDetails(purchasepaiddetail item)
        {
            purchasepaiddetailRepository.Insert(item);
        }

        public List<purchasepaiddetail> GetPurchasePaidDetails()
        {
            return purchasepaiddetailRepository.GetQueryable().Include(x=>x.Purchase).ThenInclude(x=>x.Supplier).Include(x=>x.ApplicationUser).ToList(); ;
        }

        public void UpdatePaidDetails(purchasepaiddetail item)
        {
            purchasepaiddetailRepository.Update(item);
        }
    }
}
