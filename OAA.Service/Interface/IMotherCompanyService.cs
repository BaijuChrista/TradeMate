using System;
using SC.Data;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IMotherCompanyService
    {
        List<MotherCompany> GetAllMotherCompany();
        void AddMotherCompany(MotherCompany MotherCompany);
        MotherCompany GetMotherCompany(long id);
        void UpdateMotherCompany(MotherCompany MotherCompany);
        List<MotherCompany> MotherCompany();
    }
}
