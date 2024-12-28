﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jeugdhuis.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Jeugdhuis.Models.Boardmember", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

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
                            ConcurrencyStamp = "244895b5-0216-49db-b2b7-7417f383b79e",
                            Email = "dries@example.com",
                            EmailConfirmed = true,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DRIES@EXAMPLE.COM",
                            NormalizedUserName = "DRIES",
                            PasswordHash = "AQAAAAIAAYagAAAAEDXBWDHjl8+o7XagllDvGm39JlkcpG29th9ynUXSWeaH1FIQ1mM1Pje8nhC7JoObsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "be0ecf16-3005-43f1-85b4-eddf4e8a41bd",
                            TwoFactorEnabled = false,
                            UserName = "Dries"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "09490ec7-2822-45cc-88bb-d62dd40de535",
                            Email = "vincent@example.com",
                            EmailConfirmed = true,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "VINCENT@EXAMPLE.COM",
                            NormalizedUserName = "VINCENT",
                            PasswordHash = "AQAAAAIAAYagAAAAEGcBaXqB6MGGbNhZcZSuAKJg1esvJT2v+cBK0qXS/drH6xOwPHSpDl71+vNm/a/pCg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e9a9dd30-737e-4d5f-8003-7f779031416e",
                            TwoFactorEnabled = false,
                            UserName = "Vincent"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "79d97013-fccb-4f64-aa2d-feec20afdf3f",
                            Email = "simon@example.com",
                            EmailConfirmed = true,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SIMON@EXAMPLE.COM",
                            NormalizedUserName = "SIMON",
                            PasswordHash = "AQAAAAIAAYagAAAAEKFE9RbRY3ZbqUFBT9qS1QPDwRkMi63ozRbZlj2SJQLTuValTbP7Zc4fHtLYvsBUDg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c0c64d70-57d9-4603-8da3-63152820a508",
                            TwoFactorEnabled = false,
                            UserName = "Simon"
                        });
                });

            modelBuilder.Entity("Jeugdhuis.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "#FFA500",
                            Name = "snacks"
                        },
                        new
                        {
                            Id = 2,
                            Color = "#FFD700",
                            Name = "bier"
                        },
                        new
                        {
                            Id = 3,
                            Color = "#00BFFF",
                            Name = "frisdrank"
                        },
                        new
                        {
                            Id = 4,
                            Color = "#8B0000",
                            Name = "wijn"
                        },
                        new
                        {
                            Id = 5,
                            Color = "#D85E5E",
                            Name = "cocktails"
                        },
                        new
                        {
                            Id = 6,
                            Color = "#3285a8",
                            Name = "andere"
                        });
                });

            modelBuilder.Entity("Jeugdhuis.Models.Drink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsOnlyAtParty")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("PriceAtParty")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "AirFryer snacks",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Bier van de maand",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Bruiswater",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Buta ranzige Biru",
                            Price = 2.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Chouffe",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Cherry Chouffe",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Cola",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Cola zero",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Cornet",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Duvel",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Fanta",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Fles Cava",
                            Price = 15.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 4,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Glas Cava",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 4,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Glas Rosé",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Glas witte wijn",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Gouden Carolus Classic",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Gouden Carolus tripel",
                            Price = 3.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Groene",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Ice Tea",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Jupiler 0.0",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Kriek",
                            Price = 2.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Maes fles",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Maes tap",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 1,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Pizna baguette",
                            Price = 2.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 3,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Plat water",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 3,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Sprite",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Stella fles",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 2,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Stella tap",
                            Price = 1.5,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 1,
                            IsActive = true,
                            IsOnlyAtParty = false,
                            Name = "Toogkletser",
                            Price = 5.0,
                            PriceAtParty = 0.0
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 1,
                            IsActive = true,
                            IsOnlyAtParty = false,
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DrinkId = 1,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 2,
                            DrinkId = 2,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 3,
                            DrinkId = 3,
                            Quantity = 25
                        },
                        new
                        {
                            Id = 4,
                            DrinkId = 4,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 5,
                            DrinkId = 5,
                            Quantity = 12
                        },
                        new
                        {
                            Id = 6,
                            DrinkId = 6,
                            Quantity = 18
                        },
                        new
                        {
                            Id = 7,
                            DrinkId = 7,
                            Quantity = 30
                        },
                        new
                        {
                            Id = 8,
                            DrinkId = 8,
                            Quantity = 28
                        },
                        new
                        {
                            Id = 9,
                            DrinkId = 9,
                            Quantity = 14
                        },
                        new
                        {
                            Id = 10,
                            DrinkId = 10,
                            Quantity = 16
                        },
                        new
                        {
                            Id = 11,
                            DrinkId = 11,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 12,
                            DrinkId = 12,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 13,
                            DrinkId = 13,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 14,
                            DrinkId = 14,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 15,
                            DrinkId = 15,
                            Quantity = 12
                        },
                        new
                        {
                            Id = 16,
                            DrinkId = 16,
                            Quantity = 7
                        },
                        new
                        {
                            Id = 17,
                            DrinkId = 17,
                            Quantity = 7
                        },
                        new
                        {
                            Id = 18,
                            DrinkId = 18,
                            Quantity = 26
                        },
                        new
                        {
                            Id = 19,
                            DrinkId = 19,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 20,
                            DrinkId = 20,
                            Quantity = 18
                        },
                        new
                        {
                            Id = 21,
                            DrinkId = 21,
                            Quantity = 9
                        },
                        new
                        {
                            Id = 22,
                            DrinkId = 22,
                            Quantity = 14
                        },
                        new
                        {
                            Id = 23,
                            DrinkId = 23,
                            Quantity = 13
                        },
                        new
                        {
                            Id = 24,
                            DrinkId = 24,
                            Quantity = 6
                        },
                        new
                        {
                            Id = 25,
                            DrinkId = 25,
                            Quantity = 25
                        },
                        new
                        {
                            Id = 26,
                            DrinkId = 26,
                            Quantity = 27
                        },
                        new
                        {
                            Id = 27,
                            DrinkId = 27,
                            Quantity = 11
                        },
                        new
                        {
                            Id = 28,
                            DrinkId = 28,
                            Quantity = 11
                        },
                        new
                        {
                            Id = 29,
                            DrinkId = 29,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 30,
                            DrinkId = 30,
                            Quantity = 21
                        });
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

                    b.Property<string>("PhoneNumber")
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
                            PhoneNumber = "123456789",
                            Years = "[2023,2024]"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm St",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PhoneNumber = "123456789",
                            Years = "[2024]"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Maple St",
                            Email = "alica.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            PhoneNumber = "123456789",
                            Years = "[2022]"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

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
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

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
                            UserId = "2",
                            RoleId = "1"
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
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Jeugdhuis.Models.Drink", b =>
                {
                    b.HasOne("Jeugdhuis.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
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
