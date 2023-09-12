using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface ITaxMasterService
    {
        List<TaxMaster> GetAllTaxMaster();
        void AddTaxMaster(TaxMaster TaxMaster);
        TaxMaster GetTaxMaster(long id);
        void UpdateTaxMaster(TaxMaster TaxMaster);
        List<TaxMaster> GetTaxMaster();
    }
}
