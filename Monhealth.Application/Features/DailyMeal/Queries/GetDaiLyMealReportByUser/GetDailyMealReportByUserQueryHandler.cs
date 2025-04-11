using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealReportByUser
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
                    if (mealFood.Food?.Nutrition == null || mealFood.PortionId == Guid.Empty || !mealFood.IsCompleted)
                        continue;

                    var portion = await _portionRepository.GetByIdAsync(mealFood.PortionId);
                    if (portion == null)
                        continue;

                    float portionWeight = portion.PortionWeight;
                    totalCaloriesForMeal += (mealFood.Food.Nutrition.Calories / 100) * (mealFood.Quantity * portionWeight);
                }
                mealCalories[meal.MealId] = totalCaloriesForMeal;
            }

            var requestDate = request.date.Date;
            var startOfWeek = requestDate.AddDays(-(int)requestDate.DayOfWeek + (requestDate.DayOfWeek == DayOfWeek.Sunday ? -6 : 1)); // Thứ 2

            var reportDict = new Dictionary<DateOnly, float>();

            foreach (var dm in dailyMeals)
            {
                var date = DateOnly.FromDateTime(dm.CreatedAt!.Value.Date);
                float calories = 0;
                foreach (var meal in dm.Meals)
                {
                    if (mealCalories.TryGetValue(meal.MealId, out float cal))
                    {
                        calories += cal;
                    }
                }

                if (reportDict.ContainsKey(date))
                    reportDict[date] += calories;
                else
                    reportDict[date] = calories;
            }

            var reportData = Enumerable.Range(0, 7)
                .Select(offset =>
                {
                    var date = DateOnly.FromDateTime(startOfWeek.AddDays(offset));
                    reportDict.TryGetValue(date, out float calories);
                    return new GetDailyMealDataDTO
                    {
                        date = date.ToDateTime(TimeOnly.MinValue),
                        Calories = calories
                    };
                })
                .OrderBy(x => x.date)
                .ToList();

            return reportData;
        }
    }
}
