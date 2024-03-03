using Ecommerce.Products.Application.Commands.CreateCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Products.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(1);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoryCommand command)
        {
            var id = await _mediator.Send(command);

            return Ok(id);//CreatedAtAction(nameof(GetById), new { id }, command);
        }
    }
}
