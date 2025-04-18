﻿// <auto-generated />
using System;
using GMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eCommerce.Services.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 4, 18, 22, 56, 15, 534, DateTimeKind.Utc).AddTicks(4216),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            IsActive = true,
                            LastName = "Doe",
                            PasswordHash = "hashed_password_1",
                            PasswordSalt = "salt_1",
                            PhoneNumber = "123-456-7890",
                            Username = "johndoe"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 4, 18, 22, 56, 15, 534, DateTimeKind.Utc).AddTicks(4218),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            IsActive = true,
                            LastName = "Smith",
                            PasswordHash = "hashed_password_2",
                            PasswordSalt = "salt_2",
                            PhoneNumber = "987-654-3210",
                            Username = "janesmith"
                        });
                });

            modelBuilder.Entity("GMS.Entities.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Banja Luka"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bihać"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bijeljina"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bosnaska Krupa"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cazin"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Čapljina"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Drventa"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Doboj"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Goražde"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Gračanica"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Gradačac"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Gradiška"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Konjic"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Laktaši"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Livno"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Lukavac"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Ljubuški"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Mostar"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Orašje"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Prijedor"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Prnjavor"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Sarajevo"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Srebrenik"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Stolac"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Široki Brijeg"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Travnik"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Tuzla"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Visoko"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Zavidovići"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Zenica"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Zvornik"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Živinice"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Donji Vakuf"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Zavidovići"
                        });
                });

            modelBuilder.Entity("GMS.Entities.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SKU")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Grad");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 4, 18, 22, 56, 15, 534, DateTimeKind.Utc).AddTicks(3729),
                            Description = "High-quality whey protein powder for muscle recovery and growth.",
                            IsActive = true,
                            Name = "Whey Protein",
                            Price = 49.99m,
                            SKU = "WHEY-001",
                            StockQuantity = 100
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 4, 18, 22, 56, 15, 534, DateTimeKind.Utc).AddTicks(3731),
                            Description = "Pure creatine monohydrate to enhance strength and performance.",
                            IsActive = true,
                            Name = "Creatine Monohydrate",
                            Price = 29.99m,
                            SKU = "CREA-001",
                            StockQuantity = 150
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
