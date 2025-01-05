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
            _portionRepository = portionRepository ;
        }

        public async Task<List<GetMealFoodByMealIdDTO>> Handle(GetMealFoodByMealIdQuery request, CancellationToken cancellationToken)
        {
            var mealFood = await _mealFoodRepository.GetMealFoodByMealId(request.MealId);
            if (mealFood == null || !mealFood.Any())
                throw new Exception("Bữa ăn không tồn tại hoặc không có món ăn nào trong bữa.");

            var result = new List<GetMealFoodByMealIdDTO>();

            foreach (var mf in mealFood)
            {
                if (mf.Food?.Nutrition == null || mf.PortionId == Guid.Empty)
                    continue;

                // Lấy Portion từ repository
                var portion = await _portionRepository.GetByIdAsync(mf.PortionId);
                if (portion == null)
                    continue;

                var portionWeight = portion.PortionWeight;

                // Tạo DTO cho từng MealFood
                var mealFoodDTO = new GetMealFoodByMealIdDTO
                {
                    MealFoodId = mf.MealFoodId,
                    FoodId = mf.FoodId,
                    Quantity = mf.Quantity,
                    Name = mf.Food?.FoodName,
                    Nutrition = new NutritionDTO1
                    {
                        Calories = (mf.Food.Nutrition.Calories / 100) * (mf.Quantity * portionWeight)
                    },
                    Portions = new MealFoodPortionDTO1
                    {
                        Size = portion.PortionSize ?? string.Empty,
                        Weight = portion.PortionWeight,
                        Unit = portion.MeasurementUnit ?? string.Empty,
                    },
                    CreatedAt = mf.CreatedAt,
                    UpdatedAt = mf.UpdatedAt
                };

                result.Add(mealFoodDTO);
            }

            return result;
        }
    }
}
