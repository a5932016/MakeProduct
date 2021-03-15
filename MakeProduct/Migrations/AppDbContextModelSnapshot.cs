﻿// <auto-generated />
using System;
using MakeProduct.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MakeProduct.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MakeProduct.Models.Product.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductClass")
                        .HasColumnType("int");

                    b.Property<int?>("ProductCount")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductClass = 3,
                            ProductCount = 1,
                            ProductName = "帽子"
                        },
                        new
                        {
                            Id = 2,
                            ProductClass = 1,
                            ProductCount = 2,
                            ProductName = "衣服"
                        },
                        new
                        {
                            Id = 3,
                            ProductClass = 2,
                            ProductCount = 3,
                            ProductName = "褲子"
                        },
                        new
                        {
                            Id = 4,
                            ProductClass = 3,
                            ProductCount = 4,
                            ProductName = "鞋子"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}