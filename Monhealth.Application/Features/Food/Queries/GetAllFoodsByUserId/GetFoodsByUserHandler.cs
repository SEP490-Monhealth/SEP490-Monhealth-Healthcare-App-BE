using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId
{
    public class GetFoodsByUserHandler : IRequestHandler<GetFoodListByUserIdQuery, PageResult<FoodsByUserIdDTO>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodsByUserHandler(IFoodRepository foodRepository,
        IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<PageResult<FoodsByUserIdDTO>> Handle(GetFoodListByUserIdQuery request, CancellationToken cancellationToken)
        {
            var paginatedUser = await _foodRepository.GetFoodByUserId(request.Page, request.Limit, request.UserId);
            var foodList = paginatedUser.Items.ToList();
            var foodDtoList = _mapper.Map<List<FoodsByUserIdDTO>>(foodList);
            return new PageResult<FoodsByUserIdDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(paginatedUser.TotalCount / (double)request.Limit),
                TotalItems = paginatedUser.TotalCount,
                Items = foodDtoList
            };
        }
    }
}