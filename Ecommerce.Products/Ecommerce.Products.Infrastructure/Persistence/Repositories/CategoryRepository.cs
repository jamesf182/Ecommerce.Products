using Ecommerce.Products.Domain.Entities.CategoryEntity;
using Ecommerce.Products.Domain.Repositories;
using Ecommerce.Products.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Products.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EcommerceProductsDbContext _dbContext;

        public CategoryRepository(EcommerceProductsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Category> GetByIdAsync(CategoryId id, bool asNoTracking = false)
        {
            IQueryable<Category> query = _dbContext.Categories;

            if (asNoTracking)
                query = query.AsNoTracking();

            return await query.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddAsync(Category category)
        {
            await _dbContext.AddAsync(category);
        }

        public async Task UpdateAsync(Category category)
        {
            _dbContext.Entry(category).State = EntityState.Modified;
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Guid id)
        {
            var category = await _dbContext.Categories.FindAsync(id);
            if (category != null)
            {
                _dbContext.Categories.Remove(category);
            }
        }
    }
}
