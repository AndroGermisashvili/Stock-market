using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMarket.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "stock_market",
                table: "companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"), "Apple" },
                    { new Guid("392ad646-247c-4666-b531-5a6b8dff6025"), "Facebook" },
                    { new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"), "Tesla" },
                    { new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"), "Microsoft" },
                    { new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"), "Amazon" }
                });

            migrationBuilder.InsertData(
                schema: "stock_market",
                table: "markets",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"), "Nasdaq" },
                    { new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"), "London Stock Exchange" },
                    { new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"), "New York Stock Exchange" }
                });

            migrationBuilder.InsertData(
                schema: "stock_market",
                table: "company_prices",
                columns: new[] { "CompanyId", "MarketId", "Price" },
                values: new object[,]
                {
                    { new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"), 574m },
                    { new Guid("392ad646-247c-4666-b531-5a6b8dff6025"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"), 240m },
                    { new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"), 615m },
                    { new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"), 108m },
                    { new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"), 391m },
                    { new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"), 640m },
                    { new Guid("392ad646-247c-4666-b531-5a6b8dff6025"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"), 469m },
                    { new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"), 462m },
                    { new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"), 372m },
                    { new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"), 507m },
                    { new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"), 559m },
                    { new Guid("392ad646-247c-4666-b531-5a6b8dff6025"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"), 473m },
                    { new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"), 174m },
                    { new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"), 261m },
                    { new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"), 404m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("392ad646-247c-4666-b531-5a6b8dff6025"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"), new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("392ad646-247c-4666-b531-5a6b8dff6025"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"), new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("392ad646-247c-4666-b531-5a6b8dff6025"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "company_prices",
                keyColumns: new[] { "CompanyId", "MarketId" },
                keyValues: new object[] { new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"), new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596") });

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "companies",
                keyColumn: "Id",
                keyValue: new Guid("2c90f8d9-d6c2-4122-b42f-8e535e892015"));

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "companies",
                keyColumn: "Id",
                keyValue: new Guid("392ad646-247c-4666-b531-5a6b8dff6025"));

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "companies",
                keyColumn: "Id",
                keyValue: new Guid("5a5aa844-eec9-457f-8b80-1d872da777fc"));

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "companies",
                keyColumn: "Id",
                keyValue: new Guid("a77a4eb4-14c4-4739-8eb9-139bfe1c8173"));

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "companies",
                keyColumn: "Id",
                keyValue: new Guid("f1c9fb6c-aba7-46ea-8298-6f653f0bd9c9"));

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "markets",
                keyColumn: "Id",
                keyValue: new Guid("75d7b183-83c1-4a8c-a94b-712189e0393b"));

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "markets",
                keyColumn: "Id",
                keyValue: new Guid("869a4a7a-b07f-499f-90bc-62260b0aa16f"));

            migrationBuilder.DeleteData(
                schema: "stock_market",
                table: "markets",
                keyColumn: "Id",
                keyValue: new Guid("ab45d976-11fd-4392-be16-9cc5e6cdc596"));
        }
    }
}
