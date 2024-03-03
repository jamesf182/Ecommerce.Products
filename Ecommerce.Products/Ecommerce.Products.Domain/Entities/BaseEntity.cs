namespace Ecommerce.Products.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity() 
        {
            
        }

        public Guid Id { get; private set; }
    }
}
