using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockMarket.Data.Entities;

namespace StockMarket.Data.Seed;

public static class ApplySeedData
{
	public static void ApplyGeneralData(this ModelBuilder modelBuilder)
	{
		var markets = DataSeed.GetMarkets();
		var companies = DataSeed.GetCompanies();

		modelBuilder.Entity<Market>(b => b.HasData(markets));
		modelBuilder.Entity<Company>(b => b.HasData(companies));
		modelBuilder.Entity<CompanyMarket>(b => b.HasData(DataSeed.GenerateStockMarket(markets, companies)));
	}
}
