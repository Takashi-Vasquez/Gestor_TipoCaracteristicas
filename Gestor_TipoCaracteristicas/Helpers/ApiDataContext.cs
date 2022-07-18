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
    public DbSet<TipoCaracteristica>? TipoCaracteristicas { get; set; }
    public DbSet<Marca>? Marca { get; set; }
    public DbSet<TipoActivo>? TipoActivo { get; set; }
    public DbSet<CaracteristicasActivo>? CaracteristicasActivo { get; set; }
    public DbSet<CaracteristicasTipoActivo>? CaracteristicasTipoActivo { get; set; }
    public DbSet<ClaseActivo>? ClaseActivo { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<TipoCaracteristica>()
        //   .HasOne(p => p.Modelo)
        //   .WithMany(b => b.TipoCaracteristicas)

        #region Seed Demo Data
        //modelBuilder.Entity<TipoCaracteristica>().HasData(
        //    new TipoCaracteristica { Id = 1, Equipo = "Mouse Inhalambrico", Abreviatura = "msinha" }
        //     );
        #endregion
    //}
}