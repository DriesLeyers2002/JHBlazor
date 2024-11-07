﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jeugdhuis.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241101122221_AddIsActiveOnBoardMember")]
    partial class AddIsActiveOnBoardMember
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Jeugdhuis.Models.Boardmember", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7e70073f-29a0-48bd-aab6-623f95c40e97",
                            Email = "dries@example.com",
                            EmailConfirmed = true,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DRIES@EXAMPLE.COM",
                            NormalizedUserName = "DRIES",
                            PasswordHash = "AQAAAAIAAYagAAAAEPcXKC8VqQvaib4C1qLzbidFJ76LRynn1iveaDJ99MZuZ65ECUccokeBMtlVR6n2yg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b1a70587-f522-4332-b19a-2f6cca2f4a34",
                            TwoFactorEnabled = false,
                            UserName = "Dries"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ae39bb9-a02d-4330-bce8-2467182579f0",
                            Email = "vincent@example.com",
                            EmailConfirmed = true,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "VINCENT@EXAMPLE.COM",
                            NormalizedUserName = "VINCENT",
                            PasswordHash = "AQAAAAIAAYagAAAAEIXpYEZSKbItUPrqUlxdFdDtYq1491JFadtqbvBSZj2/K0OjiZy/FX01BEyr2LDdcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "44d3fefb-55d3-46c7-a3d2-eb3eb09dee7a",
                            TwoFactorEnabled = false,
                            UserName = "Vincent"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "519d895b-57d4-4e54-9464-0940bcdfba16",
                            Email = "simon@example.com",
                            EmailConfirmed = true,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SIMON@EXAMPLE.COM",
                            NormalizedUserName = "SIMON",
                            PasswordHash = "AQAAAAIAAYagAAAAEEWTRE3QKDEex8Er4t/8J+ef42aWFF49QYxlgc1fEriOTUYwwWRXgBAkfddsHHYl7Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0f39dfca-db49-4d90-b98e-69a8d8172765",
                            TwoFactorEnabled = false,
                            UserName = "Simon"
                        });
                });

            modelBuilder.Entity("Jeugdhuis.Models.Drink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsOnlyAtPart")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("PriceAtParty")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "snacks",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "AirFryer snacks",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 2,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Bier van de maand",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 3,
                            Category = "frisdrank",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Bruiswater",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 4,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Buta ranzige Biru",
                            Price = 2.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 5,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Chouffe",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 6,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Cherry Chouffe",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 7,
                            Category = "frisdrank",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Cola",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 8,
                            Category = "frisdrank",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Cola zero",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 9,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Cornet",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 10,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Duvel",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 11,
                            Category = "frisdrank",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Fanta",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 12,
                            Category = "wijn",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Fles Cava",
                            Price = 15.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 13,
                            Category = "wijn",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Glas Cava",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 14,
                            Category = "wijn",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Glas Rosé",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 15,
                            Category = "wijn",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Glas witte wijn",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 16,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Gouden Carolus Classic",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 17,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Gouden Carolus tripel",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 18,
                            Category = "frisdrank",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Groene",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 19,
                            Category = "frisdrank",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Ice Tea",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 20,
                            Category = "Mietenbier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Jupiler 0.0",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 21,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Kriek",
                            Price = 2.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 22,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Maes fles",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 23,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Maes tap",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 24,
                            Category = "snacks",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Pizna baguette",
                            Price = 2.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 25,
                            Category = "frisdrank",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Plat water",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 26,
                            Category = "frisdrank",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Sprite",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 27,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Stella fles",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 28,
                            Category = "bier",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Stella tap",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 29,
                            Category = "snacks",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Toogkletser",
                            Price = 5.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 30,
                            Category = "snacks",
                            IsActive = true,
                            IsOnlyAtPart = false,
                            Name = "Zakje chips ouleh",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        });
                });

            modelBuilder.Entity("Jeugdhuis.Models.StockItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DrinkId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DrinkId");

                    b.ToTable("StockItems");
                });

            modelBuilder.Entity("Jeugdhuis.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Years")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Years = "[2023,2024]"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm St",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Years = "[2024]"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Maple St",
                            Email = "alica.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Years = "[2022]"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Voorzitter",
                            NormalizedName = "VOORZITTER"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Drankmeester",
                            NormalizedName = "DRANKMEESTER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("RoleId")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Jeugdhuis.Models.StockItem", b =>
                {
                    b.HasOne("Jeugdhuis.Models.Drink", "Drink")
                        .WithMany()
                        .HasForeignKey("DrinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drink");
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
                    b.HasOne("Jeugdhuis.Models.Boardmember", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Jeugdhuis.Models.Boardmember", null)
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

                    b.HasOne("Jeugdhuis.Models.Boardmember", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Jeugdhuis.Models.Boardmember", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
