namespace Ecommerce.Products.Domain.Entities
{
    public sealed class Product : BaseEntity
    {        
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public List<ProductCategory> Categories { get; private set; }
    }
}
