namespace StockMarket.Admin.Web.Setup;

public static class ApiClientSetup
{
	public static IServiceCollection AddApiClient(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddHttpClient<ApiClient>("MarketApi", client =>
		{
			var httpClientConfig = configuration.GetSection("MarketApi");

			client.BaseAddress = new Uri(httpClientConfig.GetSection("BaseAddress").Value);
		});

		return services;
	}
}
