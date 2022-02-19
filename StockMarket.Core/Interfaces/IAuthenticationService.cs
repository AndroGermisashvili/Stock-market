using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockMarket.Common.Models;

namespace StockMarket.Core.Interfaces;

public interface IAuthenticationService
{
	Task<bool> LoginUser(LoginModel login);
	Task<TokenResponse> RequestTokenAsync(LoginModel tokenRequest);
}
