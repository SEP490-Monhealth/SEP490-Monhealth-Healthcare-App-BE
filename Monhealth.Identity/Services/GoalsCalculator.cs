using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Domain;

namespace Monhealth.Identity.Services
{
    public class GoalsCalculator : IGoalsCalculator
    {
        private readonly IMetricRepository _metricRepository;
        public GoalsCalculator(IMetricRepository metricRepository)
        {
            _metricRepository = metricRepository;
        }
        public void CreateCalculateGoal(Goal goal, CreateMetricDTO createMetricDto, float tdee)
        {
            goal.GoalType = createMetricDto.GoalType;
            // tinh toan cac chi so Macros
            var (calories, protein, carbs, fats, fiberGoal, sugarGoal) = CreateCalculateMacros(tdee, createMetricDto.GoalType.ToString(), createMetricDto.CaloriesRatio, createMetricDto.Weight, goal.WeightGoal);
            goal.CaloriesGoal = calories;
            goal.ProteinGoal = protein;
            goal.CarbsGoal = carbs;
            goal.FatGoal = fats;

            // Tinh FiberGoal và SugarGoal tu carbs
            goal.FiberGoal = fiberGoal;
            goal.SugarGoal = sugarGoal;

            // Tinh toan water
            goal.WaterIntakesGoal = (int)(createMetricDto.Weight * (createMetricDto.ActivityLevel == 1.2f || createMetricDto.ActivityLevel == 1.375f ? 30 : 40));
        }

        private (float calories, float protein, float carbs, float fats, float fiberGoal, float sugarGoal) CreateCalculateMacros(float tdee, string goalType, float caloriesRatio, float currentWeight, float targetWeight)
        {
            float calories, proteinPercentage, carbPercentage, fatPercentage, fiberGoal, sugarGoal;
            switch (goalType)
            {
                case "WeightLoss":
                    if (targetWeight >= currentWeight)
                        throw new Exception($"Mục tiêu giảm cân phải nhỏ hơn cân nặng hiện tại ({currentWeight}).");
                    calories = tdee * caloriesRatio; // Giảm 20%
                    fiberGoal = (calories * 1.1f) / 4;
                    sugarGoal = (calories * 0.05f) / 4;
                    proteinPercentage = 0.35f; // 40% Protein
                    carbPercentage = 0.4f;  // 35% Carb
                    fatPercentage = 0.25f;   // 25% Fat
                    break;

                case "WeightGain":
                    if (targetWeight <= currentWeight)
                        throw new Exception($"Mục tiêu tăng cân phải lớn hơn cân nặng hiện tại ({currentWeight}).");
                    calories = tdee * caloriesRatio; // Tăng 10-15%
                    fiberGoal = (calories * 0.9f) / 4;
                    sugarGoal = (calories * 0.15f) / 4;
                    proteinPercentage = 0.35f; // 30% Protein
                    carbPercentage = 0.4f;   // 50% Carb
                    fatPercentage = 0.25f;    // 20% Fat
                    break;

                case "MaintainWeight":
                    calories = tdee * caloriesRatio; // Giữ nguyên TDEE
                    fiberGoal = (calories * 1.2f) / 4;
                    sugarGoal = (calories * 0.1f) / 4;
                    proteinPercentage = 0.25f; // 30% Protein
                    carbPercentage = 0.5f;   // 40% Carb
                    fatPercentage = 0.25f;    // 30% Fat
                    break;

                default:
                    throw new Exception("Loại mục tiêu không hợp lệ.");
            }

            float protein = calories * proteinPercentage / 4;
            float carbs = calories * carbPercentage / 4;
            float fats = calories * fatPercentage / 9;

            return (calories, protein, carbs, fats, fiberGoal, sugarGoal);
        }

        public void UpdateMetricCalculateGoal(Goal goalToUpdate, string goalType, float tdee, float weight, float activityLevel)
        {
            // tinh toan cac chi so Macros
            var (calories, protein, carbs, fats) = UpdateCalculateMacros(tdee, goalType);
            goalToUpdate.CaloriesGoal = calories;
            goalToUpdate.ProteinGoal = protein;
            goalToUpdate.CarbsGoal = carbs;
            goalToUpdate.FatGoal = fats;

            // Tinh FiberGoal và SugarGoal tu carbs
            goalToUpdate.FiberGoal = carbs * 0.1f;
            goalToUpdate.SugarGoal = carbs * 0.25f;

            // Tinh toan water
            goalToUpdate.WaterIntakesGoal = (int)(weight * (activityLevel == 1.2f || activityLevel == 1.375f ? 30 : 40));
        }
        private (float calories, float protein, float carbs, float fats) UpdateCalculateMacros(float tdee, string goalType)
        {
            float calories, proteinPercentage, carbPercentage, fatPercentage;
            switch (goalType)
            {
                case "WeightLoss":
                    calories = tdee * 0.8f; // Giảm 20%
                    proteinPercentage = 0.35f; // 40% Protein
                    carbPercentage = 0.4f;  // 35% Carb
                    fatPercentage = 0.25f;   // 25% Fat
                    break;

                case "WeightGain":
                    calories = tdee * 1.1f; // Tăng 10-15%
                    proteinPercentage = 0.35f; // 30% Protein
                    carbPercentage = 0.4f;   // 50% Carb
                    fatPercentage = 0.25f;    // 20% Fat
                    break;

                case "MaintainWeight":
                    calories = tdee; // Giữ nguyên TDEE
                    proteinPercentage = 0.25f; // 30% Protein
                    carbPercentage = 0.5f;   // 40% Carb
                    fatPercentage = 0.25f;    // 30% Fat
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
