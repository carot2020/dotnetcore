﻿// <auto-generated />
using System;
using Lab09.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab09.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200228120300_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab09.Models.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Iphone"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "SamSung"
                        });
                });

            modelBuilder.Entity("Lab09.Models.Domain.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Lab09.Models.Domain.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Lab09.Models.Domain.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            CreateDate = new DateTime(2020, 2, 28, 19, 2, 59, 706, DateTimeKind.Local).AddTicks(3782),
                            Descriptions = "iphoneX 64GB - 256GB",
                            ProductImage = "iphoneX.png",
                            ProductName = "IphoneX",
                            ProductPrice = 1000.0,
                            ProductQuantity = 100
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            CreateDate = new DateTime(2020, 2, 28, 19, 2, 59, 707, DateTimeKind.Local).AddTicks(6510),
                            Descriptions = "iphoneX 64GB - 256GB",
                            ProductImage = "iphoneX.png",
                            ProductName = "IphoneX",
                            ProductPrice = 1000.0,
                            ProductQuantity = 100
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            CreateDate = new DateTime(2020, 2, 28, 19, 2, 59, 707, DateTimeKind.Local).AddTicks(6560),
                            Descriptions = "iphoneX 64GB - 256GB",
                            ProductImage = "iphoneX.png",
                            ProductName = "IphoneX",
                            ProductPrice = 1000.0,
                            ProductQuantity = 100
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            CreateDate = new DateTime(2020, 2, 28, 19, 2, 59, 707, DateTimeKind.Local).AddTicks(6564),
                            Descriptions = "samsung 64GB - 256GB",
                            ProductImage = "samsung.png",
                            ProductName = "SamSung",
                            ProductPrice = 1000.0,
                            ProductQuantity = 100
                        });
                });

            modelBuilder.Entity("Lab09.Models.Domain.OrderDetail", b =>
                {
                    b.HasOne("Lab09.Models.Domain.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab09.Models.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab09.Models.Domain.Product", b =>
                {
                    b.HasOne("Lab09.Models.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
