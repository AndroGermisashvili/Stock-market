using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockMarket.Data.Entities;

namespace StockMarket.Data.Repositories.Interfaces;

public interface IMarketRepository
{
	public Task<IQueryable<Market>> GetAllAsync(CancellationToken cancellationToken);
	public Task<Market> GetByIdAsync(Guid id, CancellationToken cancellationToken);
	public Task<Market> GetByIdAsync(string id, CancellationToken cancellationToken);
	public Task CreateAsync(Market market, CancellationToken cancellationToken);
	public Task UpdateAsync(Market market, CancellationToken cancellationToken);
	public Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
