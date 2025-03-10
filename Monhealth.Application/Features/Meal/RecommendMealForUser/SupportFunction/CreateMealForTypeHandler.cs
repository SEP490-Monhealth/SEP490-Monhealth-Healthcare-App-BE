using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Meal.RecommendMealForUser.SupportFunction
{
    public class CreateMealForTypeHandler
    {
        private readonly ILogger<CreateMealForTypeHandler> _logger;
        private readonly IFoodPortionRepository _foodPortionRepository;
        private readonly IPortionRepository _portionRepository;
        public CreateMealForTypeHandler(ILogger<CreateMealForTypeHandler> logger,
        IFoodPortionRepository foodPortionRepository,
        IPortionRepository portionRepository)
        {
            _logger = logger;
            _foodPortionRepository = foodPortionRepository;
            _portionRepository = portionRepository;
        }

        public async Task<Domain.Meal> CreateMealForType(List<Domain.Food> foodList, MealType mealType,
        float mealCalories, DateTime targetDate, Guid userId, GoalType goalType)
        {
            var meal = new Domain.Meal
            {
                UserId = userId,
                MealType = mealType,
                CreatedAt = targetDate,
                UpdatedAt = DateTime.Now,
                MealFoods = new List<Domain.MealFood>()  // Đảm bảo MealFoods được khởi tạo
            };

            // Kiểm tra xem foodList có dữ liệu không
            if (foodList == null || !foodList.Any())
            {
                _logger.LogInformation("foodList is empty or null.");
                return meal;
            }

            // Lọc các món ăn dựa trên calo
            var selectedFoods = foodList.Where(f =>
            f.Nutrition != null &&
            ((f.Nutrition.Carbs * 4 + f.Nutrition.Protein * 4 + f.Nutrition.Fat * 9) <= mealCalories)) // Kiểm tra tổng calo của món ăn
            .ToList();


            // Kiểm tra kết quả selectedFoods
            if (selectedFoods.Count == 0)
            {
                _logger.LogInformation("No foods selected based on the calories filter.");
            }

            Random rd = new Random();
            // tinh CarbsFood

            var carbsFood = selectedFoods
                            .Where(f =>
                                f.Nutrition.Carbs * 4 /
                                (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) > 0.5f
                            )
                            .Where(f =>
                                f.Nutrition.Protein * 4
                                / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) <= 0.5f
                            )
                            .OrderBy(f => rd.Next()).FirstOrDefault();
            if (carbsFood == null) throw new Exception();


            //Check FoodCarbs     
            var existingMealFoodCarbs = carbsFood.MealFoods
            .FirstOrDefault(mf => mf.FoodId == carbsFood.FoodId);

            if (carbsFood != null)
            {
                float mealCaloriesOfCarbs = mealCalories * (goalType == GoalType.WeightLoss ? 0.40f
             : goalType == GoalType.WeightGain ? 0.50f : 0.45f);
                if (existingMealFoodCarbs == null)
                {
                    var totalFoodCalories = (carbsFood.Nutrition.Carbs * 4)
                    + (carbsFood.Nutrition.Protein * 4)
                    + (carbsFood.Nutrition.Fat * 9);
                    // Giới hạn khẩu phần tối đa 800g để tránh lượng calorie quá cao
                    const float MAX_PORTION_WEIGHT = 800.0f;

                    var portionWeight = (mealCaloriesOfCarbs / Math.Max(totalFoodCalories, 1)) * 100;
                    portionWeight = Math.Min(portionWeight, MAX_PORTION_WEIGHT); // Không vượt quá 800g



                    float adjustedCarbs = (carbsFood.Nutrition.Carbs * portionWeight) / 100;
                    float adjustedProtein = (carbsFood.Nutrition.Protein * portionWeight) / 100;
                    float adjustedFat = (carbsFood.Nutrition.Fat * portionWeight) / 100;

                    float adjustedCalories = (adjustedCarbs * 4) + (adjustedProtein * 4) + (adjustedFat * 9);
                    float error = Math.Abs(adjustedCalories - mealCaloriesOfCarbs);
                    if (error > 5)  // Chấp nhận sai số trong khoảng 5 kcal
                    {
                        _logger.LogWarning($"Lượng calorie tính toán lệch {error} kcal so với mục tiêu.");
                    }


                    Portion portion = new Portion();

                    portion = new Portion
                    {
                        MeasurementUnit = "gram",
                        PortionSize = "unit",
                        PortionWeight = portionWeight,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };

                    _portionRepository.Add(portion);
                    await _portionRepository.SaveChangesAsync();

                    var foodPortion1 = new FoodPortion
                    {
                        FoodId = carbsFood.FoodId,
                        PortionId = portion.PortionId
                    };
                    _foodPortionRepository.Add(foodPortion1);
                    await _portionRepository.SaveChangesAsync();

                    var mealFood = new Domain.MealFood
                    {
                        FoodId = carbsFood.FoodId,
                        Quantity = 1,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        IsCompleted = false,
                        IsRecommended = true,
                        PortionId = portion.PortionId
                    };
                    meal.MealFoods.Add(mealFood);
                    _logger.LogInformation($"Added MealFood: FoodId = {carbsFood.FoodId}, PortionWeight = {portionWeight}, MealType = {mealType}");


                }
                else
                {
                    existingMealFoodCarbs.Quantity += 1; // Cập nhật số lượng nếu món ăn đã tồn tại
                    existingMealFoodCarbs.UpdatedAt = DateTime.Now;
                    _logger.LogInformation($"MealFood Count after adding: {meal.MealFoods.Count()}");

                }
            }

            //Them mon Protein cho Food

            // tinh ProteinFood
            var proteinFood = selectedFoods
                .Where(f =>
                    f.Nutrition.Protein * 4 / (f.Nutrition.Protein * 4
                    + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) > 0.5f
                )
                .Where(f =>
                    f.Nutrition.Carbs * 4 / (f.Nutrition.Protein * 4
                    + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) <= 0.5f
                )
                .OrderBy(f => rd.Next()).FirstOrDefault();
            if (proteinFood == null) throw new Exception();

            var existingMealFoodProtein = proteinFood.MealFoods
            .FirstOrDefault(mf => mf.FoodId == proteinFood.FoodId);
            if (proteinFood != null)
            {
                float mealCaloriesOfProteins = mealCalories * (goalType == GoalType.WeightLoss ? 0.60f
                 : goalType == GoalType.WeightGain ? 0.50f : 0.55f);

                if (existingMealFoodProtein == null)
                {
                    var totalFoodCalories = (proteinFood.Nutrition.Carbs * 4)
                    + (proteinFood.Nutrition.Protein * 4)
                    + (proteinFood.Nutrition.Fat * 9);
                    // Giới hạn khẩu phần tối đa 800g để tránh lượng calorie quá cao
                    const float MAX_PORTION_WEIGHT = 800.0f;

                    var portionWeight = (mealCaloriesOfProteins / Math.Max(totalFoodCalories, 1)) * 100;
                    portionWeight = Math.Min(portionWeight, MAX_PORTION_WEIGHT); // Không vượt quá 800g


                    var portion = new Portion();

                    portion = new Portion
                    {
                        MeasurementUnit = "gram",
                        PortionSize = "unit",
                        PortionWeight = portionWeight,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };

                    _portionRepository.Add(portion);
                    await _portionRepository.SaveChangesAsync();

                    var foodPortion1 = new FoodPortion
                    {
                        FoodId = proteinFood.FoodId,
                        PortionId = portion.PortionId
                    };
                    _foodPortionRepository.Add(foodPortion1);
                    await _portionRepository.SaveChangesAsync();


                    var mealFood = new Domain.MealFood
                    {
                        FoodId = proteinFood.FoodId,
                        Quantity = 1,  // Có thể tính toán lại số lượng nếu cần
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        IsCompleted = false,
                        IsRecommended = true,
                        PortionId = portion.PortionId
                    };
                    meal.MealFoods.Add(mealFood);
                    _logger.LogInformation($"Added MealFood: FoodId = {proteinFood.FoodId}, PortionWeight = {portionWeight}, MealType = {mealType}");


                }
                else
                {
                    existingMealFoodProtein.Quantity += 1; // Cập nhật số lượng nếu món ăn đã tồn tại
                    existingMealFoodProtein.UpdatedAt = DateTime.Now;
                    _logger.LogInformation($"MealFood Count after adding: {meal.MealFoods.Count()}");

                }

            }


            // Chọn món phụ (Vegetables)
            var vegetableFood = selectedFoods
                .Where(f => f.Nutrition.Fiber > 2) // Điều kiện chọn rau (có nhiều chất xơ)
                .OrderBy(f => rd.Next())
                .FirstOrDefault();
        
            var existingMealFoodVegetables = vegetableFood?.MealFoods
                        .FirstOrDefault(mf => mf.FoodId == vegetableFood?.FoodId);


            if (vegetableFood != null)
            {
                float mealCaloriesOfVegetables = mealCalories * (goalType == GoalType.WeightLoss ? 0.30f
                : goalType == GoalType.WeightGain ? 0.20f : 0.25f);

                var totalFoodCalories = (vegetableFood.Nutrition.Carbs * 4)
                                      + (vegetableFood.Nutrition.Protein * 4)
                                      + (vegetableFood.Nutrition.Fat * 9);
                // Giới hạn khẩu phần tối đa 800g để tránh lượng calorie quá cao
                const float MAX_PORTION_WEIGHT = 800.0f;

                var portionWeight = (mealCaloriesOfVegetables / Math.Max(totalFoodCalories, 1)) * 100;
                portionWeight = Math.Min(portionWeight, MAX_PORTION_WEIGHT); // Không vượt quá 800g

                var portion = new Portion
                {
                    MeasurementUnit = "gram",
                    PortionSize = "unit",
                    PortionWeight = portionWeight,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                _portionRepository.Add(portion);
                await _portionRepository.SaveChangesAsync();

                var foodPortion = new FoodPortion
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = portion.PortionId
                };

                _foodPortionRepository.Add(foodPortion);
                await _portionRepository.SaveChangesAsync();

                var mealFood = new Domain.MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    Quantity = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsCompleted = false,
                    IsRecommended = true,
                    PortionId = portion.PortionId
                };

                meal.MealFoods.Add(mealFood);
                _logger.LogInformation($"Added Vegetable: FoodId = {vegetableFood.FoodId}, PortionWeight = {portionWeight}, MealType = {mealType}");
            }
            else
            {
                if (existingMealFoodVegetables != null)
                {
                    existingMealFoodVegetables.Quantity += 1; // Cập nhật số lượng nếu món ăn đã tồn tại
                    existingMealFoodVegetables.UpdatedAt = DateTime.Now;
                }
                _logger.LogInformation($"MealFood Count after adding: {meal.MealFoods.Count()}");

            }

            return meal;
        }
    }
}