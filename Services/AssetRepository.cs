using AssetManager.Data;
using AssetManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssetManager.Services
{
    public class AssetRepository : IAssetRepository
    {
        private readonly DataContext _context;

        public AssetRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        
        public async Task<IEnumerable<Asset>> GetAssetsAsync()
        {
            var assets = await _context.Assets
                .Include(x => x.MaintenancesList)
                .ToListAsync();

            return assets;
        }


    }
}
