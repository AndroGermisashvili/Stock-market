using Microsoft.AspNetCore.Mvc;

using StockMarket.Admin.Web.Models;
using StockMarket.Common.Models;

using System.Diagnostics;

namespace StockMarket.Admin.Web.Controllers
{
    public class HomeController : Controller
    {
		private readonly ApiClient _client;

		public HomeController(ApiClient client)
        {
			_client = client;
		}

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
			var result = await _client.GetAllMarkets(cancellationToken);

            return View(result);
        }

		[HttpPost]
		public async Task<IActionResult> UpdateCompanyPrice(CompanyModel model,	CancellationToken cancellationToken)
		{
			try
			{
				await _client.UpdateCompanyPrice(model, cancellationToken);

				return RedirectToAction(nameof(Index));
			}
			catch (Exception)
			{
				return StatusCode(500);
			}

		}

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
