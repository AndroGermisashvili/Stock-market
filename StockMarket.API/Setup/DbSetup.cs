using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using StockMarket.Common.Constants;
using StockMarket.Data;

using System;

using IMigrationAssembly = StockMarket.Data.IAssemblyMarker;

namespace StockMarket.API.Setup;

public static class DbSetup
{
	public static IServiceCollection AddDbServices(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<ApplicationDbContext>(AddPostgre(configuration.GetConnectionString("DefaultDb")));

		return services;
	}

	public static Action<DbContextOptionsBuilder> AddPostgre(string connStr) => x => x.UseNpgsql(
		connStr,
		options =>
		{
			options.MigrationsAssembly(typeof(IMigrationAssembly).Assembly.GetName().Name);
			options.MigrationsHistoryTable("__MarketMigrations", TableNames.Schema);
			options.EnableRetryOnFailure(3, TimeSpan.FromSeconds(10), null);
		});
}

