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
   public  class CompanyService : ICompanyService
    {
        
        private IRepository<Company> CompanyRepository;
        private IRepository<CompanyContact> CompanyContactRepository;

        public CompanyService(IRepository<Company> companyRepository, IRepository<CompanyContact> companyContactRepository)
        {           
            this.CompanyRepository = companyRepository;
            this.CompanyContactRepository = companyContactRepository;
        }

      


        public List<Company> GetAllCompany()
        {
            return CompanyRepository.GetQueryable().Include(b=>b.City).ToList();
        }
        public List<Company> GetCompany()
        {
            return CompanyRepository.GetAll().ToList();
        }
        public void AddCompany(Company Company)
        {
            CompanyRepository.Insert(Company);
        }
        public Company GetCompany(long id)
        {
            return CompanyRepository.Get(id);
        }
        public void UpdateCompany(Company Company)
        {
            CompanyRepository.Update(Company);
        }


        public List<CompanyContact> GetAllCompanyContact()
        {
            return CompanyContactRepository.GetQueryable().ToList();
        }
        public List<CompanyContact> GetCompanyContact()
        {
            return CompanyContactRepository.GetAll().ToList();
        }
        public void AddCompanyContact(CompanyContact CompanyContact)
        {
            CompanyContactRepository.Insert(CompanyContact);
        }
        public CompanyContact GetCompanyContact(long id)
        {
            return CompanyContactRepository.Get(id);
        }
        public void UpdateCompanyContact(CompanyContact CompanyContact)
        {
            CompanyContactRepository.Update(CompanyContact);
        }
    }
}
