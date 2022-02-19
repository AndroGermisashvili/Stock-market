using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockMarket.Common.Models;

namespace StockMarket.Core.Interfaces;

public interface IMarketService
{
	public Task<IEnumerable<MarketModel>> GetAllAsync(CancellationToken cancellationToken);
	public Task<MarketModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
	public Task CreateAsync(MarketModel model, CancellationToken cancellationToken);
	public Task UpdateAsync(MarketModel model, CancellationToken cancellationToken);
	public Task UpdateCompanyPrice(CompanyModel company, CancellationToken cancellationToken);
	public Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
