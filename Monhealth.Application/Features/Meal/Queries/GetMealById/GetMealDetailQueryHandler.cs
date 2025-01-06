using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Meal.Queries.GetMealById
{
    public class GetMealDetailQueryHandler : IRequestHandler<GetMealDetailQuery, MealDetailDTo>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IPortionRepository _portionRepository;

        public GetMealDetailQueryHandler(IMealRepository mealRepository,
        IPortionRepository portionRepository)
        {
            _mealRepository = mealRepository;
            _portionRepository = portionRepository;
        }

        public async Task<MealDetailDTo> Handle(GetMealDetailQuery request, CancellationToken cancellationToken)
        {
            var query = await _mealRepository.GetMealByMealId(request.MealId);

            if (query == null) throw new Exception("Bữa ăn không tồn tại.");

            // Khởi tạo các giá trị dinh dưỡng tổng cộng
            float totalCalories = 0;
            float totalProtein = 0;
            float totalCarbs = 0;
            float totalFat = 0;
            float totalFiber = 0;
            float totalSugar = 0;

            foreach (var mealFood in query.MealFoods)
            {
                // Kiểm tra MealFood hợp lệ
                if (mealFood.Food?.Nutrition == null || mealFood.PortionId == Guid.Empty)
                    continue;

                // Lấy Portion từ repository theo PortionId
                var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                if (portion == null)
                    continue;

                var portionWeight = portion.PortionWeight;

                // Tính toán giá trị dinh dưỡng dựa trên portionWeight
                totalCalories += (mealFood.Food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                totalProtein += (mealFood.Food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                totalCarbs += (mealFood.Food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                totalFat += (mealFood.Food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
                totalFiber += (mealFood.Food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                totalSugar += (mealFood.Food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);
            }

            // Tạo DTO kết quả
            var mealDetailDTO = new MealDetailDTo
            {
                UserId = query.UserId,
                MealType = query.MealType,
                Nutrition = new MealFoodNutritionDTO1
                {
                    Calories = totalCalories,
                    Protein = totalProtein,
                    Carbs = totalCarbs,
                    Fat = totalFat,
                    Fiber = totalFiber,
                    Sugar = totalSugar
                },
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt
            };

            return mealDetailDTO;
        }
    }
}