using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IServiceService
    {
        List<servicetype> GetAllServicetype();
        void AddServicetype(servicetype servicetype);
        servicetype GetServicetype(long id);
        void UpdateServicetype(servicetype servicetype);
        void DeleteServicetype(servicetype servicetype);

        List<service> GetAllService();
        void AddService(service service);
        service GetService(long id);
        void UpdateService(service service);
        void DeleteService(service service);
    }
}
