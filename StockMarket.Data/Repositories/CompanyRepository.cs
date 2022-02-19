using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockMarket.Data.Entities;
using StockMarket.Data.Repositories.Interfaces;

namespace StockMarket.Data.Repositories;

public class CompanyRepository : ICompanyRepository
{
	private readonly ApplicationDbContext _dbContext;

	public CompanyRepository(ApplicationDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task CreateAsync(Company company, CancellationToken cancellationToken)
	{
		await _dbContext.Companies.AddAsync(company);
		await _dbContext.SaveChangesAsync();
	}

	public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public async Task<IQueryable<Company>> GetAllAsync(CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public async Task<Company> GetByIdAsync(Guid id, CancellationToken cancellationToken)
	{
		var result = await _dbContext.Companies
			.SingleOrDefaultAsync(x => x.Id == id, cancellationToken);

		return result;
	}

	public async Task<Company> GetByIdAsync(string id, CancellationToken cancellationToken) => await GetByIdAsync(Guid.Parse(id), cancellationToken);

	public async Task UpdateAsync(Company company, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
