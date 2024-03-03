using MediatR;

namespace Ecommerce.Products.Application.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
