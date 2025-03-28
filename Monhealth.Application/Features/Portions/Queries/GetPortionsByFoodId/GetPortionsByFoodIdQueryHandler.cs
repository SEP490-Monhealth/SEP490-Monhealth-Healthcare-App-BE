using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Exercise.Queries.GetAllExercises;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionsByFoodId
{
    public class GetPortionsByFoodIdQueryHandler : IRequestHandler<GetPortionsByFoodIdQuery, PageResult<GetPortionsByFoodIdDto>>
    {
        private readonly IPortionRepository _portionRepository;
        private readonly IMapper _mapper;
        public GetPortionsByFoodIdQueryHandler(IPortionRepository portionRepository, IMapper mapper)
        {
            _portionRepository = portionRepository;
            _mapper = mapper;
        }
        public async Task<PageResult<GetPortionsByFoodIdDto>> Handle(GetPortionsByFoodIdQuery request, CancellationToken cancellationToken)
        {
            var listPortions = await _portionRepository.GetPortionsByFoodIdAsync(request.FoodId, request.Page, request.Limit, request.Search, request.Sort, request.Order);
            var listPortionsDto = _mapper.Map<List<GetPortionsByFoodIdDto>>(listPortions.Items);
            return new PageResult<GetPortionsByFoodIdDto>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listPortions.TotalCount / (double)request.Limit),
                TotalItems = listPortions.TotalCount,
                Items = listPortionsDto
            };
        }
    }
}
