﻿// <auto-generated />
using System;
using Axel_ReseauSocial.Api.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    [DbContext(typeof(ReseauSocialDbContext))]
    [Migration("20230817073257_CorrectionAmitie")]
    partial class CorrectionAmitie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Amitie", b =>
                {
                    b.Property<Guid>("IdAmitie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<bool?>("Attente")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValue(true);

                    b.Property<Guid>("DestinataireId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DestinateurId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdAmitie");

                    b.HasIndex("DestinataireId");

                    b.HasIndex("DestinateurId");

                    b.ToTable("Amitie", (string)null);
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Commentaire", b =>
                {
                    b.Property<Guid>("IdCommentaire")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("PublicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Texte")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(2000)");

                    b.Property<Guid>("UtilisateurId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdCommentaire");

                    b.HasIndex("PublicationId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Commentaire", (string)null);
                });

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

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Publication", b =>
                {
                    b.Property<Guid>("IdPublication")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Texte")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(2000)");

                    b.Property<Guid>("UtilisateurId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdPublication");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Publication", (string)null);
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Pv", b =>
                {
                    b.Property<Guid>("IdPv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("DestinataireId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DestinateurId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Texte")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(2000)");

                    b.HasKey("IdPv");

                    b.HasIndex("DestinataireId");

                    b.HasIndex("DestinateurId");

                    b.ToTable("Pv", (string)null);
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

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Travail", b =>
                {
                    b.Property<int>("IdTravail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTravail"), 1L, 1);

                    b.Property<string>("Denomination")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.HasKey("IdTravail");

                    b.ToTable("Travail", (string)null);
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Utilisateur", b =>
                {
                    b.Property<Guid>("IdUtilisateur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<bool?>("Actif")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValue(true);

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

                    b.Property<int>("TravailId")
                        .HasColumnType("int");

                    b.HasKey("IdUtilisateur");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LocaliteId");

                    b.HasIndex("RoleId");

                    b.HasIndex("TravailId");

                    b.ToTable("Utilisateur", (string)null);
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Amitie", b =>
                {
                    b.HasOne("Axel_ReseauSocial.Api.Models.Utilisateur", "Destinataire")
                        .WithMany()
                        .HasForeignKey("DestinataireId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Axel_ReseauSocial.Api.Models.Utilisateur", "Destinateur")
                        .WithMany()
                        .HasForeignKey("DestinateurId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Destinataire");

                    b.Navigation("Destinateur");
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Commentaire", b =>
                {
                    b.HasOne("Axel_ReseauSocial.Api.Models.Publication", "Publication")
                        .WithMany()
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Axel_ReseauSocial.Api.Models.Utilisateur", "Utilisateur")
                        .WithMany()
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Publication");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Publication", b =>
                {
                    b.HasOne("Axel_ReseauSocial.Api.Models.Utilisateur", "Utilisateur")
                        .WithMany()
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("Axel_ReseauSocial.Api.Models.Pv", b =>
                {
                    b.HasOne("Axel_ReseauSocial.Api.Models.Utilisateur", "Destinataire")
                        .WithMany()
                        .HasForeignKey("DestinataireId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Axel_ReseauSocial.Api.Models.Utilisateur", "Destinateur")
                        .WithMany()
                        .HasForeignKey("DestinateurId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Destinataire");

                    b.Navigation("Destinateur");
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

                    b.HasOne("Axel_ReseauSocial.Api.Models.Travail", "Travail")
                        .WithMany()
                        .HasForeignKey("TravailId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Localite");

                    b.Navigation("Role");

                    b.Navigation("Travail");
                });
#pragma warning restore 612, 618
        }
    }
}
