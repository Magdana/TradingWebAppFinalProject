global using Microsoft.EntityFrameworkCore;
using TradingWebAppFinalProject.Models;

namespace TradingWebAppFinalProject.Data
{
    public class TradingWarehouseDataBase : DbContext
    {
        public TradingWarehouseDataBase(DbContextOptions<TradingWarehouseDataBase> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CustomerPhoneNumber> CustomerPhoneNumbers { get; set; }
        public DbSet<CustomersRelationship> CustomersRelationships { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PhoneNumbersList> PhoneNumbersLists { get; set; }
        public DbSet<PhoneType> PhoneTypes { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<RelationshipType> RelationshipTypes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Unit> Units { get; set; }





    }
}
