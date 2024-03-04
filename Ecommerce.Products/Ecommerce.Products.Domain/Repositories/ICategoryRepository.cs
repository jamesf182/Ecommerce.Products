using Ecommerce.Products.Domain.Entities.CategoryEntity;

namespace Ecommerce.Products.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetByIdAsync(CategoryId id, bool asNoTracking = false);
        Task AddAsync(Category product);
        Task UpdateAsync(Category product);
        Task DeleteAsync(Guid id);
    }
}
