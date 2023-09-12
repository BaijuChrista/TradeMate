using System;
using SC.Data;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IFinancialYearService
    {
        List<FinanceYear> GetAllFinanceYear();
        void AddFinanceYear(FinanceYear FinanceYear);
        FinanceYear GetFinanceYear(long id);
        void UpdateFinanceYear(FinanceYear FinanceYear);
        List<FinanceYear> GetFinanceYear();
    }
}
