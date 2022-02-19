using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockMarket.Common.Models;
using StockMarket.Data.Entities;
using StockMarket.Data.Repositories.Interfaces;

namespace StockMarket.Core.Services;

public class CompanyService
{
	private readonly ICompanyRepository _companyRepository;

	public CompanyService(ICompanyRepository companyRepository)
	{
		_companyRepository = companyRepository;
	}

	public async Task CreateCompany(CompanyModel model, CancellationToken cancellationToken)
	{
		await _companyRepository.CreateAsync(new Company
		{
			Id = model.Id,
			Name = model.Name,
			Markets = new List<CompanyMarket>()
		}, cancellationToken);
	}
}
