using System;
using System.Collections.Generic;
using System.Text;
using SC.Data;
namespace SC.Service.Interface
{
    public interface IItemService
    {
        List<ItemMaster> GetAllItemMaster();
        void AddItemMaster(ItemMaster ItemMaster);
        ItemMaster GetItemMaster(long id);
        void UpdateItemMaster(ItemMaster ItemMaster);
        void DeleteItemMaster(ItemMaster ItemMaster);
        List<ItemMaster> GetItemMaster();




        List<StockList> GetAllStockMaster();
        void AddStockMaster(StockMaster StockMaster);
        StockMaster GetStockMaster(long id);
        void UpdateStockMaster(StockMaster StockMaster);
        List<StockMaster> GetStockMaster();

       

        List<ItemImage> GetAllItemImage();
        void AddItemImage(ItemImage ItemImage);
        ItemImage GetItemImage(long id);
        void UpdateItemImage(ItemImage ItemImage);
        List<ItemImage> GetItemImage();

        List<ItemBrand> GetAllItemBrand();
        void AddItemBrand(ItemBrand ItemBrand);
        ItemBrand GetItemBrand(long id);
        void UpdateItemBrand(ItemBrand ItemBrand);
        List<ItemBrand> GetItemBrand();

        List<ScrollText> GetAllScrollText();
        void AddScrollText(ScrollText ScrollText);
        void UpdateScrollText(ScrollText ScrollText);
        
    }
}
