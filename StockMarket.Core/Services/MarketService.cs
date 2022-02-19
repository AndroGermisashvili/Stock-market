using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Microsoft.EntityFrameworkCore;

using StockMarket.Common.Models;
using StockMarket.Core.Interfaces;
using StockMarket.Data.Entities;
using StockMarket.Data.Repositories;
using StockMarket.Data.Repositories.Interfaces;

namespace StockMarket.Core.Services
{
    public class MarketService : IMarketService
    {
		private readonly IMarketRepository _marketRepository;
		private readonly IMapper _mapper;

		public MarketService(IMarketRepository marketRepository, IMapper mapper)
		{
			_marketRepository = marketRepository;
			_mapper = mapper;
		}

		public async Task<IEnumerable<MarketModel>> GetAllAsync(CancellationToken cancellationToken)
		{
			var markets = await _marketRepository.GetAllAsync(cancellationToken);

			var marketModels = markets.ProjectTo<MarketModel>(_mapper.ConfigurationProvider);

			return marketModels;
		}

		public async Task<MarketModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
		{
			var market = await _marketRepository.GetByIdAsync(id, cancellationToken);

			var marketModel = _mapper.Map<MarketModel>(market);

			return marketModel;
		}

		public async Task CreateAsync(MarketModel marketModel, CancellationToken cancellationToken)
		{
			var market = _mapper.Map<Market>(marketModel);

			await _marketRepository.CreateAsync(market, cancellationToken);
		}


		public async Task UpdateAsync(MarketModel marketModel, CancellationToken cancellationToken)
		{
			var market = _mapper.Map<Market>(marketModel);

			await _marketRepository.UpdateAsync(market, cancellationToken);
		}

		public async Task UpdateCompanyPrice(CompanyModel company, CancellationToken cancellationToken)
		{
			var markets = await _marketRepository.GetAllAsync(cancellationToken);
			var marketModels = markets.ProjectTo<MarketModel>(_mapper.ConfigurationProvider);
			var target = await marketModels.SingleOrDefaultAsync(x => x.Id == company.MarketId);
			target.Companies.SingleOrDefault(x => x.Id == company.Id).Price = company.Price;
			await UpdateAsync(target, cancellationToken);
		}


		public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
