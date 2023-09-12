using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SC.Data;
using SC.Repository;
using SC.Service.Interface;

namespace SC.Service.Concrete
{
  public   class TaxMasterService: ITaxMasterService
    {
        private IRepository<TaxMaster> TaxMasterRepository;

        public TaxMasterService(IRepository<TaxMaster> taxMasterRepository)
        {
            this.TaxMasterRepository = taxMasterRepository;
        }

        public List<TaxMaster> GetAllTaxMaster()
        {
            return TaxMasterRepository.GetQueryable().ToList();
        }
        public List<TaxMaster> GetTaxMaster()
        {
            return TaxMasterRepository.GetAll().ToList();
        }

        public void AddTaxMaster(TaxMaster TaxMaster)
        {
            TaxMasterRepository.Insert(TaxMaster);
        }

        public TaxMaster GetTaxMaster(long id)
        {
            return TaxMasterRepository.Get(id);
        }

        public void UpdateTaxMaster(TaxMaster TaxMaster)
        {
            TaxMasterRepository.Update(TaxMaster);
        }
    }
}
