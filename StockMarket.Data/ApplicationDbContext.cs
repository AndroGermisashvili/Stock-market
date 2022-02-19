using Microsoft.EntityFrameworkCore;

using StockMarket.Data.Configurations;
using StockMarket.Data.Entities;
using StockMarket.Data.Seed;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Market> Markets { get; set; }

    public DbSet<Company> Companies { get; set; }

	public DbSet<CompanyMarket> CompanyMarket { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureEntities();
		builder.ApplyGeneralData();
    }
}
