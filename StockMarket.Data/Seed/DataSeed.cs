using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockMarket.Data.Entities;

namespace StockMarket.Data.Seed;

public static class DataSeed
{
	public static IEnumerable<Market> GetMarkets()
	{
		return new List<Market>()
		{
			new Market()
			{
				Id = Guid.NewGuid(),
				Name = "New York Stock Exchange"
			},
			new Market()
			{
				Id = Guid.NewGuid(),
				Name = "London Stock Exchange"
			},
			new Market()
			{
				Id = Guid.NewGuid(),
				Name = "Nasdaq"
			}
		};
	}

	public static IEnumerable<Company> GetCompanies()
	{
		return new List<Company>()
		{
			new Company()
			{
				Id = Guid.NewGuid(),
				Name = "Amazon"
			},
			new Company()
			{
				Id = Guid.NewGuid(),
				Name = "Apple"
			},
			new Company()
			{
				Id = Guid.NewGuid(),
				Name = "Microsoft"
			},
			new Company()
			{
				Id = Guid.NewGuid(),
				Name = "Facebook"
			},
			new Company()
			{
				Id = Guid.NewGuid(),
				Name = "Tesla"
			}
		};
	}

	public static IEnumerable<CompanyMarket> GenerateStockMarket(IEnumerable<Market> markets, IEnumerable<Company> companies)
	{
		var result = new List<CompanyMarket>();
		foreach(Market market in markets)
		{
			foreach(Company company in companies)
			{
				result.Add(new CompanyMarket()
				{
					MarketId = market.Id,
					CompanyId = company.Id,
					Price = new decimal(rng.Next(100, 700))
				});
			}
		}
		
		return result;
	}

	private static Random rng = new Random(); 
}
