using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Category.Queries.GetAllCategoriesByType
{
    public class GetCategoriesByTypeQueryHandler : IRequestHandler<GetCategoriesByTypeQuery, List<CategoryByTypeDTO>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoriesByTypeQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryByTypeDTO>> Handle(GetCategoriesByTypeQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetCategoriesByType(request.CategoryType);
            return _mapper.Map<List<CategoryByTypeDTO>>(categories);
        }
    }
}
