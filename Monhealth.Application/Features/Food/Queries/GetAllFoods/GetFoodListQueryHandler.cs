using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoods
{
    public class GetFoodListQueryHandler : IRequestHandler<GetFoodListQuery, PageResult<FoodDTO>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodListQueryHandler(IFoodRepository foodRepository, IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<PageResult<FoodDTO>> Handle(GetFoodListQuery request, CancellationToken cancellationToken)
        {
            var paginatedUser = await _foodRepository.GetAllFoodAsync(request.Page, request.Limit, request.Search, request.Status , request.CategoryName);
            var foodList = paginatedUser.Items.ToList();
            var foodDtoList = _mapper.Map<List<FoodDTO>>(foodList);
            return new PageResult<FoodDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(paginatedUser.TotalCount / (double)request.Limit),
                TotalItems = paginatedUser.TotalCount,
                Items = foodDtoList
            };
        }
    }
}