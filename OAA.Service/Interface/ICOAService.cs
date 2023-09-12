using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface ICOAService
    {

        List<coa> GetAllcoa();
        void Addcoa(coa coa);
        coa Getcoa(long id);
        void Updatecoa(coa coa);
        List<coa> Getcoa();

        List<ledger> GetAllledger();
        List<ledger> Getledger();
        void Addledger(ledger ledger);
        ledger Getledger(long id);
        void Updateledger(ledger ledger);

        List<ledgertxn> GetAlllLedgertxn();
        List<ledgertxn> GetLedgertxn();
        void AddLedgertxn(ledgertxn ledgertxn);
        ledgertxn GetLedgertxn(long id);
        void UpdateLedgertxn(ledgertxn ledgertxn);

        List<COAType> GetAllCOAType();
        Payment GetPayment(long Id);
        void UpdatePayment(Payment Payment);
        List<Payment> GetAllPayment();


        void AddPayment(Payment Payment);
        void UpdateReceipt(Receipt Receipt);
        void AddReceipt(Receipt Receipt);
        Receipt GetReceipt(long Id);
        List<Receipt> GetAllReceipt();

        void AddPaymentTransactions(PaymentTransactions PaymentTransactions);
        void AddReceiptTransactions(ReceiptTransactions ReceiptTransactions);
        List<PaymentTransactions> GetPaymentTransactions();
        List<ReceiptTransactions> GetReceiptTransactions();

        object gettrialbalance();
        object getBalanceSheet();
        object getPandL();
        object getPandL(DateTime from, DateTime to);
    }
}
