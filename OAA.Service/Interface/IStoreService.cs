using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface  IStoreService
    {
        List<Store> GetAllStore();
        void AddStore(Store Store);
        Store GetStore(long id);
        void UpdateStore(Store Store);
        List<Store> GetStore();
    }
}
