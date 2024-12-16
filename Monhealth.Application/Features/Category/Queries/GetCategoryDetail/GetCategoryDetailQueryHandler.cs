using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Category.Queries.GetCategoryDetail;

namespace Monhealth.Application.Features.Metric.Queries.GetMetricDetail
{
    public class GetCategoryDetailQueryHandler : IRequestHandler<GetCategoryDetailQuery, CategoryDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoryDetailQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryDetailDto> Handle(GetCategoryDetailQuery request, CancellationToken cancellationToken)
        {
            var query = await _categoryRepository.GetByIdAsync(request.CategoryId);
              if (query == null) { throw new Exception("Not found category"); }
            return _mapper.Map<CategoryDetailDto>(query);
        }
    }
}
