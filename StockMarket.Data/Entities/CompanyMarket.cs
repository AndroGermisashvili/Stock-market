using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Data.Entities;

public class CompanyMarket
{
	public Guid MarketId { get; set; }

	public Guid CompanyId { get; set; }

	public decimal Price { get; set; }

	public virtual Market Market { get; set; }

	public virtual Company Company { get; set; }
}
