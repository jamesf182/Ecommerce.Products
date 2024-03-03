using Ecommerce.Products.Domain.Entities;

namespace Ecommerce.Products.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(Guid id, bool asNoTracking = false);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Guid id);
    }
}
