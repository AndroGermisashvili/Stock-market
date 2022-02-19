using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using StockMarket.Common.Models;
using StockMarket.Data.Entities;

namespace StockMarket.Core.Mappings;

public class MarketMappings : Profile
{
	public MarketMappings()
	{
		CreateMap<Market, MarketModel>();

		CreateMap<MarketModel, Market>();

		CreateMap<CompanyMarket, CompanyModel>()
			.ForMember(x => x.Id, opt => opt.MapFrom(x => x.CompanyId))
			.ForMember(x => x.Name, opt => opt.MapFrom(x => x.Company.Name))
			.ForMember(x => x.MarketId, opt => opt.MapFrom(x => x.MarketId))
			.ForMember(x => x.Price, opt => opt.MapFrom(x => x.Price));

		CreateMap<CompanyModel, CompanyMarket>()
			.ForMember(x => x.CompanyId, opt => opt.MapFrom(x => x.Id))
			.ForMember(x => x.MarketId, opt => opt.MapFrom(x => x.MarketId))
			.ForMember(x => x.Price, opt => opt.MapFrom(x => x.Price));
	}
}
