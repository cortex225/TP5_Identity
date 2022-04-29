﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP5_Identity.Data;

namespace TP5_Identity.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "34dddcad-e7a6-4c2d-ae20-5f9cab63d6d8",
                            ConcurrencyStamp = "1cc9404c-fb4e-45b1-bda7-50df6a1d593c",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "1dabe670-c1e1-48f7-91af-7101b9da5239",
                            ConcurrencyStamp = "bcf17e69-d424-4867-a750-cd8e8cefd8b2",
                            Name = "employe",
                            NormalizedName = "EMPLOYE"
                        },
                        new
                        {
                            Id = "377c13ba-3f90-48ad-bb51-5c19a8a666d7",
                            ConcurrencyStamp = "df23de59-58c9-47d2-9e2d-ce0673e62f4b",
                            Name = "client",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "3bfe7e3d-9a21-4ed7-b14d-991643154dc6",
                            RoleId = "34dddcad-e7a6-4c2d-ae20-5f9cab63d6d8"
                        },
                        new
                        {
                            UserId = "67d5cab1-785e-4636-8790-0814f102f423",
                            RoleId = "1dabe670-c1e1-48f7-91af-7101b9da5239"
                        },
                        new
                        {
                            UserId = "b3a36c86-fc08-4ee4-a2da-f58ec826503a",
                            RoleId = "377c13ba-3f90-48ad-bb51-5c19a8a666d7"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TP5_Identity.Models.Abonnement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("PrixMensuel")
                        .HasColumnType("real");

                    b.Property<int>("RabaisPourcentage")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abonnements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PrixMensuel = 0f,
                            RabaisPourcentage = 0,
                            Type = "Regulier"
                        },
                        new
                        {
                            Id = 2,
                            PrixMensuel = 50f,
                            RabaisPourcentage = 10,
                            Type = "Argent"
                        },
                        new
                        {
                            Id = 3,
                            PrixMensuel = 100f,
                            RabaisPourcentage = 15,
                            Type = "Or"
                        });
                });

            modelBuilder.Entity("TP5_Identity.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "3bfe7e3d-9a21-4ed7-b14d-991643154dc6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "08c1d9fe-efb1-4c4d-8c10-32ab0d8a84ef",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "90c46a95-c1e3-4a1a-9cce-d0f7df39f407",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("TP5_Identity.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateLocation")
                        .HasColumnType("datetime2");

                    b.Property<int>("DureeEnJours")
                        .HasColumnType("int");

                    b.Property<int>("VoitureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("VoitureId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("TP5_Identity.Models.Marque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marques");
                });

            modelBuilder.Entity("TP5_Identity.Models.Modele", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarqueId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MarqueId");

                    b.ToTable("Modeles");
                });

            modelBuilder.Entity("TP5_Identity.Models.Voiture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Annee")
                        .HasColumnType("int");

                    b.Property<string>("Couleur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModeleId")
                        .HasColumnType("int");

                    b.Property<double>("PrixJournalier")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ModeleId");

                    b.ToTable("Voitures");
                });

            modelBuilder.Entity("TP5_Identity.Models.Client", b =>
                {
                    b.HasBaseType("TP5_Identity.Models.ApplicationUser");

                    b.Property<int>("AbonnementId")
                        .HasColumnType("int");

                    b.HasIndex("AbonnementId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = "b3a36c86-fc08-4ee4-a2da-f58ec826503a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c5983229-4fe3-4773-9ce3-b762f1482db2",
                            Email = "client@client.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Nom = "client",
                            NormalizedEmail = "CLIENT@CLIENT.COM",
                            NormalizedUserName = "CLIENT@CLIENT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b79ef194-c530-4f79-803d-f9f0915089ad",
                            TwoFactorEnabled = false,
                            UserName = "client@client.com",
                            AbonnementId = 1
                        });
                });

            modelBuilder.Entity("TP5_Identity.Models.Employe", b =>
                {
                    b.HasBaseType("TP5_Identity.Models.ApplicationUser");

                    b.Property<DateTime>("DateEmbauche")
                        .HasColumnType("datetime2");

                    b.Property<int>("NoEmploye")
                        .HasColumnType("int");

                    b.ToTable("Employes");

                    b.HasData(
                        new
                        {
                            Id = "67d5cab1-785e-4636-8790-0814f102f423",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b65d21ee-f0e4-42d5-a411-01afe2a062e4",
                            Email = "employe@employe.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYE@EMPLOYE.COM",
                            NormalizedUserName = "EMPLOYE@EMPLOYE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP5A0+Sh49GqZJZev/DKqD7yieTvqVejrmGV0mV6PL5KNos4tLJnJL1tHceX7HezGA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b8d629a9-de34-4750-ab85-6a6a5c82f593",
                            TwoFactorEnabled = false,
                            UserName = "employe@employe.com",
                            DateEmbauche = new DateTime(2022, 4, 29, 18, 16, 55, 960, DateTimeKind.Local).AddTicks(3805),
                            NoEmploye = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TP5_Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TP5_Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP5_Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TP5_Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP5_Identity.Models.Location", b =>
                {
                    b.HasOne("TP5_Identity.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("TP5_Identity.Models.Voiture", "Voitures")
                        .WithMany("Locations")
                        .HasForeignKey("VoitureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Voitures");
                });

            modelBuilder.Entity("TP5_Identity.Models.Modele", b =>
                {
                    b.HasOne("TP5_Identity.Models.Marque", "Marque")
                        .WithMany()
                        .HasForeignKey("MarqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marque");
                });

            modelBuilder.Entity("TP5_Identity.Models.Voiture", b =>
                {
                    b.HasOne("TP5_Identity.Models.Modele", "Modele")
                        .WithMany()
                        .HasForeignKey("ModeleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modele");
                });

            modelBuilder.Entity("TP5_Identity.Models.Client", b =>
                {
                    b.HasOne("TP5_Identity.Models.Abonnement", "Abonnement")
                        .WithMany()
                        .HasForeignKey("AbonnementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP5_Identity.Models.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("TP5_Identity.Models.Client", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Abonnement");
                });

            modelBuilder.Entity("TP5_Identity.Models.Employe", b =>
                {
                    b.HasOne("TP5_Identity.Models.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("TP5_Identity.Models.Employe", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP5_Identity.Models.Voiture", b =>
                {
                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
