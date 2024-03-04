using Ecommerce.Products.Domain.Entities.CategoryEntity;
using MediatR;

namespace Ecommerce.Products.Application.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<CategoryId>
    {
        public string Name { get; set; }
    }
}
