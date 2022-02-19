using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockMarket.Data.Entities;

namespace StockMarket.Data.Repositories.Interfaces;

public interface ICompanyRepository
{
	public Task<IQueryable<Company>> GetAllAsync(CancellationToken cancellationToken);
	public Task<Company> GetByIdAsync(Guid id, CancellationToken cancellationToken);
	public Task<Company> GetByIdAsync(string id, CancellationToken cancellationToken);
	public Task CreateAsync(Company company, CancellationToken cancellationToken);
	public Task UpdateAsync(Company company, CancellationToken cancellationToken);
	public Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
