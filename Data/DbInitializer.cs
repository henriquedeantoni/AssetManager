using AssetManager.Entities;
using Microsoft.Extensions.Hosting;

namespace AssetManager.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (context.Assets.Any()) return;

            var assets = new List<Asset>
            {
                new Asset
                {
                    AssetId = new Guid(),
                    AssetName = "Caminhão Baú Volvo",
                    AssetCategory = "Veicular",
                    Description = "Este ativo foi adquirido atraves do consórcio",
                    SerialNumber = "12SD1VEC13201",
                    PurchaseDate = DateTime.Now,
                    Cost = 28680000,
                    Location = "Unidade A",
                    Status = AssetStatus.Active,
                    AssignedUserId = new Guid(),
                    AssignedUser = null,
                    MaintenancesList = { },
                },
                new Asset
                {
                    AssetId = new Guid(),
                    AssetName = "Caminhão Mercedes",
                    AssetCategory = "Veicular",
                    Description = "Este ativo foi adquirido atraves do consórcio",
                    SerialNumber = "28SD2VEC13101",
                    PurchaseDate = DateTime.Now,
                    Cost = 32550000,
                    Location = "Unidade A",
                    Status = AssetStatus.Active,
                    AssignedUserId = new Guid(),
                    AssignedUser = null,
                    MaintenancesList = null,
                },
                new Asset
                {
                    AssetId = new Guid(),
                    AssetName = "Fonte Solda Fronius",
                    AssetCategory = "Maquina Solda",
                    Description = "Fonte de solda para setor de manutenção",
                    SerialNumber = "02MN4SOL04319",
                    PurchaseDate = DateTime.Now,
                    Cost = 750000,
                    Location = "Unidade B",
                    Status = AssetStatus.Active,
                    AssignedUserId = new Guid(),
                    AssignedUser = null,
                    MaintenancesList = null,
                },
                new Asset
                {
                    AssetId = new Guid(),
                    AssetName = "Fonte Solda Fronius",
                    AssetCategory = "Maquina Solda",
                    Description = "Fonte de solda para setor de manutenção",
                    SerialNumber = "02MN4SOL04319",
                    PurchaseDate = DateTime.Now,
                    Cost = 750000,
                    Location = "Unidade B",
                    Status = AssetStatus.Active,
                    AssignedUserId = new Guid(),
                    AssignedUser = null,
                    MaintenancesList = null,
                },
            };

            context.Assets.AddRange(assets);

            context.SaveChanges();
        }
    }
}
