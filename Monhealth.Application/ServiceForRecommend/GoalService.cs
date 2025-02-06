using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.ServiceForRecommend.DTO;
using Monhealth.Domain;
using Monhealth.Domain.Enum;


namespace Monhealth.Application.Services
{
    public class GoalService
    {
        private readonly IGoalRepository _goalRepository;
        private readonly ILogger<GoalService> _logger;

        public GoalService(IGoalRepository goalRepository, ILogger<GoalService> logger)
        {
            _goalRepository = goalRepository;
            _logger = logger;
        }

        /// <summary>
        /// Lấy GoalType của người dùng
        /// </summary>
        public async Task<GoalType?> GetGoalTypeByUserIdAsync(Guid userId)
        {
            var goal = await _goalRepository.GetByUserIdAsync(userId);
            if (goal == null)
            {
                _logger.LogWarning($"Không tìm thấy Goal cho user {userId}.");
                return null;
            }

            return goal.GoalType;
        }

        /// <summary>
        /// Lấy Activity Level của người dùng
        /// </summary>
        public async Task<float> GetActivityLevelByUserIdAsync(Guid userId)
        {
            var metric = await _goalRepository.GetUserMetricByUserIdAsync(userId); // 🛠 Lấy dữ liệu từ Metric
            if (metric == null)
            {
                _logger.LogWarning($"Không tìm thấy Metric cho user {userId}. Mặc định dùng ActivityLevel = 1.2");
                return 1.2f; // 🛠 Mặc định là "sedentary"
            }

            return metric.ActivityLevel;
        }

        /// <summary>
        /// Tính toán phân bổ bữa ăn (calories, protein, carbs, fat).
        /// </summary>
        public Dictionary<string, MealAllocationDTO> CalculateMealAllocation(Goal goal)
        {
            if (goal == null || goal.CaloriesGoal <= 0)
            {
                _logger.LogWarning("Goal không hợp lệ hoặc CaloriesGoal không được thiết lập.");
                return new Dictionary<string, MealAllocationDTO>
                {
                    { "breakfast", new MealAllocationDTO() },
                    { "lunch", new MealAllocationDTO() },
                    { "dinner", new MealAllocationDTO() },
                    { "snack", new MealAllocationDTO() }
                };
            }

            // Tỷ lệ phân bổ bữa ăn
            var breakfastRatio = 0.3f;
            var lunchRatio = 0.35f;
            var dinnerRatio = 0.25f;
            var snackRatio = 0.1f;

            var mealAllocations = new Dictionary<string, MealAllocationDTO>
            {
                {
                    "breakfast",
                    new MealAllocationDTO
                    {
                        Calories = breakfastRatio * goal.CaloriesGoal,
                        Protein = breakfastRatio * goal.ProteinGoal,
                        Carbs = breakfastRatio * goal.CarbsGoal,
                        Fat = breakfastRatio * goal.FatGoal,
                        Fiber = breakfastRatio * goal.FiberGoal,
                        Sugar = breakfastRatio * goal.SugarGoal,
                    }
                },
                {
                    "lunch",
                    new MealAllocationDTO
                    {
                        Calories = lunchRatio * goal.CaloriesGoal,
                        Protein = lunchRatio * goal.ProteinGoal,
                        Carbs = lunchRatio * goal.CarbsGoal,
                        Fat = lunchRatio * goal.FatGoal,
                        Fiber = lunchRatio * goal.FiberGoal,
                        Sugar = lunchRatio * goal.SugarGoal,
                    }
                },
                {
                    "dinner",
                    new MealAllocationDTO
                    {
                        Calories = dinnerRatio * goal.CaloriesGoal,
                        Protein = dinnerRatio * goal.ProteinGoal,
                        Carbs = dinnerRatio * goal.CarbsGoal,
                        Fat = dinnerRatio * goal.FatGoal,
                        Fiber = dinnerRatio * goal.FiberGoal,
                        Sugar = dinnerRatio * goal.SugarGoal,
                    }
                },
                {
                    "snack",
                    new MealAllocationDTO
                    {
                        Calories = snackRatio * goal.CaloriesGoal,
                        Protein = snackRatio * goal.ProteinGoal,
                        Carbs = snackRatio * goal.CarbsGoal,
                        Fat = snackRatio * goal.FatGoal,
                        Fiber = snackRatio * goal.FiberGoal,
                        Sugar = snackRatio * goal.SugarGoal,
                    }
                }
            };

            _logger.LogInformation("Phân bổ bữa ăn: {0}",
                string.Join(", ", mealAllocations.Select(m => $"{m.Key}: {m.Value.Calories} cal")));

            return mealAllocations;
        }

        /// <summary>
        /// Lấy phân bổ bữa ăn dựa trên userId
        /// </summary>
        public async Task<Dictionary<string, MealAllocationDTO>> GetMealAllocationByUserIdAsync(Guid userId)
        {
            var goal = await _goalRepository.GetByUserIdAsync(userId);

            if (goal == null)
            {
                return new Dictionary<string, MealAllocationDTO>
                {
                    { "breakfast", new MealAllocationDTO() },
                    { "lunch", new MealAllocationDTO() },
                    { "dinner", new MealAllocationDTO() },
                    { "snack", new MealAllocationDTO() }
                };
            }

            return CalculateMealAllocation(goal);
        }
    }
}
