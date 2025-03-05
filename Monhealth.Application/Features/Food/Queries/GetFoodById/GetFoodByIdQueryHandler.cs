using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Food.Queries.GetFoodById
{
    public class GetFoodByIdQueryHandler : IRequestHandler<GetFoodByIdQuery, GetFoodByIdDTO>
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IMapper _mapper;

        public GetFoodByIdQueryHandler(IFoodRepository foodRepository,
        IMapper mapper)
        {
            _foodRepository = foodRepository;
            _mapper = mapper;
        }

        public async Task<GetFoodByIdDTO> Handle(GetFoodByIdQuery request, CancellationToken cancellationToken)
        {
            var gettingFood = await _foodRepository.GetFoodByIdAsync(request.FoodId);
            var result = new GetFoodByIdDTO
            {
                Category = gettingFood.CategoryFoods?.Select(x => x.Category.CategoryName).FirstOrDefault() ?? "",
                CreatedAt = gettingFood.CreatedAt,
                MealType = gettingFood.MealType,
                DishType = gettingFood.DishType,
                FoodDescription = gettingFood.FoodDescription,
                Allergies = gettingFood.FoodAllergies?.
                Select(fa => fa.Allergy.AllergyName).ToList(),
                FoodName = gettingFood.FoodName,
                IsPublic = gettingFood.IsPublic,
                Status = gettingFood.Status,
                UpdatedAt = gettingFood.UpdatedAt
            };
            return result;
        }
    }
}