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
   public  class StoreService : IStoreService
    {
        private IRepository<Store> StoreServiceRepository;
        public StoreService(IRepository<Store> StoreServiceRepository)
        {
            this.StoreServiceRepository = StoreServiceRepository;
        }

        public List<Store> GetAllStore()
        {
            return StoreServiceRepository.GetQueryable().Include(b => b.Company).Include(b=>b.City).ToList();
        }
        public List<Store> GetStore()
        {
            return StoreServiceRepository.GetAll().ToList();
        }
        public void AddStore(Store Store)
        {
            StoreServiceRepository.Insert(Store);
        }
        public Store GetStore(long id)
        {
            return StoreServiceRepository.Get(id);
        }
        public void UpdateStore(Store Store)
        {
            StoreServiceRepository.Update(Store);
        }
    }
}
