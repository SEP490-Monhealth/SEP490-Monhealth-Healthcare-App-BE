using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Services
{
    public class GoalsCalculator : IGoalsCalculator
    {
        private readonly IMetricRepository _metricRepository;
        public GoalsCalculator(IMetricRepository metricRepository)
        {
            _metricRepository = metricRepository;
        }
        public void CreateCalculateGoal(Goal goal, CreateMetricDto createMetricDto, float tdee)
        {
            if (!Enum.TryParse<GoalType>(createMetricDto.GoalType, true, out var goalType))
            {
                throw new Exception("Loại mục tiêu không hợp lệ.");
            }
            
            goal.GoalType = goalType;
            // tinh toan cac chi so Macros
            var (calories, protein, carbs, fats) = CreateCalculateMacros(tdee, createMetricDto.GoalType, createMetricDto.Weight, goal.WeightGoal);
            goal.CaloriesGoal = calories;
            goal.ProteinGoal = protein;
            goal.CarbGoal = carbs;
            goal.FatGoal = fats;

            // Tinh FiberGoal và SugarGoal tu carbs
            goal.FiberGoal = carbs * 0.1f;
            goal.SugarGoal = carbs * 0.25f;

            // Tinh toan water
            goal.WaterGoal = (int)(createMetricDto.Weight * (createMetricDto.ActivityLevel == 1.2f || createMetricDto.ActivityLevel == 1.375f ? 30 : 40));
        }

        private (float calories, float protein, float carbs, float fats) CreateCalculateMacros(float tdee, string goalType, float currentWeight, float targetWeight)
        {
            float calories, proteinPercentage, carbPercentage, fatPercentage;
            switch (goalType)
            {
                case "WeightLoss":
                    if (targetWeight >= currentWeight)
                        throw new Exception($"Mục tiêu giảm cân phải nhỏ hơn cân nặng hiện tại ({currentWeight}).");
                    calories = tdee * 0.8f; // Giảm 20%
                    proteinPercentage = 0.4f; // 40% Protein
                    carbPercentage = 0.35f;  // 35% Carb
                    fatPercentage = 0.25f;   // 25% Fat
                    break;

                case "MaintainWeight":
                    if (targetWeight <= currentWeight)
                        throw new Exception($"Mục tiêu tăng cân phải lớn hơn cân nặng hiện tại ({currentWeight}).");
                    calories = tdee * 1.1f; // Tăng 10-15%
                    proteinPercentage = 0.3f; // 30% Protein
                    carbPercentage = 0.5f;   // 50% Carb
                    fatPercentage = 0.2f;    // 20% Fat
                    break;

                case "WeightGain":
                    calories = tdee; // Giữ nguyên TDEE
                    proteinPercentage = 0.3f; // 30% Protein
                    carbPercentage = 0.4f;   // 40% Carb
                    fatPercentage = 0.3f;    // 30% Fat
                    break;

                default:
                    throw new Exception("Loại mục tiêu không hợp lệ.");
            }

            float protein = calories * proteinPercentage / 4;
            float carbs = calories * carbPercentage / 4;
            float fats = calories * fatPercentage / 9;

            return (calories, protein, carbs, fats);
        }

        public void UpdateMetricCalculateGoal(Goal goalToUpdate, string goalType, float tdee, float weight, float activityLevel)
        {
            // tinh toan cac chi so Macros
            var (calories, protein, carbs, fats) = UpdateCalculateMacros(tdee, goalType);
            goalToUpdate.CaloriesGoal = calories;
            goalToUpdate.ProteinGoal = protein;
            goalToUpdate.CarbGoal = carbs;
            goalToUpdate.FatGoal = fats;

            // Tinh FiberGoal và SugarGoal tu carbs
            goalToUpdate.FiberGoal = carbs * 0.1f;
            goalToUpdate.SugarGoal = carbs * 0.25f;

            // Tinh toan water
            goalToUpdate.WaterGoal = (int)(weight * (activityLevel == 1.2f || activityLevel == 1.375f ? 30 : 40));
        }
        private (float calories, float protein, float carbs, float fats) UpdateCalculateMacros(float tdee, string goalType)
        {
            float calories, proteinPercentage, carbPercentage, fatPercentage;
            switch (goalType)
            {
                case "WeightLoss":
                    calories = tdee * 0.8f; // Giảm 20%
                    proteinPercentage = 0.4f; // 40% Protein
                    carbPercentage = 0.35f;  // 35% Carb
                    fatPercentage = 0.25f;   // 25% Fat
                    break;

                case "MaintainWeight":
                    calories = tdee * 1.1f; // Tăng 10-15%
                    proteinPercentage = 0.3f; // 30% Protein
                    carbPercentage = 0.5f;   // 50% Carb
                    fatPercentage = 0.2f;    // 20% Fat
                    break;

                case "WeightGain":
                    calories = tdee; // Giữ nguyên TDEE
                    proteinPercentage = 0.3f; // 30% Protein
                    carbPercentage = 0.4f;   // 40% Carb
                    fatPercentage = 0.3f;    // 30% Fat
                    break;

                default:
                    throw new Exception("Loại mục tiêu không hợp lệ.");
            }

            float protein = calories * proteinPercentage / 4;
            float carbs = calories * carbPercentage / 4;
            float fats = calories * fatPercentage / 9;

            return (calories, protein, carbs, fats);
        }
    }
}
