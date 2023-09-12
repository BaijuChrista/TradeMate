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
   public class AssetService : IAssetService
    {
        private IRepository<Asset> AssetRepository;
        private IRepository<AssetCategory> AssetCategoryRepository;
        private IRepository<partner> _partnerRepository;
        public AssetService(IRepository<Asset> assetRepository, IRepository<AssetCategory> assetCategoryRepository,IRepository<partner> partnerrepository)
        {
            this.AssetRepository = assetRepository;
            this.AssetCategoryRepository = assetCategoryRepository;
            _partnerRepository = partnerrepository;
        }

        public List<Asset> GetAllAsset()
        {
            return AssetRepository.GetQueryable().Include(b => b.AssetCategory).ToList();
        }
        public List<Asset> GetAsset()
        {
            return AssetRepository.GetAll().ToList();
        }
        public void AddAsset(Asset Asset)
        {
            AssetRepository.Insert(Asset);
        }
        public Asset GetAsset(long id)
        {
            return AssetRepository.Get(id);
        }
        public void UpdateAsset(Asset Asset)
        {
            AssetRepository.Update(Asset);
        }


        public List<AssetCategory> GetAllAssetCategory()
        {
            return AssetCategoryRepository.GetQueryable().ToList();
        }
        public List<AssetCategory> GetAssetCategory()
        {
            return AssetCategoryRepository.GetAll().ToList();
        }
        public void AddAssetCategory(AssetCategory AssetCategory)
        {
            AssetCategoryRepository.Insert(AssetCategory);
        }
        public AssetCategory GetAssetCategory(long id)
        {
            return AssetCategoryRepository.Get(id);
        }
        public void UpdateAssetCategory(AssetCategory AssetCategory)
        {
            AssetCategoryRepository.Update(AssetCategory);
        }


        public void AddPartner(partner partner)
        {
            _partnerRepository.Insert(partner);
        }
    }
}
