using System;
using SC.Data;
using System.Collections.Generic;
using System.Text;
using SC.Repository;
using SC.Service.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace SC.Service.Concrete
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly ApplicationContext context;
       
       
              
        private DbSet<ApplicationUser> entities;
        string errorMessage = string.Empty;

        public ApplicationUserService(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<ApplicationUser>();
          
        }

        public ApplicationUser AddApplicationUser(ApplicationUser ApplicationUser)
        {
            if (ApplicationUser == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(ApplicationUser);
            SaveChange();
            return ApplicationUser;
        }

        public List<ApplicationUser> GetAllApplicationUser()
        {
          return entities.ToList();
        }
       


        public ApplicationUser GetApplicationUser(long id)
        {
            return entities.Find(id);
        }

        public List<ApplicationUser> GetApplicationUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateApplicationUser(ApplicationUser ApplicationUser)
        {
            if (ApplicationUser == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(ApplicationUser);
            SaveChange();
        }

        private void SaveChange()
        {
            context.SaveChanges();
        }

        public List<GetCustomerInfo_Trademate> getCustomerInfo_Trademates(long CustomerId)
        {
            var param = new SqlParameter("@CustomeId", CustomerId);
            return context.GetCustomerInfo_Trademate.FromSql("GetCustomerInfo_Trademate @CustomeId", param).ToList();
        }

        public List<GetItemInfo_Trademate> GetItemInfo_Trademate(long itemId)
        {
            var param = new SqlParameter("@itemId", itemId);
            return context.GetItemInfo_Trademate.FromSql("GetItemInfo_Trademate @itemId", param).ToList();
        }

        public List<GetItemInfo_Trademate> GetVatInfo_Trademate(long CustomerId, long SuplierId)
        {
            var param = new SqlParameter("@customerId", CustomerId);
            var param2 = new SqlParameter("@SupplierId", SuplierId);
            return context.GetVatInfo_Trademate.FromSql("GetVatInfo_Trademate @customerId,@SupplierId", param,param2).ToList();
        }
        public List<GetProduct_Trademate> GetProduct_Trademate(bool cart, bool site,int type)
        {
            var param = new SqlParameter("@cart", cart);
            var param2 = new SqlParameter("@site", site);
            var ptype = new SqlParameter("@type", type);
            return context.GetProduct_Trademate.FromSql("GetProduct_Trademate @cart,@site,@type", param, param2,ptype).ToList();
        }
    }
}
