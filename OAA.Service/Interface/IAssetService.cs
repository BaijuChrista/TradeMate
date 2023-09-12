using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface IAssetService
    {
        

        List<AssetCategory> GetAllAssetCategory();
        void AddAssetCategory(AssetCategory AssetCategory);
        AssetCategory GetAssetCategory(long id);
        void UpdateAssetCategory(AssetCategory AssetCategory);
        List<AssetCategory> GetAssetCategory();


        List<Asset> GetAllAsset();
        void AddAsset(Asset Asset);
        Asset GetAsset(long id);
        void UpdateAsset(Asset Asset);
        List<Asset> GetAsset();

        void AddPartner(partner partner);
    }
}
