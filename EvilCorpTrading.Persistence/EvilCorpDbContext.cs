using EvilCorpTrading.Application.Interfaces;
using EvilCorpTrading.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EvilCorpTrading.Persistence
{
    public class EvilCorpDbContext : DbContext, IEvilCorpDbContext
    {
        public EvilCorpDbContext(DbContextOptions<EvilCorpDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Region> Region { get; set; }

        public DbSet<Shipper> Shippers { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Territory> Territories { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EvilCorpDbContext).Assembly);
        }
    }
}
