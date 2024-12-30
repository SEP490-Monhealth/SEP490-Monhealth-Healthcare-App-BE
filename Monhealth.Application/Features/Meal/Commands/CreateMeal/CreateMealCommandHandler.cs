using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Meal.NewClassForMeal;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealCommandHandler : IRequestHandler<CreateMealCommand, Unit>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodPortionRepository _foodPortionRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IFoodRepository _foodRepository;
        public CreateMealCommandHandler(IMealRepository mealRepository
        , IMealFoodRepository mealFoodRepository,
        IPortionRepository portionRepository,
        IFoodPortionRepository foodPortionRepository,
        IDailyMealRepository dailyMealRepository,
        IFoodRepository foodRepository
      )
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _foodPortionRepository = foodPortionRepository;
            _dailyMealRepository = dailyMealRepository;
            _foodRepository = foodRepository;

        }

        public async Task<Unit> Handle(CreateMealCommand request, CancellationToken cancellationToken)
        {
            var existingMeal = await _mealRepository.GetByUserIdAndMealType(request.CreateMeal.UserId, request.CreateMeal.MealType);
            Monhealth.Domain.Meal model;
            var userId = request.CreateMeal.UserId;
            var validMealTypes = new HashSet<string>
             { "Breakfast", "Lunch", "Dinner", "Snack" };
            if (!validMealTypes.Contains(request.CreateMeal.MealType))
                throw new ArgumentException("MealType phải là một trong các giá trị: Breakfast, Lunch, Dinner, Snack.");
            if (existingMeal != null)
            {
                model = existingMeal;
            }
            else
            {

                model = new Monhealth.Domain.Meal
                {
                    UserId = userId,
                    MealType = request.CreateMeal.MealType,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _mealRepository.Add(model);
            }

            foreach (var item in request.CreateMeal.MealItems)
            {
                if (item.Quantity <= 0) throw new Exception("Quantity phải lớn hơn hoặc bằng 0.");
                var existingPortion = await _portionRepository.GetPortionAsync(item.MeasurementUnit,
                item.PortionSize, item.PortionWeight);
                Portion portion;
                if (existingPortion != null)
                {
                    portion = existingPortion;
                }
                else
                {
                    portion = new Portion
                    {

                        MeasurementUnit = item.MeasurementUnit,
                        PortionSize = item.PortionSize,
                        PortionWeight = item.PortionWeight,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };
                    _portionRepository.Add(portion);
                    _foodPortionRepository.Add(new FoodPortion
                    {
                        FoodId = item.FoodId,
                        PortionId = portion.PortionId
                    });
                }


                var existingMealItem = await _mealFoodRepository.GetByMealIdAndFoodId(model.MealId, item.FoodId);
                if (existingMealItem != null)
                {
                    existingMealItem.Quantity += item.Quantity;
                    existingMealItem.UpdatedAt = DateTime.Now;
                }
                else
                {

                    var MealFood = new Monhealth.Domain.MealFood
                    {
                        MealId = model.MealId,
                        FoodId = item.FoodId,
                        Quantity = item.Quantity,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };
                    _mealFoodRepository.Add(MealFood);
                    await _mealRepository.SaveChangeAsync();
                }
            }
            //kiem tra va cap nhat DailyMeal
            var currentDate = DateTime.Now.Date;

            //Lay tat ca cac meal trong ngay hien tai
            var mealsForDay = await _mealRepository.GetMealByUserAndDate(currentDate, userId);

            Console.WriteLine($"currentDate: {currentDate}");
            Console.WriteLine($"Số lượng Meal được tìm thấy: {mealsForDay?.Count() ?? 0}");

            if (mealsForDay == null || !mealsForDay.Any())
            {
                throw new Exception("Không có Meal nào trong ngày hiện tại để tạo DailyMeal.");
            }


            //lay hoac tao moi Daily Meal
            var dailyMeal = await _dailyMealRepository.GetDailyMealByUserAndDate(currentDate, userId);
            if (dailyMeal == null)
            {
                // Tính tổng giá trị dinh dưỡng từ tất cả các Meal trong ngày
                var totalNutrition = new NutritionTotals();


                foreach (var meal in mealsForDay)
                {
                    // Lấy danh sách MealFood của Meal hiện tại
                    var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);

                    foreach (var mealFood in mealFoods)
                    {
                        // // Lấy thông tin dinh dưỡng từ Food
                        // var food = await _foodRepository.GetFoodByIdAsync(mealFood.FoodId);

                        // // Cộng dồn giá trị dinh dưỡng từ Food (dựa trên số lượng)
                        // totalNutrition.Calories += food.Nutrition.Calories * mealFood.Quantity;
                        // totalNutrition.Proteins += food.Nutrition.Protein * mealFood.Quantity;
                        // totalNutrition.Carbs += food.Nutrition.Carbs * mealFood.Quantity;
                        // totalNutrition.Fats += food.Nutrition.Fat * mealFood.Quantity;
                        // totalNutrition.Fibers += food.Nutrition.Fiber * mealFood.Quantity;
                        // totalNutrition.Sugars += food.Nutrition.Sugar * mealFood.Quantity;
                        var food = await _foodRepository.GetFoodByIdAsync(mealFood.FoodId);
                        var portion = food.FoodPortions.FirstOrDefault()?.Portion;

                        if (food.Nutrition == null || portion == null)
                        {
                            Console.WriteLine($"Dữ liệu thiếu Nutrition hoặc Portion cho FoodId: {food.FoodId}");
                            continue; // Bỏ qua nếu dữ liệu không đủ
                        }

                        var portionWeight = portion.PortionWeight > 0 ? portion.PortionWeight : 1; // Tránh chia cho 0

                        // Tính toán giá trị dinh dưỡng dựa trên khẩu phần và số lượng
                        totalNutrition.Calories += (food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                        totalNutrition.Proteins += (food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                        totalNutrition.Carbs += (food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                        totalNutrition.Fats += (food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
                        totalNutrition.Fibers += (food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                        totalNutrition.Sugars += (food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);
                    }
                }
                dailyMeal = new DailyMeal
                {
                    UserId = userId,
                    CreatedAt = currentDate,
                    UpdatedAt = DateTime.Now,
                    TotalCalories = totalNutrition.Calories,
                    TotalProteins = totalNutrition.Proteins,
                    TotalCarbs = totalNutrition.Carbs,
                    TotalFats = totalNutrition.Fats,
                    TotalFibers = totalNutrition.Fibers,
                    TotalSugars = totalNutrition.Sugars
                };

                _dailyMealRepository.Add(dailyMeal);

            }
            else
            {
                // Nếu DailyMeal đã tồn tại, cập nhật giá trị dinh dưỡng
                foreach (var meal in mealsForDay)
                {
                    var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);

                    foreach (var mealFood in mealFoods)
                    {
                        // var food = await _foodRepository.GetFoodByIdAsync(mealFood.FoodId);

                        // Cộng dồn giá trị dinh dưỡng vào DailyMeal
                        // dailyMeal.TotalCalories += food.Nutrition.Calories * mealFood.Quantity;
                        // dailyMeal.TotalProteins += food.Nutrition.Protein * mealFood.Quantity;
                        // dailyMeal.TotalCarbs += food.Nutrition.Carbs * mealFood.Quantity;
                        // dailyMeal.TotalFats += food.Nutrition.Fat * mealFood.Quantity;
                        // dailyMeal.TotalFibers += food.Nutrition.Fiber * mealFood.Quantity;
                        // dailyMeal.TotalSugars += food.Nutrition.Sugar * mealFood.Quantity;
                        var food = mealFood.Food;
                        var portionWeight = food.FoodPortions.FirstOrDefault()?.Portion.PortionWeight ?? 1;

                        // Cập nhật giá trị dinh dưỡng DailyMeal bằng công thức cộng dồn
                        dailyMeal.TotalCalories += (food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalProteins += (food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalCarbs += (food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalFats += (food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalFibers += (food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalSugars += (food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);
                    }
                }

                // Cập nhật thời gian
                dailyMeal.UpdatedAt = DateTime.Now;

            }
            await _dailyMealRepository.SaveChangeAsync();


            return Unit.Value;
        }
    }
}