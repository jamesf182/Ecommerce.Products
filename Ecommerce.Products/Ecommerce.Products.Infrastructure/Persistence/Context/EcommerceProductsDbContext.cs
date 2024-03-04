using Ecommerce.Products.Domain.Entities;
using Ecommerce.Products.Domain.Entities.CategoryEntity;
using Ecommerce.Products.Domain.Entities.ProductEntity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Ecommerce.Products.Infrastructure.Persistence.Context
{
    public class EcommerceProductsDbContext(DbContextOptions<EcommerceProductsDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
