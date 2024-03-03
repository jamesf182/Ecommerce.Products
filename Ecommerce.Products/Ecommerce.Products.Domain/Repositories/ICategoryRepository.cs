using Ecommerce.Products.Domain.Entities;

namespace Ecommerce.Products.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetByIdAsync(Guid id, bool asNoTracking = false);
        Task AddAsync(Category product);
        Task UpdateAsync(Category product);
        Task DeleteAsync(Guid id);
    }
}
