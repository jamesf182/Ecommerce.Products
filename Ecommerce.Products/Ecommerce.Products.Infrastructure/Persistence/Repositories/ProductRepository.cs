using Ecommerce.Products.Domain.Entities;
using Ecommerce.Products.Domain.Repositories;
using Ecommerce.Products.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Products.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EcommerceProductsDbContext _dbContext;

        public ProductRepository(EcommerceProductsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> GetByIdAsync(Guid id, bool asNoTracking = false)
        {
            IQueryable<Product> query = _dbContext.Products;

            if (asNoTracking)
                query = query.AsNoTracking();

            return await query.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddAsync(Product product)
        {
            await _dbContext.AddAsync(product);
        }

        public async Task UpdateAsync(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Guid id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
            }
        }
    }
}
