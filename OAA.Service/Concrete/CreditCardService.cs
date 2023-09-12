using Microsoft.EntityFrameworkCore;
using SC.Data;
using SC.Repository;
using SC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SC.Service.Concrete
{
    public class CreditCardService : ICreditCardService
    {
        private IRepository<CreditCard> CreditCardRepository;
        private IRepository<CreditCardcategory> CreditCardcategoryRepository;
        public CreditCardService(IRepository<CreditCard> creditCardRepository, IRepository<CreditCardcategory> creditCardcategoryRepository)
        {
            this.CreditCardRepository = creditCardRepository;
            this.CreditCardcategoryRepository = creditCardcategoryRepository;
        }
        public List<CreditCard> GetAllCreditCard()
        {
            return CreditCardRepository.GetQueryable().Include(a=>a.Bank).ToList();
        }
        public List<CreditCard> GetCreditCard()
        {
            return CreditCardRepository.GetAll().ToList();
        }
        public void AddCreditCard(CreditCard CreditCard)
        {
            CreditCardRepository.Insert(CreditCard);
        }
        public CreditCard GetCreditCard(long id)
        {
            return CreditCardRepository.Get(id);
        }
        public void UpdateCreditCard(CreditCard CreditCard)
        {
            CreditCardRepository.Update(CreditCard);
        }

        public List<CreditCardcategory> GetAllCreditCardcategory()
        {
            return CreditCardcategoryRepository.GetQueryable().Include(b=>b.coa).ToList();
        }
        public List<CreditCardcategory> GetCreditCardcategory()
        {
            return CreditCardcategoryRepository.GetAll().ToList();
        }
        public void AddCreditCardcategory(CreditCardcategory CreditCardcategory)
        {
            CreditCardcategoryRepository.Insert(CreditCardcategory);
        }
        public CreditCardcategory GetCreditCardcategory(long id)
        {
            return CreditCardcategoryRepository.Get(id);
        }
        public void UpdateCreditCardcategory(CreditCardcategory CreditCardcategory)
        {
            CreditCardcategoryRepository.Update(CreditCardcategory);
        }

    }
}
