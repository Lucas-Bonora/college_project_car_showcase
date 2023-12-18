﻿// <auto-generated />
using System;
using BonosCarrosWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BonosCarrosWeb.Data.Migrations
{
    [DbContext(typeof(CarrosDbContext))]
    [Migration("20231211225953_AdicionarTabelaDesigners")]
    partial class AdicionarTabelaDesigners
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BonosCarrosWeb.Models.Carro", b =>
                {
                    b.Property<int>("CarroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarroId"));

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Disponibilidade")
                        .HasColumnType("bit");

                    b.Property<string>("ImgUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("CarroId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("BonosCarrosWeb.Models.Designer", b =>
                {
                    b.Property<int>("DesignerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignerId"));

                    b.Property<int?>("CarroId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesignerId");

                    b.HasIndex("CarroId");

                    b.ToTable("Designer");
                });

            modelBuilder.Entity("BonosCarrosWeb.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("BonosCarrosWeb.Models.Carro", b =>
                {
                    b.HasOne("BonosCarrosWeb.Models.Marca", null)
                        .WithMany("ListaCarros")
                        .HasForeignKey("MarcaId");
                });

            modelBuilder.Entity("BonosCarrosWeb.Models.Designer", b =>
                {
                    b.HasOne("BonosCarrosWeb.Models.Carro", null)
                        .WithMany("ListaDesigners")
                        .HasForeignKey("CarroId");
                });

            modelBuilder.Entity("BonosCarrosWeb.Models.Carro", b =>
                {
                    b.Navigation("ListaDesigners");
                });

            modelBuilder.Entity("BonosCarrosWeb.Models.Marca", b =>
                {
                    b.Navigation("ListaCarros");
                });
#pragma warning restore 612, 618
        }
    }
}
