using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Food.Queries.GetAllFoodsByUserId
{
    public class GetFoodsByUserHandler : IRequestHandler<GetFoodListByUserIdQuery, List<FoodsByUserIdDTO>>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodsByUserHandler(IFoodRepository foodRepository,
        IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<List<FoodsByUserIdDTO>> Handle(GetFoodListByUserIdQuery request, CancellationToken cancellationToken)
        {
            var foods = await _foodRepository.GetFoodByUserId(request.UserId);
            if (foods == null) throw new Exception("Người dùng không tồn tại.");
            return _mapper.Map<List<FoodsByUserIdDTO>>(foods);
        }
    }
}