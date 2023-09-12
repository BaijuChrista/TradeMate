using System;
using System.Collections.Generic;
using System.Text;
using SC.Data;
namespace SC.Service.Interface
{
    public interface  IItemCategory
    {
        List<ItemCategory> GetAllCategory();
        void AddCategory(ItemCategory ItemCategory);
        ItemCategory GetCategory(long id);
        void UpdateCategory(ItemCategory ItemCategory);
        List<ItemCategory> GetCategory();

        List<UserPagesAssigned> GetAllUserPagesAssigned();
        void AddUserPagesAssigned(UserPagesAssigned UserPagesAssigned);
        UserPagesAssigned GetUserPagesAssigned(long id);
        void UpdateUserPagesAssigned(UserPagesAssigned UserPagesAssigned);
        List<UserPagesAssigned> GetUserPagesAssigned();
    }
}
