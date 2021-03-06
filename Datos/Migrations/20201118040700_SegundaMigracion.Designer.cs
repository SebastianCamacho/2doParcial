﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(RegistrosContext))]
    [Migration("20201118040700_SegundaMigracion")]
    partial class SegundaMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Pago", b =>
                {
                    b.Property<string>("IdDePago")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("TipoDePago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorDePago")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorIva")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("personaNumeroDeDocumento")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdDePago");

                    b.HasIndex("personaNumeroDeDocumento");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Entity.Persona", b =>
                {
                    b.Property<string>("NumeroDeDocumento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NumeroDeDocumento");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Entity.Pago", b =>
                {
                    b.HasOne("Entity.Persona", "persona")
                        .WithMany("Pagos")
                        .HasForeignKey("personaNumeroDeDocumento");
                });
#pragma warning restore 612, 618
        }
    }
}
