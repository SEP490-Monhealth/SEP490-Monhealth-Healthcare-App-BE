using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

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
                throw new Exception("Danh mục đã tồn tại");
            }
            var model = new Monhealth.Domain.Category
            {
                CategoryName = request.CategoryName,
                CategoryDescription = request.CategoryDescription,
                CategoryImage = request.CategoryImage,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _categoryRepository.Add(model);
            await _categoryRepository.SaveChangeAsync();
            return new CategoryRequest
            {
                CategoryName = model.CategoryName,
                CategoryDescription = model.CategoryDescription
            };

        }
    }
}