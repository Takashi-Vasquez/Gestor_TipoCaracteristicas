﻿using Gestor_TipoCaracteristicas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gestor_TipoCaracteristicas.Helpers;

public class ApiDataContext : DbContext
{
    public ApiDataContext(DbContextOptions<ApiDataContext> options) : base(options)
    {
    }

    public DbSet<TipoCaracteristica>? TipoCaracteristicas { get; set; }
    public DbSet<Modelo>? Modelos { get; set; }

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