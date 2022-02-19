using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMarket.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "stock_market");

            migrationBuilder.CreateTable(
                name: "companies",
                schema: "stock_market",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "markets",
                schema: "stock_market",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_markets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "company_prices",
                schema: "stock_market",
                columns: table => new
                {
                    MarketId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company_prices", x => new { x.MarketId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_company_prices_companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "stock_market",
                        principalTable: "companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_company_prices_markets_MarketId",
                        column: x => x.MarketId,
                        principalSchema: "stock_market",
                        principalTable: "markets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_companies_Id",
                schema: "stock_market",
                table: "companies",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_company_prices_CompanyId",
                schema: "stock_market",
                table: "company_prices",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_company_prices_MarketId_CompanyId",
                schema: "stock_market",
                table: "company_prices",
                columns: new[] { "MarketId", "CompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_markets_Id",
                schema: "stock_market",
                table: "markets",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "company_prices",
                schema: "stock_market");

            migrationBuilder.DropTable(
                name: "companies",
                schema: "stock_market");

            migrationBuilder.DropTable(
                name: "markets",
                schema: "stock_market");
        }
    }
}
