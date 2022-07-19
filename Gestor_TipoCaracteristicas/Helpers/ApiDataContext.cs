using Gestor_TipoCaracteristicas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gestor_TipoCaracteristicas.Helpers;

public class ApiDataContext : DbContext
{
    public ApiDataContext(DbContextOptions<ApiDataContext> options) : base(options)
    {
    }
    public DbSet<User>? Users { get; set; }
    public DbSet<Bank>? Banks { get; set; }
    public DbSet<Currency>? Currencies { get; set; }
    public DbSet<Provider>? Providers { get; set; }
    public DbSet<PropertyType>? PropertyTypes { get; set; } 
    public DbSet<Brand>? Brands { get; set; } 
    public DbSet<Asset>? Assets { get; set; }
    public DbSet<AssetType>? AssetTypes { get; set; }
    public DbSet<PropertyAsset>? PropertyAssets { get; set; }
    public DbSet<PropertyAssetType>? PropertyAssetTypes { get; set; }
    public DbSet<AssetClass>? AssetsClass { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        #region Db Settings
        var cascadeFKs = modelBuilder.Model.GetEntityTypes()
        .SelectMany(t => t.GetForeignKeys())
        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

        foreach (var fk in cascadeFKs)
            fk.DeleteBehavior = DeleteBehavior.Restrict;
        #endregion
        //modelBuilder.Entity<TipoCaracteristica>()
        //   .HasOne(p => p.Modelo)
        //   .WithMany(b => b.TipoCaracteristicas)

        #region Seed Demo Data
        //modelBuilder.Entity<TipoCaracteristica>().HasData(
        //    new TipoCaracteristica { Id = 1, Equipo = "Mouse Inhalambrico", Abreviatura = "msinha" }
        //     );
        #endregion
    }
}