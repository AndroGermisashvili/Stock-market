using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockMarket.Data.Entities;

namespace StockMarket.Data.Repositories.Interfaces;

public interface IPricingRepository
{
	public Task<IEnumerable<CompanyMarket>> GetAllPricesAsync(CancellationToken cancellationToken);
	public Task<IEnumerable<CompanyMarket>> GetMarketInfoAsync(Guid marketId, CancellationToken cancellationToken);
	public Task<IEnumerable<CompanyMarket>> GetCompanyInfoAsync(Guid companyId, CancellationToken cancellationToken);
	public Task<CompanyMarket> GetSingleRelation(Guid marketId, Guid companyId, CancellationToken cancellationToken);
}
