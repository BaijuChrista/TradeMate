using System;
using System.Collections.Generic;
using System.Text;
using SC.Data;
namespace SC.Service.Interface
{
    public interface ICurrencyService
    {
        List<Currency> GetAllCurrency();
        void AddCurrency(Currency Currency);
        Currency GetCurrency(long id);
        void UpdateCurrency(Currency Currency);
        List<Currency> GetCurrency();



        List<Task> GetAllTask();
        void AddTask(Task Task);
        Task GetTask(long id);
        void UpdateTask(Task Task);
    }
}
