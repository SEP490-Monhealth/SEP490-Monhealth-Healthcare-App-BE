using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetDailyMealReportByUserQueryHandler : IRequestHandler<GetDailyMealReportByUserQuery, List<GetDailyMealDataDTO>>
    {
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IPortionRepository _portionRepository;

        public GetDailyMealReportByUserQueryHandler(
            IDailyMealRepository dailyMealRepository, 
            IMealRepository mealRepository, 
            IPortionRepository portionRepository)
        {
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
            _portionRepository = portionRepository;
        }

        public async Task<List<GetDailyMealDataDTO>> Handle(GetDailyMealReportByUserQuery request, CancellationToken cancellationToken)
        {
            var dailyMeals = await _dailyMealRepository.GetDailyMealsReportByUserAndDate(request.UserId, request.date);
            if (dailyMeals == null || !dailyMeals.Any())
            {
                return new List<GetDailyMealDataDTO>();
            }

            var mealIds = dailyMeals
                .SelectMany(dm => dm.Meals.Select(m => m.MealId))
                .Distinct()
                .ToList();

            var allMeals = await _mealRepository.GetAllMeals();
            var mealsForReport = allMeals.Where(m => mealIds.Contains(m.MealId)).ToList();

            var mealCalories = new Dictionary<Guid, float>();
            foreach (var meal in mealsForReport)
            {
                float totalCaloriesForMeal = 0;
                foreach (var mealFood in meal.MealFoods)
                {
                    if (mealFood.Food?.Nutrition == null || mealFood.PortionId == Guid.Empty )
                        continue;

                    var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                    if (portion == null)
                        continue;

                    float portionWeight = portion.PortionWeight;
                    totalCaloriesForMeal += (mealFood.Food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                }
                mealCalories[meal.MealId] = totalCaloriesForMeal;
            }

            var reportData = dailyMeals
                .GroupBy(dm => dm.CreatedAt.Value.Date)
                .Select(g =>
                {
                    float dayCalories = 0;
                    foreach (var dm in g)
                    {
                        foreach (var mealItem in dm.Meals)
                        {
                            if (mealCalories.TryGetValue(mealItem.MealId, out float cal))
                            {
                                dayCalories += cal;
                            }
                        }
                    }
                    return new GetDailyMealDataDTO
                    {
                        date = g.Key,
                        Calories = dayCalories
                    };
                })
                .OrderBy(dto => dto.date)
                .ToList();

            return reportData;
        }
    }
}
