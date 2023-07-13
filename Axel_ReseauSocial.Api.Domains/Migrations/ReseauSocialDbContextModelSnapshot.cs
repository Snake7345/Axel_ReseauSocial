﻿// <auto-generated />
using System;
using Axel_ReseauSocial.Api.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    [DbContext(typeof(ReseauSocialDbContext))]
    partial class ReseauSocialDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Localite", b =>
                {
                    b.Property<int>("IdLocalite")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLocalite"), 1L, 1);

                    b.Property<int>("CP")
                        .HasColumnType("int");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("IdLocalite");

                    b.ToTable("Localite", (string)null);
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRole"), 1L, 1);

                    b.Property<string>("Denomination")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("IdRole");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            IdRole = 1,
                            Denomination = "Admin"
                        },
                        new
                        {
                            IdRole = 2,
                            Denomination = "User"
                        });
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Utilisateur", b =>
                {
                    b.Property<Guid>("IdUtilisateur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<bool>("Actif")
                        .HasColumnType("BIT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(384)");

                    b.Property<int>("LocaliteId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(75)");

                    b.Property<byte[]>("Passwd")
                        .IsRequired()
                        .HasColumnType("BINARY(64)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(75)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(10)");

                    b.HasKey("IdUtilisateur");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LocaliteId");

                    b.HasIndex("RoleId");

                    b.ToTable("Utilisateur", (string)null);
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Utilisateur", b =>
                {
                    b.HasOne("Axel_ReseauSocial.Api.Models.Localite", "Localite")
                        .WithMany()
                        .HasForeignKey("LocaliteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Axel_ReseauSocial.Api.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Localite");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
