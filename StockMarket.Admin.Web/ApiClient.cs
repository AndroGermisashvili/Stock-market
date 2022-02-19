using System.Text;
using System.Text.Json;

using StockMarket.Common.Models;

namespace StockMarket.Admin.Web;

public class ApiClient
{
	private readonly HttpClient _http;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly JsonSerializerOptions _options = new JsonSerializerOptions()
	{
		PropertyNamingPolicy = JsonNamingPolicy.CamelCase
	};

	public ApiClient(HttpClient http, IHttpContextAccessor httpContextAccessor)
	{
		_http = http;
		_httpContextAccessor = httpContextAccessor;

		var token = _httpContextAccessor.HttpContext
			.Request.Cookies["X-Access-Token"];
		if (!string.IsNullOrWhiteSpace(token))
		{
			_http.DefaultRequestHeaders.Add("Authorization", $"bearer {token}");
		}
		else
		{
			_http.DefaultRequestHeaders.Add("Authorization", string.Empty);
		}
	}

	public async Task<TokenResponse> LoginAsync(LoginModel model, CancellationToken cancellationToken)
	{
		HttpResponseMessage response = await _http.PostAsync("Authentication/RequestToken", GetContent(model), cancellationToken);

		if (response.IsSuccessStatusCode)
		{
			var responseStr = await response.Content.ReadAsStringAsync();
			return JsonSerializer.Deserialize<TokenResponse>(responseStr, _options);
		}

		throw new Exception("Could not log in");
	}

	public async Task<IEnumerable<MarketModel>> GetAllMarkets(CancellationToken cancellationToken)
	{
		HttpResponseMessage response = await _http.GetAsync("Markets/GetAllMarkets", cancellationToken);

		if (response.IsSuccessStatusCode)
		{
			var responseStr = await response.Content.ReadAsStringAsync();
			return JsonSerializer.Deserialize<IEnumerable<MarketModel>>(responseStr, _options);
		}

		throw new Exception("Client could not get all markets");
	}

	public async Task UpdateCompanyPrice(CompanyModel model, CancellationToken cancellationToken)
	{
		var response = await _http.PostAsync("Markets/UpdateCompanyPrice", GetContent(model), cancellationToken);
	}

	private static HttpContent GetContent(object model)
	{
		string message = JsonSerializer.Serialize(model);
		byte[] bytes = Encoding.UTF8.GetBytes(message);
		var content = new ByteArrayContent(bytes);
		content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");

		return content;
	}
}
