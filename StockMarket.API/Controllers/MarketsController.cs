using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using StockMarket.Common.Models;
using StockMarket.Core.Interfaces;

namespace StockMarket.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class MarketsController : ControllerBase
{
	private readonly IMarketService _marketService;

	public MarketsController(IMarketService marketService)
	{
		_marketService = marketService;
	}

	[HttpGet]
	[Authorize]
	public async Task<IActionResult> GetAllMarkets(CancellationToken cancellationToken)
	{
		try
		{
			var result = await _marketService.GetAllAsync(cancellationToken);

			return Ok(result);
		}
		catch (Exception)
		{
			return StatusCode(500);
		}
	}

	[HttpPost]
	[Authorize]
	public async Task<IActionResult> CreateMarket(MarketModel model)
	{
		try
		{
			await _marketService.CreateAsync(model, new CancellationToken());

			return Ok();
		}
		catch (Exception)
		{

			return StatusCode(500);
		}
	}

	[HttpPost]
	[Authorize]
	public async Task<IActionResult> UpdateCompanyPrice(CompanyModel model, CancellationToken cancellationToken)
	{
		try
		{
			await _marketService.UpdateCompanyPrice(model, cancellationToken);

			return Ok();
		}
		catch (Exception)
		{
			return StatusCode(500);
		}
	}

	[HttpPost]
	[Authorize]
	public async Task<IActionResult> UpdateMarket(MarketModel model, CancellationToken cancellationToken)
	{
		try
		{
			await _marketService.UpdateAsync(model, cancellationToken);

			return Ok();
		}
		catch (Exception)
		{
			return StatusCode(500);
		}
	}
}
