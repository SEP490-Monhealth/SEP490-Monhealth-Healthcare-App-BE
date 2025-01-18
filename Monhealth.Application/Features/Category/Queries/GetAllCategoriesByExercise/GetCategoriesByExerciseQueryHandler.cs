using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Category.Queries.GetAllCategoriesByExercise
{
    public class GetCategoriesByExerciseQueryHandler : IRequestHandler<GetCategoriesByExerciseQuery, List<GetCategoriesByExerciseDTO>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoriesByExerciseQueryHandler(ICategoryRepository categoryRepository
        , IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<GetCategoriesByExerciseDTO>> Handle(GetCategoriesByExerciseQuery request, CancellationToken cancellationToken)
        {
            var queries = await _categoryRepository.GetCategoriesByExerciseType();
            var result = queries.Select(cat => new GetCategoriesByExerciseDTO
            {
                CategoryDescription = cat.CategoryDescription,
                CategoryId = cat.CategoryId,
                CategoryName = cat.CategoryName,
                Image = cat.Image,
            }).ToList();
            return result;
        }
    }
}