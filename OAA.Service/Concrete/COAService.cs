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
   public class COAService : ICOAService
    {
        private IRepository<coa> CoaRepository;
        private IRepository<COAType> COATypeRepository;
        private IRepository<ledger> LedgerRepository;
        private IRepository<ledgertxn> LedgertxnRepository;
        private IRepository<Payment> PaymentRepository;
        private IRepository<Receipt> ReceiptRepository;

        private IRepository<PaymentTransactions> PaymentTransactionsRepository;
        private IRepository<ReceiptTransactions> ReceiptTransactionsRepository;
        public COAService(IRepository<coa> coaRepository, IRepository<ledger> ledgerRepository, IRepository<ledgertxn> ledgertxnRepository,
            IRepository<COAType> coatyperepository, IRepository<Payment> paymentrepository, IRepository<Receipt> receiptRepository, IRepository<PaymentTransactions> paymentTranrepository, IRepository<ReceiptTransactions> receiptTranRepository)
        {
            this.CoaRepository = coaRepository;
            this.LedgerRepository = ledgerRepository;
            this.LedgertxnRepository = ledgertxnRepository;
            this.COATypeRepository = coatyperepository;
            this.PaymentRepository = paymentrepository;
            this.ReceiptRepository = receiptRepository;
            this.ReceiptTransactionsRepository = receiptTranRepository;
            this.PaymentTransactionsRepository = paymentTranrepository;
        }

        public List<coa> GetAllcoa()
        {
            return CoaRepository.GetQueryable().Include(b => b.COAType).Include(b=>b.COAType.Coabase).ToList();
        }
        public List<coa> Getcoa()
        {
            return CoaRepository.GetAll().ToList();
        }
        public void Addcoa(coa coa)
        {
            CoaRepository.Insert(coa);
        }
        public coa Getcoa(long id)
        {
            return CoaRepository.Get(id);
        }
        public void Updatecoa(coa coa)
        {
            CoaRepository.Update(coa);
        }


        public List<ledger> GetAllledger()
        {
            return LedgerRepository.GetQueryable().Include(b => b.coa).Include(b => b.coa.COAType).ToList();
        }
        public List<ledger> Getledger()
        {
            return LedgerRepository.GetAll().ToList();
        }
        public void Addledger(ledger ledger)
        {
            LedgerRepository.Insert(ledger);
        }
        public ledger Getledger(long id)
        {
            return LedgerRepository.Get(id);
        }
        public void Updateledger(ledger ledger)
        {
            LedgerRepository.Update(ledger);
        }

        public List<ledgertxn> GetAlllLedgertxn()
        {
            return LedgertxnRepository.GetQueryable().Include(b => b.ledger).Include(b => b.ledger.coa).ToList();
        }
        public List<ledgertxn> GetLedgertxn()
        {
            return LedgertxnRepository.GetAll().ToList();
        }
        public void AddLedgertxn(ledgertxn ledgertxn)
        {
            LedgertxnRepository.Insert(ledgertxn);
        }
        public ledgertxn GetLedgertxn(long id)
        {
            return LedgertxnRepository.Get(id);
        }
        public void UpdateLedgertxn(ledgertxn ledgertxn)
        {
            LedgertxnRepository.Update(ledgertxn);
        }

        public List<COAType> GetAllCOAType()
        {
            return COATypeRepository.GetQueryable().Include(b => b.Coabase).ToList();
        }

        public Payment GetPayment(long Id)
        {
            return PaymentRepository.Get(Id);
        }
        public void UpdatePayment(Payment Payment)
        {
            PaymentRepository.Update(Payment);
        }
        public List<Payment> GetAllPayment()
        {
            return PaymentRepository.GetQueryable().Include(b => b.ledger).ToList();
        }
        public void AddPayment(Payment Payment)
        {
            PaymentRepository.Insert(Payment);
        }
        public Receipt GetReceipt(long Id)
        {
            return ReceiptRepository.Get(Id);
        }
        public void UpdateReceipt(Receipt Receipt)
        {
            ReceiptRepository.Update(Receipt);
        }
        public List<Receipt> GetAllReceipt()
        {
            return ReceiptRepository.GetQueryable().Include(b => b.ledger).ToList();
        }
        public void AddReceipt(Receipt Receipt)
        {
            ReceiptRepository.Insert(Receipt);
        }
        public object gettrialbalance()
        {
            return LedgertxnRepository.GetAll().Where(x=>(x.dr-x.cr)!=0).Include(x => x.ledger).ThenInclude(x => x.coa).ThenInclude(x=>x.COAType).ThenInclude(x=>x.Coabase).GroupBy(x => x.ledger.coaId).Select(x => new
            {
                COATypeName = x.Max(y => y.ledger.coa.COAType.name),
                dr = x.Sum(y => y.dr),
                name = x.Max(y => y.ledger.coa.name),
                cr = x.Sum(y => y.cr),
                COABase= x.Max(y => y.ledger.coa.COAType.Coabase.name),

            }).ToList();


        }
        public object getBalanceSheet()
        {
            return LedgertxnRepository.GetAll().Where(x=>x.ledger.coa.COAType.Coabase.fs==1).Include(x => x.ledger).ThenInclude(x => x.coa).ThenInclude(x => x.COAType).ThenInclude(x => x.Coabase).GroupBy(x => x.ledger.coaId).Select(x => new
            {
                COATypeName = x.Max(y => y.ledger.coa.COAType.name),
                dr = x.Sum(y => y.dr),
                cr=x.Sum(y => y.cr),
                name = x.Max(y => y.ledger.coa.name),               
                COABase = x.Max(y => y.ledger.coa.COAType.Coabase.name),
            }).ToList();


        }
        public object getPandL()
        {
            return LedgertxnRepository.GetAll().Where(x => x.ledger.coa.COAType.Coabase.fs == 2).Include(x => x.ledger).ThenInclude(x => x.coa).ThenInclude(x => x.COAType).ThenInclude(x => x.Coabase).GroupBy(x => x.ledger.coaId).Select(x => new
            {
                COATypeName = x.Max(y => y.ledger.coa.COAType.name),
                dr = x.Sum(y => y.dr),
                name = x.Max(y => y.ledger.coa.name),
                cr = x.Sum(y => y.cr),
                COABase = x.Max(y => y.ledger.coa.COAType.Coabase.name),

            }).ToList();


        }
        public object getPandL(DateTime from, DateTime to)
        {
            return LedgertxnRepository.GetAll().Where(x => x.ledger.coa.COAType.Coabase.fs == 2 && (x.txndate >= from && x.txndate <= to)).Include(x => x.ledger).ThenInclude(x => x.coa).ThenInclude(x => x.COAType).ThenInclude(x => x.Coabase).GroupBy(x => x.ledger.coaId).Select(x => new
            {
                COATypeName = x.Max(y => y.ledger.coa.COAType.name),
                dr = x.Sum(y => y.dr),
                name = x.Max(y => y.ledger.coa.name),
                cr = x.Sum(y => y.cr),
                COABase = x.Max(y => y.ledger.coa.COAType.Coabase.name),
            }).ToList();
        }

        public void AddPaymentTransactions(PaymentTransactions PaymentTransactions)
        {
            PaymentTransactionsRepository.Insert(PaymentTransactions);
        }

        public void AddReceiptTransactions(ReceiptTransactions ReceiptTransactions)
        {
            ReceiptTransactionsRepository.Insert(ReceiptTransactions);
        }

        public List<PaymentTransactions> GetPaymentTransactions()
        {
            return PaymentTransactionsRepository.GetQueryable().Include(b => b.Payment).ToList();
        }

        public List<ReceiptTransactions> GetReceiptTransactions()
        {
            return ReceiptTransactionsRepository.GetQueryable().Include(b => b.Receipt).ToList();
        }
    }
}

