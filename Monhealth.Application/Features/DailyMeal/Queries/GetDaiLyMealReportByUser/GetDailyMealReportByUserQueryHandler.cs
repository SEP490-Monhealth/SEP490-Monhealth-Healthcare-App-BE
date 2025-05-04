using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealReportByUser
{
    public class GetDailyMealReportByUserQueryHandler
      : IRequestHandler<GetDailyMealReportByUserQuery, List<GetDailyMealDataDTO>>
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

        public async Task<List<GetDailyMealDataDTO>> Handle(
             GetDailyMealReportByUserQuery request,
             CancellationToken cancellationToken)
        {
            // 1) Tính Thứ Hai tuần chứa request.Date
            DateTime startOfWeek = GetStartOfWeek(request.date.Date);
            DateTime endOfWeek = startOfWeek.AddDays(6).Date; // Chủ Nhật

            // 2) Lấy DailyMeal trong tuần đó
            var dailyMeals = await _dailyMealRepository
                .GetDailyMealsByUserAndDateRangeAsync(
                    request.UserId,
                    startOfWeek,
                    endOfWeek);

            // 3) Tập all MealId để load calories
            var mealIds = dailyMeals
                .SelectMany(dm => dm.Meals)
                .Select(m => m.MealId)
                .Distinct()
                .ToList();

            var allMeals = await _mealRepository.GetAllMeals();
            var mealsForReport = allMeals
                .Where(m => mealIds.Contains(m.MealId))
                .ToList();

            // 4) Tính calories cho từng meal
            var mealCalories = new Dictionary<Guid, float>();
            foreach (var meal in mealsForReport)
            {
                float cSum = 0;
                foreach (var mf in meal.MealFoods)
                {
                    if (mf.Food?.Nutrition == null ||
                        mf.PortionId == Guid.Empty ||
                        !mf.IsCompleted)
                        continue;

                    var portion = await _portionRepository
                        .GetByIdAsync(mf.PortionId);
                    if (portion == null) continue;

                    cSum += (mf.Food.Nutrition.Calories / 100f)
                          * (mf.Quantity * portion.PortionWeight);
                }
                mealCalories[meal.MealId] = cSum;
            }

            // 5) Sinh 7 ngày Thứ Hai→Chủ Nhật, map calories từng ngày
            var report = Enumerable.Range(0, 7)
                .Select(i =>
                {
                    var day = startOfWeek.AddDays(i);
                    float dayCals = dailyMeals
                        .Where(dm => dm.DailyMealDate.Date == day)
                        .SelectMany(dm => dm.Meals)
                        .Where(m => mealCalories.ContainsKey(m.MealId))
                        .Sum(m => mealCalories[m.MealId]);

                    return new GetDailyMealDataDTO
                    {
                        date = day,
                        Calories = dayCals
                    };
                })
                .ToList();

            return report;
        }

        /// <summary>
        /// Trả về Thứ Hai của tuần chứa date (tuần chạy Mon→Sun).
        /// </summary>
        private DateTime GetStartOfWeek(DateTime date)
        {
            // (date.DayOfWeek - Monday + 7) % 7 = số ngày cần lùi để về Monday
            int diff = ((int)date.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;
            return date.AddDays(-diff).Date;
        }

    }
}
