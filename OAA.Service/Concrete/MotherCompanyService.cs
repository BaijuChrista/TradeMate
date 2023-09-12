using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SC.Data;
using SC.Repository;
using SC.Service.Interface;

namespace SC.Service.Concrete
{
    public class MotherCompanyService : IMotherCompanyService
    {
        private IRepository<MotherCompany> MotherCompanyRepository;

        public MotherCompanyService(IRepository<MotherCompany> mothercompanyRepository)
        {
            this.MotherCompanyRepository = mothercompanyRepository;
        }

        public List<MotherCompany> GetAllMotherCompany()
        {
            return MotherCompanyRepository.GetQueryable().ToList();
        }
        public List<MotherCompany> MotherCompany()
        {
            return MotherCompanyRepository.GetAll().ToList();
        }

        public void AddMotherCompany(MotherCompany MotherCompany)
        {
            MotherCompanyRepository.Insert(MotherCompany);
        }

        public MotherCompany GetMotherCompany(long id)
        {
            return MotherCompanyRepository.Get(id);
        }

        public void UpdateMotherCompany(MotherCompany MotherCompany)
        {
            MotherCompanyRepository.Update(MotherCompany);
        }

       
    }
}
