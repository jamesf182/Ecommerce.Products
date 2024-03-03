namespace Ecommerce.Products.Domain.Entities
{
    public sealed class ProductCategory
    {
        public Guid ProductId { get; private set; }
        public Product Product { get; private set; }

        public Guid CategoryId { get; private set; }
        public Category Category { get; private set; }        
    }
}
