using MediatR;
using Monhealth.Application.Contracts.Persistence;
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

        public async Task<Unit> Handle(CreateMealCommand request, CancellationToken cancellationToken)
        {
            var userId = request.CreateMeal.UserId;
            var validMealTypes = new HashSet<string> { "Breakfast", "Lunch", "Dinner", "Snack" };
            if (!validMealTypes.Contains(request.CreateMeal.MealType))
                throw new ArgumentException("MealType phải là một trong các giá trị: Breakfast, Lunch, Dinner, Snack.");

            var existingMeal = await _mealRepository.GetByUserIdAndMealType(userId, request.CreateMeal.MealType);
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
                if (item.Quantity <= 0) throw new Exception("Quantity phải lớn hơn hoặc bằng 0.");

                var existingPortion = await _portionRepository.GetPortionAsync(item.MeasurementUnit, item.PortionSize, item.PortionWeight);
                Portion portion = existingPortion ?? new Portion
                {
                    MeasurementUnit = item.MeasurementUnit,
                    PortionSize = item.PortionSize,
                    PortionWeight = item.PortionWeight,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                if (existingPortion == null)
                {
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
                    var mealFood = new Monhealth.Domain.MealFood
                    {
                        MealId = model.MealId,
                        FoodId = item.FoodId,
                        Quantity = item.Quantity,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };
                    _mealFoodRepository.Add(mealFood);
                }

                await _mealRepository.SaveChangeAsync();
            }

            var currentDate = DateTime.Now.Date;
            var mealsForDay = await _mealRepository.GetMealByUserAndDate(currentDate, userId);

            if (mealsForDay == null || !mealsForDay.Any())
            {
                throw new Exception("Không có Meal nào trong ngày hiện tại để tạo DailyMeal.");
            }

            var dailyMeal = await _dailyMealRepository.GetDailyMealByUserAndDate(currentDate, userId);
            if (dailyMeal == null)
            {
                dailyMeal = new DailyMeal
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

            foreach (var meal in mealsForDay)
            {
                var mealFoods = await _mealFoodRepository.GetMealFoodByMealId(meal.MealId);
                foreach (var mealFood in mealFoods)
                {
                    var food = mealFood.Food;
                    var portionWeight = food.FoodPortions.FirstOrDefault()?.Portion.PortionWeight ?? 1;

                    dailyMeal.TotalCalories += (food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalProteins += (food.Nutrition.Protein / 100) * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalCarbs += (food.Nutrition.Carbs / 100) * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalFats += (food.Nutrition.Fat / 100) * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalFibers += (food.Nutrition.Fiber / 100) * (mealFood.Quantity * portionWeight);
                    dailyMeal.TotalSugars += (food.Nutrition.Sugar / 100) * (mealFood.Quantity * portionWeight);
                }
            }

            dailyMeal.UpdatedAt = DateTime.Now;
            await _dailyMealRepository.SaveChangeAsync();

            return Unit.Value;
        }
    }
}
