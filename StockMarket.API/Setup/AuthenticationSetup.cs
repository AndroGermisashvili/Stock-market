using System.Text;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

using StockMarket.Common.Configs;
using StockMarket.Core.Interfaces;
using StockMarket.Core.Services;

namespace StockMarket.API.Setup;

public static class AuthenticationSetup
{
	public static IServiceCollection SetupAuthentication(this IServiceCollection services, IConfiguration configuration)
	{
		var authSection = configuration.GetSection(AuthConfiguration.Name);

		services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
		{
			options.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuerSigningKey = true,
				ValidateLifetime = false,
				ValidateAudience = false,
				ValidateIssuer = false,
				IssuerSigningKey = new SymmetricSecurityKey(
											Encoding.UTF8.GetBytes(authSection.GetSection("Key").Value))
			};
		});
		services.Configure<AuthConfiguration>(authSection);
		services.AddScoped<IAuthenticationService, AuthenticationService>();

		return services;
	}
}
