using System;
using System.Globalization;

namespace SC.Data
{

    public class AppSettings
    {
        public string Secret { get; set; }
        public string MotherCompanyImagepath { get; set; }
        public string ItemImagepath { get; set; }
        public string SupplierImagepath { get; set; }
        public string ShipmentImagepath { get; set; }
        public string CartCustomer { get; set; }
        public string ShopingCustomer { get; set; }
        public string ServiceCustomer { get; set; }
        public string CompanyAddress { get; set; }
    }

}