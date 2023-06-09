﻿// <auto-generated />
using System;
using GastosPersonales.AccesoDatos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GastosPersonales.AccesoDatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GastosPersonales.Models.Models.Categoria", b =>
                {
                    b.Property<int>("Categoria_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Categoria_Id"));

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Categoria_Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("GastosPersonales.Models.Models.Transaccion", b =>
                {
                    b.Property<int>("Transaccion_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Transaccion_Id"));

                    b.Property<int>("Categoria_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDeTransaccion")
                        .HasColumnType("datetime2");

                    b.Property<float>("MontoDeTransaccion")
                        .HasColumnType("real");

                    b.Property<int>("Usuario_Id")
                        .HasColumnType("int");

                    b.HasKey("Transaccion_Id");

                    b.HasIndex("Categoria_Id");

                    b.HasIndex("Usuario_Id");

                    b.ToTable("Transaccion");
                });

            modelBuilder.Entity("GastosPersonales.Models.Models.Usuario", b =>
                {
                    b.Property<int>("Usuario_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Usuario_Id"));

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Usuario_Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("GastosPersonales.Models.Models.Transaccion", b =>
                {
                    b.HasOne("GastosPersonales.Models.Models.Categoria", "Categoria")
                        .WithMany("Transacciones")
                        .HasForeignKey("Categoria_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GastosPersonales.Models.Models.Usuario", "Usuario")
                        .WithMany("Transacciones")
                        .HasForeignKey("Usuario_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GastosPersonales.Models.Models.Categoria", b =>
                {
                    b.Navigation("Transacciones");
                });

            modelBuilder.Entity("GastosPersonales.Models.Models.Usuario", b =>
                {
                    b.Navigation("Transacciones");
                });
#pragma warning restore 612, 618
        }
    }
}
