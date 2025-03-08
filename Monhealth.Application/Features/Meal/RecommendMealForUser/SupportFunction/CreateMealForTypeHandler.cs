using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Food.AddFoodUser;
using Monhealth.Core.Enum;
using Monhealth.Domain;

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

        public async Task<Domain.Meal> CreateMealForType(List<Domain.Food> foodList, MealType mealType, float mealCalories, DateTime targetDate, Guid userId)
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

            // Tạo các nhóm món ăn theo MealType (Main Dish và Side Dish)


            // foreach (var food in selectedFoods)
            // {
            //     // Tính tổng calories và các tỷ lệ dinh dưỡng
            //     var totalCalories = food.Nutrition.Protein * 4 + food.Nutrition.Carbs * 4 + food.Nutrition.Fat * 9;
            //     var carbsRatio = (food.Nutrition.Carbs * 4) / totalCalories;
            //     var proteinRatio = (food.Nutrition.Protein * 4) / totalCalories;
            //     var fatRatio = (food.Nutrition.Fat * 9) / totalCalories;

            //     // Lọc món ăn theo tỷ lệ dinh dưỡng
            //     if (carbsRatio > 0.5f && proteinRatio > 0.5f) // Nếu món ăn chứa cả Carbs và Protein (Main Dish)
            //     {
            //         if (!mainDishAdded)
            //         {
            //             mainDishFoods.Add(food); // Chỉ thêm món đầu tiên chứa Carbs và Protein
            //             mainDishAdded = true;
            //         }
            //     }
            //     else if (carbsRatio > 0.5f || proteinRatio > 0.5f)  // Món ăn chứa Carbs hoặc Protein (Side Dish)
            //     {
            //         sideDishFoods.Add(food);  // Thêm vào Side Dish
            //     }
            //     else
            //     {
            //         // Các món ăn khác (ví dụ Vegetables)
            //         sideDishFoods.Add(food);
            //     }
            // }



            Random rd = new Random();
            // tinh CarbsFood
            var carbsFood = selectedFoods
                .Where(f =>
                    f.Nutrition.Carbs * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) > 0.5f
                )
                .Where(f =>
                    f.Nutrition.Protein * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) <= 0.5f
                )
                .OrderBy(f => rd.Next()).FirstOrDefault();
            if (carbsFood == null) throw new Exception();

            // tinh ProteinFood
            var proteinFood = selectedFoods
                .Where(f =>
                    f.Nutrition.Protein * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) > 0.5f
                )
                .Where(f =>
                    f.Nutrition.Carbs * 4 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) <= 0.5f
                )
                .OrderBy(f => rd.Next()).FirstOrDefault();
            if (proteinFood == null) throw new Exception();

            //Check FoodCarbs     
            var existingMealFoodCarbs = carbsFood.MealFoods
            .FirstOrDefault(mf => mf.FoodId == carbsFood.FoodId);

            //Check FoodProtein
            var existingMealFoodProtein = proteinFood.MealFoods
            .FirstOrDefault(mf => mf.FoodId == proteinFood.FoodId);


            // tinh FatFood
            var fatFood = selectedFoods
            .Where(f =>
            f.Nutrition.Fat * 9 / (f.Nutrition.Protein * 4 + f.Nutrition.Carbs * 4 + f.Nutrition.Fat * 9) > 0.5f
                 ).OrderBy(f => rd.Next()).FirstOrDefault();
            if (fatFood == null) throw new Exception();






            if (existingMealFoodCarbs == null)
            {
                var totalFoodCalories = (carbsFood.Nutrition.Carbs * 4) + (carbsFood.Nutrition.Protein * 4) + (carbsFood.Nutrition.Fat * 9);
                var portionWeight = (mealCalories / totalFoodCalories);
                // var foodPortion = await _foodPortionRepository.GetByFoodIdAsync(carbsFood.FoodId);
                // if (foodPortion == null || foodPortion.Portion == null)
                // {
                //     _logger.LogInformation("Portion not found for this food.");
                //     throw new Exception();
                // }
                // var portion = foodPortion.Portion.PortionId;
                Portion portion = new Portion();

                portion = new Portion
                {
                    MeasurementUnit = "gram", // Đây là ví dụ, bạn có thể thay đổi tùy vào dữ liệu của mình
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
                    Quantity = 1,  // Có thể tính toán lại số lượng nếu cần
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
            //Them mon Protein cho Food
            if (existingMealFoodProtein == null)
            {
                var totalFoodCalories = (carbsFood.Nutrition.Carbs * 4) + (carbsFood.Nutrition.Protein * 4) + (carbsFood.Nutrition.Fat * 9);
                var portionWeight = (mealCalories / totalFoodCalories);
                // var foodPortion = await _foodPortionRepository.GetByFoodIdAsync(proteinFood.FoodId);
                // if (foodPortion == null || foodPortion.Portion == null)
                // {
                //     _logger.LogInformation("Portion not found for this food.");
                //     throw new Exception();
                // }
                // var portion = foodPortion.Portion.PortionId ;
                var portion = new Portion();

                portion = new Portion
                {
                    MeasurementUnit = "gram", // Đây là ví dụ, bạn có thể thay đổi tùy vào dữ liệu của mình
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



            // Kiểm tra và thêm Main Dish vào bữa ăn
            // if (mainDishFoods.Any())
            // {
            //     foreach (var food in selectedFoods)
            //     {
            //         var existingMealFood = meal.MealFoods.FirstOrDefault(mf => mf.FoodId == food.FoodId);
            //         if (existingMealFood == null)
            //         {
            //             // Tính toán portionWeight và kiểm tra tính hợp lý
            //             var totalFoodCalories = (food.Nutrition.Carbs * 4) + (food.Nutrition.Protein * 4) + (food.Nutrition.Fat * 9);
            //             var portionWeight = (mealCalories / totalFoodCalories); // Đảm bảo rằng portionWeight tính toán đúng

            //             // Kiểm tra xem portion có tồn tại không
            //             var foodPortion = await _foodPortionRepository.GetByFoodIdAsync(food.FoodId);
            //             if (foodPortion == null || foodPortion.Portion == null)
            //             {
            //                 throw new Exception("Portion not found for this food.");
            //             }

            //             var portion = foodPortion.Portion;

            //             var mealFood = new Domain.MealFood
            //             {
            //                 FoodId = food.FoodId,
            //                 Quantity = 1,  // Có thể tính toán lại số lượng nếu cần
            //                 CreatedAt = DateTime.Now,
            //                 UpdatedAt = DateTime.Now,
            //                 IsCompleted = false,
            //                 IsRecommended = true,
            //                 PortionId = portion.PortionId
            //             };

            //             meal.MealFoods.Add(mealFood);
            //             _logger.LogInformation($"Added MealFood: FoodId = {food.FoodId}, PortionWeight = {portionWeight}, MealType = {mealType}");
            //         }
            //         else
            //         {
            //             existingMealFood.Quantity += 1; // Cập nhật số lượng nếu món ăn đã tồn tại
            //             existingMealFood.UpdatedAt = DateTime.Now;
            //             _logger.LogInformation($"MealFood Count after adding: {meal.MealFoods.Count()}");

            //         }
            //     }

            // }

            // Kiểm tra và thêm Side Dish vào bữa ăn

            // if (sideDishFoods.Any())
            // {
            //     foreach (var food in sideDishFoods)
            //     {
            //         var existingMealFood = meal.MealFoods.FirstOrDefault(mf => mf.FoodId == food.FoodId);
            //         if (existingMealFood == null)
            //         {
            //             // Tính toán PortionWeight cho Side Dish
            //             var totalFoodCalories = (food.Nutrition.Carbs * 4) + (food.Nutrition.Protein * 4) + (food.Nutrition.Fat * 9);
            //             var portionWeight = (mealCalories / totalFoodCalories); // Tính toán PortionWeight tương ứng

            //             // Kiểm tra nếu không có Portion thì tạo mới
            //             var portion = new Portion
            //             {
            //                 MeasurementUnit = "gram", // Đây là ví dụ, bạn có thể thay đổi tùy vào dữ liệu của mình
            //                 PortionSize = "unit",
            //                 PortionWeight = portionWeight,
            //                 CreatedAt = DateTime.Now,
            //                 UpdatedAt = DateTime.Now
            //             };

            //             _portionRepository.Add(portion);
            //             await _portionRepository.SaveChangesAsync();

            //             var foodPortion = new FoodPortion
            //             {
            //                 FoodId = food.FoodId,
            //                 PortionId = portion.PortionId
            //             };
            //             _foodPortionRepository.Add(foodPortion);
            //             await _portionRepository.SaveChangesAsync();

            //             var check = meal.MealFoods.FirstOrDefault(mf => mf.FoodId == food.FoodId && mf.PortionId == portion.PortionId);
            //             if (check == null)
            //             {
            //                 var mealFood = new Domain.MealFood
            //                 {
            //                     FoodId = food.FoodId,
            //                     Quantity = 1,  // Tính lại nếu cần
            //                     CreatedAt = DateTime.Now,
            //                     UpdatedAt = DateTime.Now,
            //                     IsCompleted = false,
            //                     IsRecommended = true,
            //                     PortionId = portion.PortionId
            //                 };
            //                 meal.MealFoods.Add(mealFood);
            //                 _logger.LogInformation($"Added {mealFood.MealFoodId} MealFood: FoodId = {food.FoodId}, PortionId = {portion.PortionId}");
            //             }
            //             else
            //             {
            //                 check.Quantity += 1; // Cập nhật số lượng
            //                 check.UpdatedAt = DateTime.Now;
            //                 _logger.LogInformation($"MealFood Count after adding: {meal.MealFoods.Count()}");
            //             }

            //         }
            //     }

            // }
            return meal;
        }
    }
}