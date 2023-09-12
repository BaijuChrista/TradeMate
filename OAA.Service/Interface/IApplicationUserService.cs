using System;
using System.Collections.Generic;
using System.Text;
using SC.Data;
namespace SC.Service.Interface
{
   public  interface IApplicationUserService
    {
        List<ApplicationUser> GetAllApplicationUser();
        ApplicationUser AddApplicationUser(ApplicationUser ApplicationUser);
        ApplicationUser GetApplicationUser(long id);
        void UpdateApplicationUser(ApplicationUser ApplicationUser);
        List<ApplicationUser> GetApplicationUser();
        List<GetCustomerInfo_Trademate> getCustomerInfo_Trademates(long CustomerId);
        List<GetItemInfo_Trademate> GetItemInfo_Trademate(long itemId);
        List<GetItemInfo_Trademate> GetVatInfo_Trademate(long CustomerId, long SuplierId);
        List<GetProduct_Trademate> GetProduct_Trademate(bool cart, bool site,int type);
    }
}
