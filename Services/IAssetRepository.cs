using AssetManager.Entities;

namespace AssetManager.Services
{
    public interface IAssetRepository
    {
        Task<IEnumerable<Asset>> GetAssetsAsync();

        Task<IEnumerable<Asset>> GetAllAssetsAsync();

        Task<IEnumerable<Asset>> GetAsset(string assetId);

        void CreateAsset(Asset asset);

        void UpdateAsset(Guid id, Asset asset);

        void DeleteAsset(Guid id);

        Task<bool> SaveChangesAsync();
    }
}
