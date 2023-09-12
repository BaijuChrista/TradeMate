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
   public class DesignationService : IDesignationService
    {
        private IRepository<Designation> DesignationRepository;
        private IRepository<DesignationGroup> DesignationGroupRepository;
        public DesignationService(IRepository<Designation> designationRepository, IRepository<DesignationGroup> designationGroupRepository)
        {
            this.DesignationRepository = designationRepository;
            this.DesignationGroupRepository = designationGroupRepository;
        }

        public List<Designation> GetAllDesignation()
        {
            return DesignationRepository.GetQueryable().Include(b => b.DesignationGroup).ToList();
        }
        public List<Designation> GetDesignation()
        {
            return DesignationRepository.GetAll().ToList();
        }
        public void AddDesignation(Designation Designation)
        {
            DesignationRepository.Insert(Designation);
        }
        public Designation GetDesignation(long id)
        {
            return DesignationRepository.Get(id);
        }
        public void UpdateDesignation(Designation Designation)
        {
            DesignationRepository.Update(Designation);
        }


        public List<DesignationGroup> GetAllDesignationGroup()
        {
            return DesignationGroupRepository.GetQueryable().ToList();
        }
        public List<DesignationGroup> GetDesignationGroup()
        {
            return DesignationGroupRepository.GetAll().ToList();
        }
        public void AddDesignationGroup(DesignationGroup DesignationGroup)
        {
            DesignationGroupRepository.Insert(DesignationGroup);
        }
        public DesignationGroup GetDesignationGroup(long id)
        {
            return DesignationGroupRepository.Get(id);
        }
        public void UpdateDesignationGroup(DesignationGroup DesignationGroup)
        {
            DesignationGroupRepository.Update(DesignationGroup);
        }
    }
}
