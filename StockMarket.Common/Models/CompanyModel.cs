using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Common.Models;

public class CompanyModel
{
	public Guid Id { get; set; }

	public Guid MarketId { get; set; }

	public string Name { get; set; } = null!;

	public decimal? Price { get; set; }
}
