
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Meal.Commands.CreateMeal
{
    public class CreateMealCommandHandler : IRequestHandler<CreateMealCommand, Guid>
    {
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodPortionRepository _foodPortionRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IFoodRepository _foodRepository;

        public CreateMealCommandHandler(
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IPortionRepository portionRepository,
            IFoodPortionRepository foodPortionRepository,
            IDailyMealRepository dailyMealRepository,
            IFoodRepository foodRepository)
        {
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _foodPortionRepository = foodPortionRepository;
            _dailyMealRepository = dailyMealRepository;
            _foodRepository = foodRepository;
        }

        public async Task<Guid> Handle(CreateMealCommand request, CancellationToken cancellationToken)
        {
            var userId = request.CreateMeal.UserId;
            var mealType = request.CreateMeal.MealType;
            var currentDate1 = DateTime.Now.Date;
            var validMealTypes = new HashSet<string> { "Breakfast", "Lunch", "Dinner", "Snack" };
            if (!validMealTypes.Contains(request.CreateMeal.MealType))
                throw new ArgumentException("MealType phải là một trong các giá trị: Breakfast, Lunch, Dinner, Snack");

            var existingMeal = await _mealRepository.GetByUserIdAndMealType(userId,mealType,currentDate1);
            Monhealth.Domain.Meal model;

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

            foreach (var item in request.CreateMeal.Items)
            {
                if (item.Quantity <= 0) throw new Exception("Quantity phải lớn hơn hoặc bằng 0");

                var existingPortion = await _portionRepository.GetPortionAsync(item.MeasurementUnit, item.PortionSize, item.PortionWeight);
                Portion portion = existingPortion ?? new Portion
                {
                    MeasurementUnit = item.MeasurementUnit,
                    PortionSize = item.PortionSize,
                    PortionWeight = item.PortionWeight,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                Guid portionId;
                if (existingPortion == null)
                {
                    _portionRepository.Add(portion);
                    await _portionRepository.SaveChangesAsync();
                    _foodPortionRepository.Add(new FoodPortion
                    {
                        FoodId = item.FoodId,
                        PortionId = portion.PortionId
                    });
                    portionId = portion.PortionId;
                }
                else
                {
                    portionId = existingPortion.PortionId;
                }

                var existingMealItem = await _mealFoodRepository.GetByMealIdAndFoodId(model.MealId, item.FoodId);
                if (existingMealItem != null && existingMealItem.PortionId == portionId)
                {
                    existingMealItem.Quantity += item.Quantity;
                    existingMealItem.UpdatedAt = DateTime.Now;
                }
                else
                {
                    var mealFood = new Monhealth.Domain.MealFood
                    {
                        MealId = model.MealId,
                        FoodId = item.FoodId,
                        Quantity = item.Quantity,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        PortionId = portionId,
                        Status = false
                    };
                    _mealFoodRepository.Add(mealFood);
                }

                await _mealRepository.SaveChangeAsync();
            }

            var currentDate = DateTime.Now.Date;
            var mealsForDay = await _mealRepository.GetMealByUserAndDate(currentDate, userId);

            var dailyMeal = await _dailyMealRepository.GetDailyMealByUserAndDate(currentDate, userId);
            if (dailyMeal == null)
            {
                dailyMeal = new Monhealth.Domain.DailyMeal
                {
                    UserId = userId,
                    CreatedAt = currentDate,
                    UpdatedAt = DateTime.Now,
                    TotalCalories = 0,
                    TotalProteins = 0,
                    TotalCarbs = 0,
                    TotalFats = 0,
                    TotalFibers = 0,
                    TotalSugars = 0
                };
                _dailyMealRepository.Add(dailyMeal);

                // Lưu DailyMeal để lấy DailyMealID
                await _dailyMealRepository.SaveChangeAsync();
            }
            else
            {
                dailyMeal.TotalCalories = 0;
                dailyMeal.TotalProteins = 0;
                dailyMeal.TotalCarbs = 0;
                dailyMeal.TotalFats = 0;
                dailyMeal.TotalFibers = 0;
                dailyMeal.TotalSugars = 0;
            }

            // Gán DailyMealID cho từng Meal
            foreach (var meal in mealsForDay)
            {
                meal.DailyMealId = dailyMeal.DailyMealId; // Gán DailyMealID cho Meal
                _mealRepository.Update(meal);

                var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);

                foreach (var mealFood in mealFoods)

                {
                    var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                    if (portion == null)
                    {
                        throw new Exception($"Không tìm thấy Portion với PortionId: {mealFood.PortionId}");
                    }
                    if (mealFood.Status == true)
                    {
                        var food = mealFood.Food;
                        var portionWeight = portion.PortionWeight;

                        dailyMeal.TotalCalories += (food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalProteins += (food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalCarbs += (food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalFats += (food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalFibers += (food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                        dailyMeal.TotalSugars += (food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);

                    }
                }
            }

            dailyMeal.UpdatedAt = DateTime.Now;
            await _dailyMealRepository.SaveChangeAsync();

            return model.MealId;
        }

    }
}
