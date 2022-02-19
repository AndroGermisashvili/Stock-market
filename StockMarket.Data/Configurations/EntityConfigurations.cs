using Microsoft.EntityFrameworkCore;

using StockMarket.Common.Constants;
using StockMarket.Data.Entities;

namespace StockMarket.Data.Configurations;

public static class EntityConfigurations
{
	public static void ConfigureEntities(this ModelBuilder builder)
	{
		builder.HasDefaultSchema(TableNames.Schema);

		builder.Entity<Company>(x =>
		{
			x.ToTable(TableNames.Companies);

			x.HasKey(x => x.Id);

			x.HasIndex(x => x.Id)
			.IsUnique();

			x.Property(x => x.Name)
			.IsRequired()
			.HasMaxLength(50);

			x.HasMany(x => x.Markets)
			.WithOne(x => x.Company)
			.HasForeignKey(x => x.CompanyId);
		});

		builder.Entity<Market>(x =>
		{
			x.ToTable(TableNames.Markets);

			x.HasIndex(x => x.Id)
			.IsUnique();

			x.Property(x => x.Name)
			.IsRequired()
			.HasMaxLength(50);

			x.HasMany(x => x.Companies)
			.WithOne(x => x.Market)
			.HasForeignKey(x => x.MarketId);
		});

		builder.Entity<CompanyMarket>(x =>
		{
			x.ToTable(TableNames.CompanyPrices);

			x.HasIndex("MarketId", "CompanyId");

			x.HasKey(x => new {x.MarketId, x.CompanyId});

			x.HasOne(x => x.Company)
			.WithMany(x => x.Markets)
			.HasForeignKey(x => x.CompanyId);

			x.HasOne(x => x.Market)
			.WithMany(x => x.Companies)
			.HasForeignKey(x => x.MarketId);
		});
	}
}
