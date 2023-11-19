﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TactaShoppingTask.DAL.Data;

#nullable disable

namespace TactaShoppingTask.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231116222001_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TactaShoppingTask.DAL.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemQuantity")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            ItemName = "Bread",
                            ItemQuantity = 3
                        },
                        new
                        {
                            ItemId = 2,
                            ItemName = "Milk",
                            ItemQuantity = 3
                        },
                        new
                        {
                            ItemId = 3,
                            ItemName = "Eggs",
                            ItemQuantity = 3
                        },
                        new
                        {
                            ItemId = 4,
                            ItemName = "Honey",
                            ItemQuantity = 3
                        },
                        new
                        {
                            ItemId = 5,
                            ItemName = "Ketchup",
                            ItemQuantity = 3
                        });
                });

            modelBuilder.Entity("TactaShoppingTask.DAL.Models.Shopper", b =>
                {
                    b.Property<int>("ShopperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopperId"), 1L, 1);

                    b.Property<string>("ShopperName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopperId");

                    b.ToTable("Shoppers");

                    b.HasData(
                        new
                        {
                            ShopperId = 1,
                            ShopperName = "Jim"
                        },
                        new
                        {
                            ShopperId = 2,
                            ShopperName = "John"
                        },
                        new
                        {
                            ShopperId = 3,
                            ShopperName = "Emma"
                        },
                        new
                        {
                            ShopperId = 4,
                            ShopperName = "Andrea"
                        },
                        new
                        {
                            ShopperId = 5,
                            ShopperName = "Martin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
