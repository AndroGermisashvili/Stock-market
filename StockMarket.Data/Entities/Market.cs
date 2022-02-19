using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Data.Entities;

public class Market : IEntity<Guid>
{
	public Guid Id { get; set; }

	public string Name { get; set; } = null!;

	public virtual ICollection<CompanyMarket>? Companies { get; set; }
}
