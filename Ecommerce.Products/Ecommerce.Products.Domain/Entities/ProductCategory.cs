using Ecommerce.Products.Domain.Entities.CategoryEntity;
using Ecommerce.Products.Domain.Entities.ProductEntity;

namespace Ecommerce.Products.Domain.Entities
{
    public sealed class ProductCategory
    {
        public ProductId ProductId { get; private set; }
        public Product Product { get; private set; }

        public CategoryId CategoryId { get; private set; }
        public Category Category { get; private set; }

        public ProductCategory(ProductId productId, CategoryId categoryId)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }
    }
}
