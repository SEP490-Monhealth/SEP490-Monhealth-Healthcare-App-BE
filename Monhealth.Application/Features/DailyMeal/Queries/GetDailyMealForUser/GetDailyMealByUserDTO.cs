using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser
{
    public class GetDailyMealByUserDTO : BaseEntity
    {
        public Guid DailyMealId { get; set; }
        public GoalDailyMealDTO2 Goal { get; set; }
        public NutritionOfDailyMeal2 Nutrition { get; set; }
        public List<MealForDailyMeal2> Items { get; set; }
    }
    public class NutritionOfDailyMeal2
    {
        [JsonPropertyName("calories")]
        public float TotalCalories { get; set; }
        [JsonPropertyName("protein")]
        public float TotalProteins { get; set; }
        [JsonPropertyName("carbs")]
        public float TotalCarbs { get; set; }
        [JsonPropertyName("fat")]
        public float TotalFats { get; set; }
        [JsonPropertyName("fiber")]
        public float TotalFibers { get; set; }
        [JsonPropertyName("sugar")]
        public float TotalSugars { get; set; }
    }
    public class MealForDailyMeal2
    {
        public Guid mealId { get; set; }
        [JsonPropertyName("type")]
        public string MealType { get; set; } = string.Empty;
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
    public class GoalDailyMealDTO2
    {
        [JsonPropertyName("type")]
        public string GoalType { get; set; } = string.Empty;
        public float CaloriesGoal { get; set; }
        public float ProteinGoal { get; set; }
        public float CarbsGoal { get; set; }
        public float FatGoal { get; set; }
        public float FiberGoal { get; set; }
        public float SugarGoal { get; set; }
    }
}