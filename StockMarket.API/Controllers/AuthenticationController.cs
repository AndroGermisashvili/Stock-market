using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using StockMarket.Common.Models;
using StockMarket.Core.Interfaces;

namespace StockMarket.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
	private readonly IAuthenticationService _authenticationService;

	public AuthenticationController(IAuthenticationService authenticationService)
	{
		_authenticationService = authenticationService;
	}

	[HttpPost]
	[AllowAnonymous]
	public async Task<IActionResult> RequestToken(LoginModel model)
	{
		var token = await _authenticationService.RequestTokenAsync(model);
		return Ok(token);
	}
}
