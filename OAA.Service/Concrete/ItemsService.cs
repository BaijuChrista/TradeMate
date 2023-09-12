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
    public class ItemsService : IItemService
    {
        private IRepository<ItemMaster> ItemMasterRepository;
        private IRepository<StockMaster> StockMasterRepository;
        private IRepository<ItemImage> ItemImageRepository;
        private IRepository<ScrollText> ScrollTextRepository;
        private IRepository<ItemBrand> ItemBrandRepository; 
        public ItemsService(IRepository<ItemMaster> itemMasterRepository,  IRepository<StockMaster> stockMasterRepository,
            IRepository<ItemImage> itemImageRepository, IRepository<ItemBrand> itemBrandRepository, IRepository<ScrollText> iScrollTextRepository)
        {
            this.ItemMasterRepository = itemMasterRepository;
            this.StockMasterRepository = stockMasterRepository;
            this.ItemImageRepository = itemImageRepository;
            this.ItemBrandRepository = itemBrandRepository;
            ScrollTextRepository = iScrollTextRepository;

        }
        public List<ItemMaster> GetAllItemMaster()
        {
            return ItemMasterRepository.GetQueryable().Include(b => b.ItemCategory).Include(b => b.TaxMaster).Include(b => b.ApplicationUser).Include(x => x.ApplicationUser.Company).Include(b=>b.ItemCategory).Include(b=>b.ItemBrand).ToList();
        }
        public List<ItemMaster> GetItemMaster()
        {
            return ItemMasterRepository.GetAll().ToList();
        }
        public void AddItemMaster(ItemMaster ItemMaster)
        {
            ItemMasterRepository.Insert(ItemMaster);
        }
        public void DeleteItemMaster(ItemMaster ItemMaster)
        {
            ItemMasterRepository.Delete(ItemMaster);
        }
        public ItemMaster GetItemMaster(long id)
        {
            return ItemMasterRepository.Get(id);
        }
        public void UpdateItemMaster(ItemMaster ItemMaster)
        {
            ItemMasterRepository.Update(ItemMaster);
        }        

        public List<StockList> GetAllStockMaster()
        {
            var result = StockMasterRepository.GetAll().Include(x => x.ItemMaster).ThenInclude(x => x.ItemCategory).GroupBy(x => x.ItemMasterId).Select(x => new StockList
            {
                ItemId=x.Max(y=>y.ItemMasterId),
               categoryName = x.Max(y => y.ItemMaster.ItemCategory.CategoryName),             
               Stock = x.Sum(y => y.stock),
               ItemCode = x.Max(y => y.ItemMaster.ItemCode),
                ItemName = x.Max(y => y.ItemMaster.ItemName),
                PurPrice = x.Sum(y => y.PurPrice),
                brnadname= x.Max(y => y.ItemMaster.ItemBrand.brnadname)

            }).ToList();
            return result;

           

        }
        public List<StockMaster> GetStockMaster()
        {
            return StockMasterRepository.GetAll().Include(x=>x.ItemMaster).ToList();
        }
        public void AddStockMaster(StockMaster StockMaster)
        {
            StockMasterRepository.Insert(StockMaster);
        }
        public StockMaster GetStockMaster(long id)
        {
            return StockMasterRepository.Get(id);
        }
        public void UpdateStockMaster(StockMaster StockMaster)
        {
            StockMasterRepository.Update(StockMaster);
        }

        public List<ItemImage> GetAllItemImage()
        {
            return ItemImageRepository.GetQueryable().ToList();
        }
        public void AddItemImage(ItemImage ItemImage)
        {
            ItemImageRepository.Insert(ItemImage);
        }
        public ItemImage GetItemImage(long id)
        {
            return ItemImageRepository.GetQueryable(id).Include(x => x.ItemMaster).FirstOrDefault();
        }
        public void UpdateItemImage(ItemImage ItemImage)
        {
            ItemImageRepository.Update(ItemImage);
        }
        public List<ItemImage> GetItemImage()
        {
            return ItemImageRepository.GetAll().Include(b => b.ItemMaster).Include(c => c.ItemMaster).ToList();
        }

        public List<ItemBrand> GetAllItemBrand()
        {
            return ItemBrandRepository.GetQueryable().ToList();
        }
        public void AddItemBrand(ItemBrand ItemBrand)
        {
            ItemBrandRepository.Insert(ItemBrand);
        }
        public ItemBrand GetItemBrand(long id)
        {
            return ItemBrandRepository.GetQueryable(id).FirstOrDefault();
        }
        public void UpdateItemBrand(ItemBrand ItemBrand)
        {
            ItemBrandRepository.Update(ItemBrand);
        }
        public List<ItemBrand> GetItemBrand()
        {
            return ItemBrandRepository.GetAll().ToList();
        }

        public List<ScrollText> GetAllScrollText()
        {
            return ScrollTextRepository.GetAll().ToList();
        }

        public void AddScrollText(ScrollText ScrollText)
        {
            ScrollTextRepository.Insert(ScrollText);
        }

        public void UpdateScrollText(ScrollText ScrollText)
        {
            ScrollTextRepository.Update(ScrollText);
        }
    }
}
