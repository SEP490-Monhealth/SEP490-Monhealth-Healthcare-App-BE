using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Category.AddCategory
{
    public class AddCategoryHandler : IRequestHandler<AddCategoryRequest, CategoryRequest>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public AddCategoryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryRequest> Handle(AddCategoryRequest request, CancellationToken cancellationToken)
        {
            var isCategoryExist = await _categoryRepository
          .AnyAsync(c => c.CategoryName == request.CategoryName);

            if (isCategoryExist)
            {
                // Trả về lỗi không hợp lệ
                throw new Exception("CategoryName already exists.");
            }
            var model = new Monhealth.Domain.Category
            {
                CategoryName = request.CategoryName,
                Description = request.Description,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            _categoryRepository.Add(model);
            await _categoryRepository.SaveChangeAsync();
            return new CategoryRequest
            {
                CategoryName = model.CategoryName,
                Description = model.Description
            };

        }
    }
}