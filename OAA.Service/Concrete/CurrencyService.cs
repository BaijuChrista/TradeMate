using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SC.Data;
using SC.Repository;
using SC.Service.Interface;

namespace SC.Service.Concrete
{
    public class CurrencyService : ICurrencyService
    {

        private IRepository<Currency> CurrencyRepository;
        private IRepository<Task> TaskRepository;

        public CurrencyService(IRepository<Currency> CurrencyRepository, IRepository<Task> taskrepo)
        {
            this.CurrencyRepository = CurrencyRepository;
            this.TaskRepository = taskrepo;
        }

        public List<Currency> GetAllCurrency()
        {
            return CurrencyRepository.GetQueryable().ToList();
        }
        public List<Currency> GetCurrency()
        {
            return CurrencyRepository.GetAll().ToList();
        }

        public void AddCurrency(Currency Currency)
        {
            CurrencyRepository.Insert(Currency);
        }

        public Currency GetCurrency(long id)
        {
            return CurrencyRepository.Get(id);
        }

        public void UpdateCurrency(Currency Currency)
        {
            CurrencyRepository.Update(Currency);
        }

        public List<Task> GetAllTask()
        {

            return TaskRepository.GetQueryable().ToList();
        }

        public void AddTask(Task Task)
        {
            TaskRepository.Insert(Task);
        }

        public Task GetTask(long id)
        {
            return TaskRepository.Get(id);
        }

        public void UpdateTask(Task Task)
        {
            TaskRepository.Update(Task);
        }
    }
}

