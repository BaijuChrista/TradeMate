using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SC.Data;
using SC.Repository;
using SC.Service.Interface;

namespace SC.Service.Concrete
{
    public class FinancialYearService : IFinancialYearService
    {
        private IRepository<FinanceYear> FinanceYearRepository;

        public FinancialYearService(IRepository<FinanceYear> financeYearRepository)
        {
            this.FinanceYearRepository = financeYearRepository;
        }

        public List<FinanceYear> GetAllFinanceYear()
        {
            return FinanceYearRepository.GetQueryable().ToList();
        }
        public List<FinanceYear> GetFinanceYear()
        {
            return FinanceYearRepository.GetAll().ToList();
        }

        public void AddFinanceYear(FinanceYear FinanceYear)
        {
            FinanceYearRepository.Insert(FinanceYear);
        }

        public FinanceYear GetFinanceYear(long id)
        {
            return FinanceYearRepository.Get(id);
        }

        public void UpdateFinanceYear(FinanceYear FinanceYear)
        {
            FinanceYearRepository.Update(FinanceYear);
        }

      


      
    }
}
