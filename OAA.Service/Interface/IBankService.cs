using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IBankService
    {
        List<Bank> GetAllBank();
        void AddBank(Bank Bank);
        Bank GetBank(long id);
        void UpdateBank(Bank Bank);
        List<Bank> GetBank();

        List<Bankcategory> GetAllBankcategory();
        List<Bankcategory> GetBankcategory();
        void AddBankcategory(Bankcategory Bankcategory);
        Bankcategory GetBankcategory(long id);
        void UpdateBankcategory(Bankcategory Bankcategory);

        List<BankTxn> GetAllBankTxn();
        List<BankTxn> GetBankTxn();
        void AddBankTxn(BankTxn BankTxn);
        BankTxn GetBankTxn(long id);
        void UpdateBankTxn(BankTxn BankTxn);
    }
}
