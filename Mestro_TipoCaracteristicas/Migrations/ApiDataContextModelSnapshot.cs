﻿// <auto-generated />
using Maestro_TipoCaracteristicas.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Maestro_TipoCaracteristicas.Migrations
{
    [DbContext(typeof(ApiDataContext))]
    partial class ApiDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Maestro_TipoCaracteristicas.Entities.TipoCaracteristica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abreviatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Abreviatura");

                    b.Property<string>("Equipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Equipo");

                    b.HasKey("Id");

                    b.ToTable("TipoCaracteristica");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abreviatura = "msinha",
                            Equipo = "Mouse Inhalambrico"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
