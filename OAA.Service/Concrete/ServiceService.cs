using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SC.Data;
using SC.Repository;
using SC.Service.Interface;

namespace SC.Service.Concrete
{
   public class ServiceService: IServiceService
    {
        private IRepository<service> ServiceRepository;
        private IRepository<servicetype> ServicetypeRepository;
        public ServiceService(IRepository<service> serviceRepository, IRepository<servicetype> servicetypeRepository)
        {
            this.ServiceRepository = serviceRepository;
            this.ServicetypeRepository = servicetypeRepository;
        }

        public List<servicetype> GetAllServicetype()
        {
            return ServicetypeRepository.GetQueryable().Include(b => b.coa).ToList();
        }
        public void AddServicetype(servicetype servicetype)
        {
            ServicetypeRepository.Insert(servicetype);
        }
        public servicetype GetServicetype(long id)
        {
            return ServicetypeRepository.Get(id);
        }
        public void UpdateServicetype(servicetype servicetype)
        {
            ServicetypeRepository.Update(servicetype);
        }
        public void DeleteServicetype(servicetype servicetype)
        {
            ServicetypeRepository.Delete(servicetype);
        }

        public List<service> GetAllService()
        {
            return ServiceRepository.GetQueryable().Include(b => b.servicetype).ToList();
        }
        public void AddService(service service)
        {
            ServiceRepository.Insert(service);
        }
        public service GetService(long id)
        {
            return ServiceRepository.Get(id);
        }
        public void UpdateService(service service)
        {
            ServiceRepository.Update(service);
        }
        public void DeleteService(service service)
        {
            ServiceRepository.Delete(service);
        }
    }
}
