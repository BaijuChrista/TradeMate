using System;
using System.Collections.Generic;
using System.Text;
using SC.Data;
namespace SC.Service.Interface
{
   public interface IUserTypeService
    {
        List<UserType> GetAllUserType();
        void AddUserType(UserType UserType);
        UserType GetUserType(long id);
        void UpdateUserType(UserType UserType);
        List<UserType> GetUserType();
    }
}
