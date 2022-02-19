using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Common.Configs;

public class AuthConfiguration
{
	public const string Name = "AuthConfig";
	public string Username { get; set; }
	public string Password { get; set; }
	public string Key { get; set; }
}
