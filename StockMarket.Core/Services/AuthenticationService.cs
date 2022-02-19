using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Options;

using StockMarket.Common.Models;
using StockMarket.Common.Configs;
using StockMarket.Core.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace StockMarket.Core.Services;

public class AuthenticationService : IAuthenticationService
{
	private readonly AuthConfiguration _configuration;

	public AuthenticationService(IOptions<AuthConfiguration> _options)
	{
		_configuration = _options.Value;
	}

	public async Task<bool> LoginUser(LoginModel login)
	{
		if (login.Username == _configuration.Username)
		{
			return login.Password == _configuration.Password;
		}

		return false;
	}

	public async Task<TokenResponse> RequestTokenAsync(LoginModel tokenRequest)
	{
		if(await LoginUser(tokenRequest) is true)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.Key));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(null,
			  null,
			  null,
			  null,
			  signingCredentials: credentials);

			return new TokenResponse
			{
				Token = new JwtSecurityTokenHandler().WriteToken(token)
			};
		}

		throw new AuthenticationException();
	}
}
