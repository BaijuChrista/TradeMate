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
   public  class ItemCategory : IItemCategory
    {
        private IRepository<Data.ItemCategory> ItemCategoryRepository;
        private IRepository<UserPagesAssigned> UserPagesAssignedRepository;

        public ItemCategory(IRepository<Data.ItemCategory> itemCategoryRepository, IRepository<Data.UserPagesAssigned> repository)
        {
            this.ItemCategoryRepository = itemCategoryRepository;
            this.UserPagesAssignedRepository = repository;
        }

        public List<Data.ItemCategory> GetAllCategory()
        {
            return ItemCategoryRepository.GetQueryable().ToList();
        }
        public List<Data.ItemCategory> GetCategory()
        {
            return ItemCategoryRepository.GetAll().ToList();
        }

        public void AddCategory(Data.ItemCategory ItemCategory)
        {
            ItemCategoryRepository.Insert(ItemCategory);
        }

        public Data.ItemCategory GetCategory(long id)
        {
            return ItemCategoryRepository.Get(id);
        }

        public void UpdateCategory(Data.ItemCategory ItemCategory)
        {
            ItemCategoryRepository.Update(ItemCategory);
        }

        public List<Data.UserPagesAssigned> GetAllUserPagesAssigned()
        {
            return UserPagesAssignedRepository.GetQueryable().Include(x=>x.User).ToList();
        }
        public List<Data.UserPagesAssigned> GetUserPagesAssigned()
        {
            return UserPagesAssignedRepository.GetAll().ToList();
        }

        public void AddUserPagesAssigned(Data.UserPagesAssigned UserPagesAssigned)
        {
            UserPagesAssignedRepository.Insert(UserPagesAssigned);
        }

        public Data.UserPagesAssigned GetUserPagesAssigned(long id)
        {
            return UserPagesAssignedRepository.Get(id);
        }

        public void UpdateUserPagesAssigned(Data.UserPagesAssigned UserPagesAssigned)
        {
            UserPagesAssignedRepository.Update(UserPagesAssigned);
        }
    
}
}

