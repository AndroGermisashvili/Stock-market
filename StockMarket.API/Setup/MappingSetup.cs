using StockMarket.Core.Mappings;

namespace StockMarket.API.Setup;

public static class MappingSetup
{
	public static IServiceCollection AddMappers(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddAutoMapper(x =>
		{
			x.AddProfile<MarketMappings>();
			x.AddProfile<CompanyMappings>();
		});

		return services;
	}
}
