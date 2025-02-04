using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.ServiceForRecommend.DTO;
using Monhealth.Domain;

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
        /// Tính toán phân bổ bữa ăn (calories, protein, carbs, fat).
        /// </summary>
        /// <param name="goal">Goal của người dùng</param>
        /// <returns>Phân bổ bữa ăn</returns>
        public Dictionary<string, MealAllocationDTO> CalculateMealAllocation(Goal goal)
        {
            if (goal == null || goal.CaloriesGoal <= 0)
            {
                _logger.LogWarning("Goal không hợp lệ hoặc CaloriesGoal không được thiết lập.");
                return new Dictionary<string, MealAllocationDTO>
                {
                    { "breakfast", new MealAllocationDTO() },
                    { "lunch", new MealAllocationDTO() },
                    { "dinner", new MealAllocationDTO() }
                };
            }

            // Tỷ lệ phân bổ bữa ăn
            var breakfastRatio = 0.3f;
            var lunchRatio = 0.35f;
            var dinnerRatio = 0.25f;

            var mealAllocations = new Dictionary<string, MealAllocationDTO>
            {
                {
                    "breakfast",
                    new MealAllocationDTO
                    {
                        Calories = breakfastRatio * goal.CaloriesGoal,
                        Protein = breakfastRatio * goal.ProteinGoal,
                        Carbs = breakfastRatio * goal.CarbsGoal,
                        Fat = breakfastRatio * goal.FatGoal ,
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
                        Carbs = lunchRatio * goal.CarbsGoal ,
                        Fat = lunchRatio * goal.FatGoal ,
                        Fiber = lunchRatio* goal.FiberGoal,
                        Sugar = lunchRatio * goal.SugarGoal,
                    }
                },
                {
                    "dinner",
                    new MealAllocationDTO
                    {
                        Calories = dinnerRatio * goal.CaloriesGoal,
                        Protein = dinnerRatio * goal.ProteinGoal ,
                        Carbs = dinnerRatio * goal.CarbsGoal,
                        Fat = dinnerRatio * goal.FatGoal ,
                        Fiber = dinnerRatio * goal.FiberGoal,
                        Sugar = dinnerRatio * goal.SugarGoal,
                    }
                }
            };

            _logger.LogInformation("Phân bổ bữa ăn: {0}",
                string.Join(", ", mealAllocations.Select(m => $"{m.Key}: {m.Value.Calories} cal")));

            return mealAllocations;
        }

        /// <summary>
        /// Lấy và tính toán phân bổ bữa ăn cho người dùng.
        /// </summary>
        /// <param name="userId">Id của người dùng</param>
        /// <returns>Phân bổ bữa ăn</returns>
        public async Task<Dictionary<string, MealAllocationDTO>> GetMealAllocationByUserIdAsync(Guid userId)
        {
            var goal = await _goalRepository.GetByUserIdAsync(userId);

            if (goal == null)
            {
                return new Dictionary<string, MealAllocationDTO>
                {
                    { "breakfast", new MealAllocationDTO() },
                    { "lunch", new MealAllocationDTO() },
                    { "dinner", new MealAllocationDTO() }
                };
            }

            return CalculateMealAllocation(goal);
        }
    }
}
