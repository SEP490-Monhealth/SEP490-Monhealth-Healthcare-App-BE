using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class CheckGoalTypeQueryHandler : IRequestHandler<CheckGoalTypeQuery, Unit>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly IMealRepository _mealRepository;
        public ILogger<CheckGoalTypeQuery> _logger { get; set; }
        public CheckGoalTypeQueryHandler(IGoalRepository goalRepository,
        IMealRepository mealRepository,
        ILogger<CheckGoalTypeQuery> logger)
        {
            _goalRepository = goalRepository;
            _mealRepository = mealRepository;
            _logger = logger;
        }

        public async Task<Unit> Handle(CheckGoalTypeQuery request, CancellationToken cancellationToken)
        {
            var userGoal = await _goalRepository.GetGoalsByUserIdAsync(request.UserId);
            var meal = await _mealRepository.GetMealByUser(request.UserId);

            if (userGoal == null || !userGoal.Any() || meal == null)
            {
                return Unit.Value;
            }

            var userGoalType = userGoal.Select(ug => ug.GoalType).Distinct();
            var goalTypeStrings = string.Join(", ", userGoalType.Select(gt => gt.ToString()));
            _logger.LogInformation($"Mục tiêu của người dùng là:{goalTypeStrings}");
            var totalCalories = userGoal.FirstOrDefault()?.CaloriesGoal ?? 0;
            _logger.LogInformation($"Tổng Calories người dùng cần nạp là: {totalCalories}");
            if (totalCalories <= 0 || !userGoalType.Any()) return Unit.Value;

            List<MealCaloriesDTO> mealCalories = new List<MealCaloriesDTO>();

            foreach (var goalType in userGoalType)
            {
                float breakfastCalories = 0f, lunchCalories = 0f, dinnerCalories = 0f;
                switch (goalType)
                {
                    case GoalType.WeightLoss:
                        breakfastCalories = totalCalories * 0.20f;  // 20% cho bữa sáng
                        lunchCalories = totalCalories * 0.40f;     // 40% cho bữa trưa
                        dinnerCalories = totalCalories * 0.30f;    // 30% cho bữa tối
                        break;

                    case GoalType.WeightGain:
                        breakfastCalories = totalCalories * 0.25f;  // 25% cho bữa sáng
                        lunchCalories = totalCalories * 0.35f;     // 35% cho bữa trưa
                        dinnerCalories = totalCalories * 0.30f;    // 30% cho bữa tối
                        break;

                    case GoalType.Maintenance:
                        breakfastCalories = totalCalories * 0.30f;  // 30% cho bữa sáng
                        lunchCalories = totalCalories * 0.35f;     // 35% cho bữa trưa
                        dinnerCalories = totalCalories * 0.25f;    // 25% cho bữa tối
                        break;
                }
                mealCalories.Add(new MealCaloriesDTO { MealType = MealType.Breakfast, Calories = breakfastCalories });
                mealCalories.Add(new MealCaloriesDTO { MealType = MealType.Lunch, Calories = lunchCalories });
                mealCalories.Add(new MealCaloriesDTO { MealType = MealType.Dinner, Calories = dinnerCalories });
            }
            foreach (var mealItem in mealCalories)
            {
                _logger.LogInformation($"{mealItem.MealType}: {mealItem.Calories} calories");
            }
            return Unit.Value;
        }
    }

}