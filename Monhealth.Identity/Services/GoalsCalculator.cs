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

        public void CreateCalculateGoal(Goal goal, CreateMetricDTO createMetricDto, float tdee)
        {
            goal.GoalType = createMetricDto.GoalType;

            // Tính toán các chỉ số Macros
            var (calories, protein, carbs, fats) = CreateCalculateMacros(
                tdee, createMetricDto.GoalType.ToString(), createMetricDto.CaloriesRatio,
                createMetricDto.Weight, goal.WeightGoal, createMetricDto.ActivityLevel);
            goal.CaloriesGoal = calories;
            goal.ProteinGoal = protein;
            goal.CarbsGoal = carbs;
            goal.FatGoal = fats;

            // Tính FiberGoal và SugarGoal từ Carbs
            (goal.FiberGoal, goal.SugarGoal) = CalculateFiberAndSugar(carbs, createMetricDto.GoalType.ToString());

            // Tính toán lượng nước cần uống
            goal.WaterIntakesGoal = (int)(createMetricDto.Weight * (createMetricDto.ActivityLevel < 1.725f ? 35 : 40));

            goal.WorkoutDurationGoal = CalculateWorkoutDurationGoal(createMetricDto.GoalType);
            goal.CaloriesBurnedGoal = EstimateCaloriesBurned(goal.WorkoutDurationGoal, createMetricDto.Weight, createMetricDto.ActivityLevel);
        }

        public float CalculateWorkoutDurationGoal(GoalType goalType)
        {
            switch (goalType)
            {
                case GoalType.WeightLoss:
                    return 45f; // Khoảng 315 phút/tuần
                case GoalType.Maintenance:
                    return 30f; // Khoảng 210 phút/tuần
                case GoalType.WeightGain:
                    return 35f; // Khoảng 245 phút/tuần
                default:
                    return 30f;
            }
        }

        private float EstimateCaloriesBurned(float workoutDurationMinutes, float weightKg, float activityLevel)
        {
            // MET (Metabolic Equivalent of Task) trung bình:
            // - Cường độ nhẹ: ~4
            // - Trung bình: ~6
            // - Cao: ~8

            float met;

            if (activityLevel < 1.55f)         // Ít vận động
                met = 4f;
            else if (activityLevel < 1.9f)     // Vận động vừa
                met = 6f;
            else                               // Vận động nhiều
                met = 8f;

            // Công thức tính Calories đốt cháy:
            // Calories = MET * weight(kg) * thời gian (giờ)
            float caloriesBurned = met * weightKg * (workoutDurationMinutes / 60f);

            return caloriesBurned;
        }

        private (float calories, float protein, float carbs, float fats) CreateCalculateMacros(
            float tdee, string goalType, float caloriesRatio, float currentWeight,
            float targetWeight, float activityLevel)
        {
            // Kiểm tra hợp lệ Calories Ratio
            // if (caloriesRatio < 1.2f || caloriesRatio > 1.9f)
            //     throw new Exception("Calories Ratio không hợp lệ (phải từ 1.2 đến 1.9)");

            // Kiểm tra hợp lệ mục tiêu giảm cân/tăng cân
            if ((goalType == "WeightLoss" && targetWeight >= currentWeight) ||
                (goalType == "WeightGain" && targetWeight <= currentWeight))
                throw new Exception("Mục tiêu cân nặng không hợp lệ");

            float calories = tdee * caloriesRatio;
            float proteinPercentage, carbsPercentage, fatPercentage;

            switch (goalType)
            {
                case "WeightLoss":
                    proteinPercentage = 0.35f;
                    carbsPercentage = 0.3f;
                    fatPercentage = 0.35f;
                    break;

                case "WeightGain":
                    proteinPercentage = 0.25f;
                    carbsPercentage = 0.45f;
                    fatPercentage = 0.3f;
                    break;

                case "Maintenance":
                    proteinPercentage = 0.20f;
                    carbsPercentage = 0.5f;
                    fatPercentage = 0.3f;
                    break;

                default:
                    throw new Exception("Loại mục tiêu không hợp lệ");
            }


            // Tính Macro từ Calories
            float protein = calories * proteinPercentage / 4;
            float carbs = calories * carbsPercentage / 4;
            float fats = calories * fatPercentage / 9;

            return (calories, protein, carbs, fats);
        }

        private (float fiberGoal, float sugarGoal) CalculateFiberAndSugar(float carbs, string goalType)
        {
            float fiberPercentage, sugarPercentage;

            switch (goalType)
            {
                case "WeightLoss":
                    fiberPercentage = 0.12f; // 12% từ Carbs
                    sugarPercentage = 0.2f;  // 20% từ Carbs
                    break;

                case "Maintenance":
                    fiberPercentage = 0.1f;  // 10% từ Carbs
                    sugarPercentage = 0.25f; // 25% từ Carbs
                    break;

                case "WeightGain":
                    fiberPercentage = 0.08f; // 8% từ Carbs
                    sugarPercentage = 0.3f;  // 30% từ Carbs
                    break;

                default:
                    throw new Exception("Loại mục tiêu không hợp lệ");
            }

            float fiberGoal = carbs * fiberPercentage;
            float sugarGoal = carbs * sugarPercentage;

            return (fiberGoal, sugarGoal);
        }

        public void UpdateMetricCalculateGoal(Goal goalToUpdate, string goalType, float tdee, float weight, float activityLevel)
        {
            var (calories, protein, carbs, fats) = UpdateCalculateMacros(tdee, goalType);
            goalToUpdate.CaloriesGoal = calories;
            goalToUpdate.ProteinGoal = protein;
            goalToUpdate.CarbsGoal = carbs;
            goalToUpdate.FatGoal = fats;

            // Sử dụng công thức mới cho Fiber và Sugar từ Carbs
            (goalToUpdate.FiberGoal, goalToUpdate.SugarGoal) = CalculateFiberAndSugar(carbs, goalType);

            // Tính toán lượng nước cần uống
            goalToUpdate.WaterIntakesGoal = (int)(weight * (activityLevel < 1.725f ? 35 : 40));
        }

        private (float calories, float protein, float carbs, float fats) UpdateCalculateMacros(float tdee, string goalType)
        {
            float calories, proteinPercentage, carbsPercentage, fatPercentage;

            switch (goalType)
            {
                case "WeightLoss":
                    calories = tdee * 0.8f;
                    proteinPercentage = 0.35f; //35%
                    carbsPercentage = 0.4f; //40%
                    fatPercentage = 0.25f; //25%
                    break;

                case "WeightGain":
                    calories = tdee * 1.1f;
                    proteinPercentage = 0.35f; //35%
                    carbsPercentage = 0.4f; //40%
                    fatPercentage = 0.25f; //25%
                    break;

                case "Maintenance":
                    calories = tdee;
                    proteinPercentage = 0.25f; //25%
                    carbsPercentage = 0.5f; //50%
                    fatPercentage = 0.25f; //25%
                    break;

                default:
                    throw new Exception("Loại mục tiêu không hợp lệ");
            }

            float protein = calories * proteinPercentage / 4;
            float carbs = calories * carbsPercentage / 4;
            float fats = calories * fatPercentage / 9;

            return (calories, protein, carbs, fats);
        }
    }
}
