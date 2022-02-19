using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockMarket.Data.Entities;
using StockMarket.Data.Repositories.Interfaces;

namespace StockMarket.Data.Repositories;

public class MarketRepository : IMarketRepository
{
	private readonly ApplicationDbContext _dbContext;

	public MarketRepository(ApplicationDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task CreateAsync(Market market, CancellationToken cancellationToken)
	{
		market.Id = new Guid();
		foreach(var company in market.Companies)
		{
			company.MarketId = market.Id;
		}
		await _dbContext.Markets.AddAsync(market);
		await _dbContext.SaveChangesAsync();
	}

	public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public async Task<IQueryable<Market>> GetAllAsync(CancellationToken cancellationToken)
	{
		var markets = _dbContext.Markets;

		return markets;
	}

	public async Task<Market?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
	{
		var market = await _dbContext.Markets.FirstOrDefaultAsync(x => x.Id == id);
		return market;
	}

	public Task<Market> GetByIdAsync(string id, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public async Task UpdateAsync(Market market, CancellationToken cancellationToken)
	{
		var target = await _dbContext.Markets.SingleOrDefaultAsync(x => x.Id == market.Id);
		_dbContext.Markets.Remove(target);
		await _dbContext.SaveChangesAsync();
		await _dbContext.Markets.AddAsync(market);

		await _dbContext.SaveChangesAsync(cancellationToken);
	}
}
