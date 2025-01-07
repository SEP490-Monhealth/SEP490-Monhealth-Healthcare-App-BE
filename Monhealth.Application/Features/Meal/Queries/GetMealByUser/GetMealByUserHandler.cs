using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Meal.Queries.GetMealByUser
{
    public class GetMealByUserHandler : IRequestHandler<GetMealByUserQuery, List<GetMealByUserDTO>>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IPortionRepository _portionRepository;

        public GetMealByUserHandler(IMealRepository mealRepository, IPortionRepository portionRepository)
        {
            _mealRepository = mealRepository ;
            _portionRepository = portionRepository ;
        }

        public async Task<List<GetMealByUserDTO>> Handle(GetMealByUserQuery request, CancellationToken cancellationToken)
        {
            // Lấy danh sách meal theo UserId
            var meals = await _mealRepository.GetMealByUser(request.UserId);
            if (meals == null || !meals.Any())
                throw new Exception("Người dùng không tồn tại hoặc không có bữa ăn");

            var result = new List<GetMealByUserDTO>();

            foreach (var meal in meals)
            {
                // Khởi tạo các giá trị dinh dưỡng tổng cộng
                float totalCalories = 0;
                float totalProtein = 0;
                float totalCarbs = 0;
                float totalFat = 0;
                float totalFiber = 0;
                float totalSugar = 0;

                foreach (var mealFood in meal.MealFoods)
                {
                    if(mealFood.Status){

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
                    // Kiểm tra MealFood hợp lệ
                }

                // Tạo DTO cho Meal
                var mealDTO = new GetMealByUserDTO
                {
                    MealId = meal.MealId,
                    MealType = meal.MealType,
                    Nutrition = new MealFoodNutritionDTO2
                    {
                        Calories = totalCalories,
                        Protein = totalProtein,
                        Carbs = totalCarbs,
                        Fat = totalFat,
                        Fiber = totalFiber,
                        Sugar = totalSugar
                    },
                    CreatedAt = meal.CreatedAt,
                    UpdatedAt = meal.UpdatedAt
                };

                result.Add(mealDTO);
            }

            return result;
        }
    }
}
