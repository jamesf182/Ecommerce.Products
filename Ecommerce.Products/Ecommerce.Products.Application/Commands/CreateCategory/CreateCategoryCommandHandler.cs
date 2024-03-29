﻿using Ecommerce.Products.Domain.Entities.CategoryEntity;
using Ecommerce.Products.Domain.Repositories;
using Ecommerce.Products.Infrastructure.Persistence.UnitOfWork;
using MediatR;

namespace Ecommerce.Products.Application.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CategoryId>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryId> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category(request.Name);

            await _unitOfWork.BeginTransactionAsync();
            await _categoryRepository.AddAsync(category);
            await _unitOfWork.CommitAsync();

            return category.Id;
        }
    }
}
