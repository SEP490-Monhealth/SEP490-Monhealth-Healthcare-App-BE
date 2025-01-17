using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Food.Queries.GetFoodsByCategoryName
{
    public class GetFoodByCategoryNameHandler : IRequestHandler<GetFoodByCategoryNameQuery, List<GetFoodByCategoryNameDTO>>
    {
        private readonly IFoodRepository _foodRepository;

        public GetFoodByCategoryNameHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public async Task<List<GetFoodByCategoryNameDTO>> Handle(GetFoodByCategoryNameQuery request, CancellationToken cancellationToken)
        {
            var query = await _foodRepository.GetFoodsByCategoryNameAsync(request.categoryNames);
            return query.Select(f => new GetFoodByCategoryNameDTO
            {
                FoodDescription = f.FoodDescription,
                FoodId = f.FoodId,
                FoodName = f.FoodName,
                UserId = f.UserId,
                Status = f.Status,
                Nutrition = new GetNutritionForGetAllFoodDTO1
                {
                    Calories = f.Nutrition.Calories,
                },
                Portion = f.FoodPortions.Select(fp => fp.Portion)
                 .FirstOrDefault() != null ? new GetPortionForGetAllFoodDTO1
                 {
                     PortionSize = f.FoodPortions.Select(fp => fp.Portion).First().PortionSize,
                     PortionWeight = f.FoodPortions.Select(fp => fp.Portion).First().PortionWeight,
                     MeasurementUnit = f.FoodPortions.Select(fp => fp.Portion).First().MeasurementUnit
                 } : null


            }).ToList();
        }
    }
}