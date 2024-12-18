using System.Text.Json;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Caching;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Category.Queries.GetAllCategories;

namespace Monhealth.Application.Features.Metric.Queries.GetAllMetric
{
    public class GetCategoryListQueryHandler : IRequestHandler<GetCategoryListQuery, List<CategoryDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICacheService _cacheService;
        public GetCategoryListQueryHandler(IMapper mapper,
         ICategoryRepository categoryRepository,
         ICacheService cacheService)
        {
            _mapper = mapper;   
            _categoryRepository = categoryRepository;
            _cacheService = cacheService;
        }
        public async Task<List<CategoryDto>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            const string cacheKey = "CategoryList";

            // 1. Kiểm tra dữ liệu từ cache
            var cachedData = await _cacheService.GetAsync<string>(cacheKey); // Đọc dữ liệu kiểu String
            if (!string.IsNullOrEmpty(cachedData))
            {
                // Deserialize JSON thành List<CategoryDto>
                var categoryDtosFromCache = JsonSerializer.Deserialize<List<CategoryDto>>(cachedData);
                return categoryDtosFromCache;
            }

            // 2. Truy vấn database
            var categories = await _categoryRepository.GetAllCategoryAsync();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories);

            // 3. Serialize dữ liệu thành JSON trước khi lưu vào Redis
            var serializedData = JsonSerializer.Serialize(categoryDtos);

            // 4. Lưu dữ liệu vào cache
            await _cacheService.SetAsync(cacheKey, serializedData, TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(10));

            return categoryDtos;
        }



    }
}
