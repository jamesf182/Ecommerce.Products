namespace Ecommerce.Products.Domain.Entities.CategoryEntity
{
    public sealed class Category
    {
        public CategoryId Id { get; private set; }
        public string Name { get; private set; }

        public List<ProductCategory> Products { get; private set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}
