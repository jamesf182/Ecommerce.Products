namespace Ecommerce.Products.Domain.Entities
{
    public sealed class Category : BaseEntity
    {
        public string Name { get; private set; }

        public List<ProductCategory> Products { get; private set; }

        public Category(string name)
        {            
            Name = name;
        }
    }
}
