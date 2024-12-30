using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.MealFood.Queries
{
    public class GetMealFoodByMealIdQueryHandler : IRequestHandler<GetMealFoodByMealIdQuery, List<GetMealFoodByMealIdDTO>>
    {
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IPortionRepository _portionRepository;
        public GetMealFoodByMealIdQueryHandler(IMealFoodRepository mealFoodRepository,
        IPortionRepository portionRepository)
        {
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
        }

        public async Task<List<GetMealFoodByMealIdDTO>> Handle(GetMealFoodByMealIdQuery request, CancellationToken cancellationToken)
        {
            var mealFood = await _mealFoodRepository.GetMealFoodByMealId(request.MealId);
            if (mealFood == null) throw new Exception("Bữa ăn không tồn tại.");


            var result = mealFood.Select(mf => new GetMealFoodByMealIdDTO
            {
                MealFoodId = mf.MealFoodId,
                FoodId = mf.FoodId,
                Quantity = mf.Quantity,
                Name = mf.Food?.FoodName,
                Nutrition = new NutritionDTO1
                {
                    Calories = mf.Food?.Nutrition != null && mf.Food.FoodPortions?.Any() == true
                 ? (mf.Food.Nutrition.Calories / (mf.Food.FoodPortions.FirstOrDefault()?.Portion.PortionWeight ?? 1))
                   * (mf.Quantity * (mf.Food.FoodPortions.FirstOrDefault()?.Portion.PortionWeight ?? 1))
                 : 0
                },
                Portions = new MealFoodPortionDTO1
                {
                    Size = mf.Food?.FoodPortions?.FirstOrDefault()?.Portion.PortionSize ?? string.Empty,
                    Weight = mf.Food?.FoodPortions?.FirstOrDefault()?.Portion.PortionWeight,
                    Unit = mf.Food?.FoodPortions?.FirstOrDefault()?.Portion.MeasurementUnit ?? string.Empty,
                },
                CreatedAt = mf.CreatedAt,
                UpdatedAt = mf.UpdatedAt

            }).ToList();
            return result;
        }
    }

}
