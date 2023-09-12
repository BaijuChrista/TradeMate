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
    public class SaleReturnService : ISaleReturnService
    {
        private IRepository<salereturn> salereturnRepository;
        private IRepository<salereturnDetail> salereturnDetailRepository;
        public SaleReturnService(IRepository<salereturn> salereturnRepository, IRepository<salereturnDetail> salereturnDetailRepository)
        {
            this.salereturnDetailRepository = salereturnDetailRepository;
            this.salereturnRepository = salereturnRepository;
        }

        public void Addsalereturn(salereturn salereturn)
        {
            salereturnRepository.Insert(salereturn);
        }

        public List<salereturn> GetAllsalereturn()
        {
            return salereturnRepository.GetQueryable().Include(b => b.Sales).ThenInclude(x=>x.Customer).ToList();
        }
        

        public void DeletesalereturnDetails(long Id)
        {
            var items = salereturnDetailRepository.GetAll().Where(x => x.salereturnId == Id).ToList().ToList();
            foreach (var item in items)
            {
                salereturnDetailRepository.Delete(item);
            }
        }

        public List<salereturnDetail> GetAllsalereturnDetail()
        {
            return salereturnDetailRepository.GetQueryable().Include(b => b.salereturn).Include(x=>x.ItemMaster).ToList();
        }

        public void Updatesalereturn(salereturn salereturn)
        {
            salereturnRepository.Update(salereturn);
        }

        public void AddsalereturnDetail(salereturnDetail salereturnDetail)
        {
            salereturnDetailRepository.Insert(salereturnDetail);
        }

        public salereturn Getsalereturn(long Id)
        {
            return salereturnRepository.Get(Id);
        }

        public salereturnDetail GetsalereturnDetails(long Id)
        {
            return salereturnDetailRepository.Get(Id);
        }
    }
}
