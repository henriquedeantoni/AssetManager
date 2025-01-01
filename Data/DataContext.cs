using AssetManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssetManager.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) { }

        public DbSet<Asset> Assets { get; set; }

        public DbSet<Maintenance> Maintenances { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>()
                .HasMany(a => a.MaintenancesList)
                .WithOne(a => a.Asset)
                .HasForeignKey(a => a.AssetId);

            modelBuilder.Entity<User>()
                .HasMany(a => a.MaintenancesList)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);            
        }
    }
}
