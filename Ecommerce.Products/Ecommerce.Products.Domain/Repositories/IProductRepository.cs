using Ecommerce.Products.Domain.Entities.ProductEntity;

namespace Ecommerce.Products.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(ProductId id, bool asNoTracking = false);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Guid id);
    }
}
