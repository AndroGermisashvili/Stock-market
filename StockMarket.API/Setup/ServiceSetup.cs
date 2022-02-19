using StockMarket.Core.Interfaces;
using StockMarket.Core.Services;
using StockMarket.Data.Repositories;
using StockMarket.Data.Repositories.Interfaces;

namespace StockMarket.API.Setup;

public static class ServiceSetup
{
	public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddScoped<CompanyService>();
		services.AddScoped<IMarketService, MarketService>();
		services.AddScoped<ICompanyRepository, CompanyRepository>();
		services.AddScoped<IMarketRepository, MarketRepository>();

		return services;
	}
}
