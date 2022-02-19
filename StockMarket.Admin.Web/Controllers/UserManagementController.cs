using Microsoft.AspNetCore.Mvc;

using StockMarket.Admin.Web.Models;
using StockMarket.Common.Models;

namespace StockMarket.Admin.Web.Controllers;

public class UserManagementController : Controller
{
	private readonly ApiClient _client;

	public UserManagementController(ApiClient client)
	{
		_client = client;
	}

	public IActionResult Index()
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Login(LoginViewModel model, CancellationToken cancellationToken)
	{
		var tokenResponse = await _client.LoginAsync(new LoginModel { Username = model.Username, Password = model.Password }, cancellationToken);

		Response.Cookies.Append(
				"X-Access-Token",
				tokenResponse.Token, new CookieOptions
				{
					HttpOnly = true,
					SameSite = SameSiteMode.Strict
				});
		return RedirectToAction("Index", "Home");
	}
}
