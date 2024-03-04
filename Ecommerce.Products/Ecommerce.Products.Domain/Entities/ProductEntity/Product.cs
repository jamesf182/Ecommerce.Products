namespace Ecommerce.Products.Domain.Entities.ProductEntity
{
    public sealed class Product
    {
        public ProductId Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public List<ProductCategory> Categories { get; private set; }

        public Product(string name, string description, decimal price, int stockQuantity)
        {
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            CreatedAt = DateTime.Now;
        }
    }
}
