using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using StockMarket.Common.Models;
using StockMarket.Data.Entities;

namespace StockMarket.Core.Mappings;

public class CompanyMappings : Profile
{
	public CompanyMappings()
	{
		CreateMap<CompanyModel, Company>();

		CreateMap<Company, CompanyModel>();

		CreateMap<CompanyMarket, Market>()
			.ForMember(x => x.Id, opt => opt.MapFrom(x => x.MarketId))
			.ForMember(x => x.Name, opt => opt.MapFrom(x => x.Market.Name))
			.ForMember(x => x.Companies, opt => opt.MapFrom(x => x.Market.Companies));
	}
}
