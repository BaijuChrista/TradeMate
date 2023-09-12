using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface ICreditCardService
    {
        List<CreditCard> GetAllCreditCard();
        void AddCreditCard(CreditCard CreditCard);
        CreditCard GetCreditCard(long id);
        void UpdateCreditCard(CreditCard CreditCard);
        List<CreditCard> GetCreditCard();

        List<CreditCardcategory> GetAllCreditCardcategory();
        List<CreditCardcategory> GetCreditCardcategory();
        void AddCreditCardcategory(CreditCardcategory CreditCardcategory);
        CreditCardcategory GetCreditCardcategory(long id);
        void UpdateCreditCardcategory(CreditCardcategory CreditCardcategory);

    }
}
