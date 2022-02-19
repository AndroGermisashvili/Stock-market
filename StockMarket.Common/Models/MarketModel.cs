using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Common.Models;

public class MarketModel
{
	public Guid Id { get; set; }

	public string Name { get; set; } = null!;

	public IEnumerable<CompanyModel>? Companies { get; set; }
}
