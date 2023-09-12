using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace SC.Data
{      
    public class ItemMaster :AuditDetail
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        [ForeignKey("ItemCategory")]
        public Int64 CategoryId { get; set; }
        public virtual ItemCategory ItemCategory { get; set; }
        [ForeignKey("TaxMaster")]
        public Int64 TaxMasterId { get; set; }
        public virtual TaxMaster TaxMaster { get; set; }
        public double Price { get; set; }
        public double Offerprice { get; set; }        
        public string Description { get; set; }       
        public string ProductCode { get; set; }       
        public string BarCode { get; set; }
        public double qty { get; set; }
        public double Maxqty { get; set; }
        public double rol { get; set; }
        [ForeignKey("ItemBrand")]
        public Int64 ItemBrandId { get; set; }
        public virtual ItemBrand ItemBrand { get; set; }
        public double PurPrice { get; set; }
        public double SalesPrice { get; set; }
        public double MobilePrice { get; set; }
        public double BaqalaPrice { get; set; }
        public double StationaryPrice { get; set; }
        public bool Showcart { get; set; }
        public bool Showsite { get; set; }
        public int type { get; set; }

    }
    public class StockMaster : AuditDetail
    {
        [ForeignKey("ItemMaster")]
        public Int64 ItemMasterId { get; set; }
        public virtual ItemMaster ItemMaster { get; set; }
        public double stock { get; set; }
        public double PurPrice { get; set; }
    }   
    public class ItemImage:AuditDetail
    {
        [ForeignKey("ItemMaster")]
        public Int64 ItemMasterId { get; set; }
        public virtual ItemMaster ItemMaster { get; set; }
        public string zoom { get; set; }
        public string thumb { get; set; }
        public int sortorder { get; set; }
    }

    public class ItemBrand : AuditDetail
    {
        public string brnadname { get; set; }
        public string details { get; set; }
    }

    public class StockList
    {
        public long ItemId { get; set; }
        public string  categoryName { get; set; }
        public string ItemCode { get; set; }
        public double  Stock { get; set; }
        public string ItemName { get; set; }
        public double PurPrice { get; set; }
        public string brnadname { get; set; }
        public DateTime Date { get; set; }
    }
    public class GetItemInfo_Trademate
    {

        public Int64 Id { get; set; }
        public string code { get; set; }
        public string ItemName { get; set; }
        public string Invoiceno { get; set; }
        public string type { get; set; }
        public double count { get; set; }
        public double amount { get; set; }
        public string customer { get; set; }
        public string created { get; set; }
        public DateTime date { get; set; }
        
    }

    public class GetProduct_Trademate
    {
        public Int64 Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public Int64 CategoryId { get; set; }
        public Int64 TaxMasterId { get; set; }
        public double Price { get; set; }
        public double Offerprice { get; set; }
        public double MobilePrice { get; set; }
        public double BaqalaPrice { get; set; }
        public double StationaryPrice { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public string thumb { get; set; }
        public string BarCode { get; set; }
        public double qty { get; set; }
        public double Maxqty { get; set; }
        public double rol { get; set; }
        public Int64 ItemBrandId { get; set; }
        public double PurPrice { get; set; }
        public double SalesPrice { get; set; }
        public int type { get; set; }
    }
}
