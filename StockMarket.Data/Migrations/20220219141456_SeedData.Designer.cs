﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StockMarket.Data;

#nullable disable

namespace StockMarket.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220219141456_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("stock_market")
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StockMarket.Data.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("companies", "stock_market");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"),
                            Name = "Amazon"
                        },
                        new
                        {
                            Id = new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"),
                            Name = "Apple"
                        },
                        new
                        {
                            Id = new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"),
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = new Guid("392ad646-247c-4666-b531-5a6b8dff6025"),
                            Name = "Facebook"
                        },
                        new
                        {
                            Id = new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"),
                            Name = "Tesla"
                        });
                });

            modelBuilder.Entity("StockMarket.Data.Entities.CompanyMarket", b =>
                {
                    b.Property<Guid>("MarketId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("MarketId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("MarketId", "CompanyId");

                    b.ToTable("company_prices", "stock_market");

                    b.HasData(
                        new
                        {
                            MarketId = new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"),
                            CompanyId = new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"),
                            Price = 404m
                        },
                        new
                        {
                            MarketId = new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"),
                            CompanyId = new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"),
                            Price = 559m
                        },
                        new
                        {
                            MarketId = new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"),
                            CompanyId = new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"),
                            Price = 261m
                        },
                        new
                        {
                            MarketId = new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"),
                            CompanyId = new Guid("392ad646-247c-4666-b531-5a6b8dff6025"),
                            Price = 473m
                        },
                        new
                        {
                            MarketId = new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"),
                            CompanyId = new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"),
                            Price = 174m
                        },
                        new
                        {
                            MarketId = new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"),
                            CompanyId = new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"),
                            Price = 507m
                        },
                        new
                        {
                            MarketId = new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"),
                            CompanyId = new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"),
                            Price = 640m
                        },
                        new
                        {
                            MarketId = new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"),
                            CompanyId = new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"),
                            Price = 372m
                        },
                        new
                        {
                            MarketId = new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"),
                            CompanyId = new Guid("392ad646-247c-4666-b531-5a6b8dff6025"),
                            Price = 469m
                        },
                        new
                        {
                            MarketId = new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"),
                            CompanyId = new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"),
                            Price = 462m
                        },
                        new
                        {
                            MarketId = new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"),
                            CompanyId = new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"),
                            Price = 391m
                        },
                        new
                        {
                            MarketId = new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"),
                            CompanyId = new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"),
                            Price = 574m
                        },
                        new
                        {
                            MarketId = new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"),
                            CompanyId = new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"),
                            Price = 108m
                        },
                        new
                        {
                            MarketId = new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"),
                            CompanyId = new Guid("392ad646-247c-4666-b531-5a6b8dff6025"),
                            Price = 240m
                        },
                        new
                        {
                            MarketId = new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"),
                            CompanyId = new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"),
                            Price = 615m
                        });
                });

            modelBuilder.Entity("StockMarket.Data.Entities.Market", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("markets", "stock_market");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"),
                            Name = "New York Stock Exchange"
                        },
                        new
                        {
                            Id = new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"),
                            Name = "London Stock Exchange"
                        },
                        new
                        {
                            Id = new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"),
                            Name = "Nasdaq"
                        });
                });

            modelBuilder.Entity("StockMarket.Data.Entities.CompanyMarket", b =>
                {
                    b.HasOne("StockMarket.Data.Entities.Company", "Company")
                        .WithMany("Markets")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockMarket.Data.Entities.Market", "Market")
                        .WithMany("Companies")
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Market");
                });

            modelBuilder.Entity("StockMarket.Data.Entities.Company", b =>
                {
                    b.Navigation("Markets");
                });

            modelBuilder.Entity("StockMarket.Data.Entities.Market", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
