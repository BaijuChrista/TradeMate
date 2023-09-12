using System;
using System.Collections.Generic;
using System.Text;
using SC.Data;
namespace SC.Service.Interface
{
    public interface ICompanyService
    {
        


        List<Company> GetAllCompany();
        void AddCompany(Company Company);
        Company GetCompany(long id);
        void UpdateCompany(Company Company);
        List<Company> GetCompany();


        List<CompanyContact> GetAllCompanyContact();
        void AddCompanyContact(CompanyContact CompanyContact);
        CompanyContact GetCompanyContact(long id);
        void UpdateCompanyContact(CompanyContact CompanyContact);
        List<CompanyContact> GetCompanyContact();
    }
}
