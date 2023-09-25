global using Microsoft.EntityFrameworkCore;
using TradingWebAppFinalProject.Models;

namespace TradingWebAppFinalProject.Data
{
    public class TradingWarehouseDataBase : DbContext
    {
        public TradingWarehouseDataBase(DbContextOptions<TradingWarehouseDataBase> options) : base(options)
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
       
       


    }
}
