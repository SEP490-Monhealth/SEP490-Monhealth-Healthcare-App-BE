using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Category.Queries.GetAllCategories;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetCategoryListQueryHandler : IRequestHandler<GetCategoryListQuery, PageResult<CategoryDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoryListQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<PageResult<CategoryDTO>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
         
            var categories = await _categoryRepository
             .GetAllCategoryAsync(request.Page, request.Limit, request.Search, request.Type);
            var categoryList = categories.Items.Select(c => new CategoryDTO
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
                CategoryType = c.CategoryType,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                CategoryDescription = c.CategoryDescription ?? string.Empty,

            }).ToList();

            return new PageResult<CategoryDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(categories.TotalCount / (double)request.Limit),
                TotalItems = categories.TotalCount,
                Items = categoryList
            };

        }
    }
}
