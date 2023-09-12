using System;
using SC.Data;
using System.Collections.Generic;
using System.Text;
using SC.Repository;
using SC.Service.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SC.Service.Concrete
{
  public   class UserTypeService : IUserTypeService
    {
        private readonly ApplicationContext context;
        private DbSet<UserType> entities;
        string errorMessage = string.Empty;

        public UserTypeService(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<UserType>();
        }

        public void AddUserType(UserType UserType)
        {
            if (UserType == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(UserType);
            SaveChange();
        }
        public List<UserType> GetAllUserType()
        {
            return entities.AsQueryable().ToList();
        }

        public UserType GetUserType(long id)
        {
            throw new NotImplementedException();
        }

        public List<UserType> GetUserType()
        {
            throw new NotImplementedException();
        }

        public void UpdateUserType(UserType UserType)
        {
            if (UserType == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Entry(UserType).State = EntityState.Modified;
            SaveChange();
        }

        private void SaveChange()
        {
            context.SaveChanges();
        }
    }
}
