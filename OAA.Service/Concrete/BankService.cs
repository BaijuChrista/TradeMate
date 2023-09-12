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
   public class BankService : IBankService
    {
        private IRepository<Bank> BankRepository;
        private IRepository<Bankcategory> BankcategoryRepository;
        private IRepository<BankTxn> BankTxnRepository;
        public BankService(IRepository<Bank> bankRepository, IRepository<Bankcategory> bankcategoryRepository, IRepository<BankTxn> bankTxnRepository)
        {
            this.BankRepository = bankRepository;
            this.BankcategoryRepository = bankcategoryRepository;
            this.BankTxnRepository = bankTxnRepository;
        }
        public List<Bank> GetAllBank()
        {
            return BankRepository.GetQueryable().Include(a=>a.Currency).ToList();
        }
        public List<Bank> GetBank()
        {
            return BankRepository.GetAll().ToList();
        }
        public void AddBank(Bank Bank)
        {
            BankRepository.Insert(Bank);
        }
        public Bank GetBank(long id)
        {
            return BankRepository.Get(id);
        }
        public void UpdateBank(Bank Bank)
        {
            BankRepository.Update(Bank);
        }

        public List<Bankcategory> GetAllBankcategory()
        {
            return BankcategoryRepository.GetQueryable().Include(b=>b.coa).ToList();
        }
        public List<Bankcategory> GetBankcategory()
        {
            return BankcategoryRepository.GetAll().ToList();
        }
        public void AddBankcategory(Bankcategory Bankcategory)
        {
            BankcategoryRepository.Insert(Bankcategory);
        }
        public Bankcategory GetBankcategory(long id)
        {
            return BankcategoryRepository.Get(id);
        }
        public void UpdateBankcategory(Bankcategory Bankcategory)
        {
            BankcategoryRepository.Update(Bankcategory);
        }

        public List<BankTxn> GetAllBankTxn()
        {
            return BankTxnRepository.GetQueryable().Include(a => a.Bank).ToList();
        }
        public List<BankTxn> GetBankTxn()
        {
            return BankTxnRepository.GetAll().ToList();
        }
        public void AddBankTxn(BankTxn BankTxn)
        {
            BankTxnRepository.Insert(BankTxn);
        }
        public BankTxn GetBankTxn(long id)
        {
            return BankTxnRepository.Get(id);
        }
        public void UpdateBankTxn(BankTxn BankTxn)
        {
            BankTxnRepository.Update(BankTxn);
        }
    }
}
