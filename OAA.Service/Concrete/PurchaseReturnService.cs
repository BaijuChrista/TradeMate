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
    public class PurchaseReturnService : IPurchaseReturnService
    {
        private IRepository<purchasereturn> PurchasereturnRepository;
        private IRepository<purchasereturnDetail> PurchasereturnDetailRepository;
        public PurchaseReturnService(IRepository<purchasereturn> purchasereturnRepository, IRepository<purchasereturnDetail> purchasereturnDetailRepository)
        {
            this.PurchasereturnDetailRepository = purchasereturnDetailRepository;
            this.PurchasereturnRepository = purchasereturnRepository;
        }

        public void Addpurchasereturn(purchasereturn purchasereturn)
        {
            PurchasereturnRepository.Insert(purchasereturn);
        }

        public List<purchasereturn> GetAllpurchasereturn()
        {
            return PurchasereturnRepository.GetQueryable().Include(b => b.Purchase).ToList();
        }
        

        public void DeletepurchasereturnDetails(long Id)
        {
            var items = PurchasereturnDetailRepository.GetAll().Where(x => x.purchasereturnId == Id).ToList().ToList();
            foreach (var item in items)
            {
                PurchasereturnDetailRepository.Delete(item);
            }
        }

        public List<purchasereturnDetail> GetAllpurchasereturnDetail()
        {
            return PurchasereturnDetailRepository.GetQueryable().Include(b => b.purchasereturn).Include(x=>x.ItemMaster).ToList();
        }

        public void Updatepurchasereturn(purchasereturn purchasereturn)
        {
            PurchasereturnRepository.Update(purchasereturn);
        }

        public void AddpurchasereturnDetail(purchasereturnDetail purchasereturnDetail)
        {
            PurchasereturnDetailRepository.Insert(purchasereturnDetail);
        }

        public purchasereturn Getpurchasereturn(long Id)
        {
            return PurchasereturnRepository.Get(Id);
        }

        public purchasereturnDetail GetpurchasereturnDetails(long Id)
        {
            return PurchasereturnDetailRepository.Get(Id);
        }
    }
}
