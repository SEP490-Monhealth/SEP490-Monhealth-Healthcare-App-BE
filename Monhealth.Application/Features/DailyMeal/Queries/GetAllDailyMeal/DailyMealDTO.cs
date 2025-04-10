using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.Text.Json.Serialization;
namespace Monhealth.Application.Features.DailyMeal.Queries.GetAllDailyMeal
{
    public class DailyMealDTO : TimeEntity
    {
        public Guid DailyMealId { get; set; }
        public Guid UserId { get; set; }
        // public GoalDailyMealDTO Goal { get; set; }
        public GoalType GoalType { get; set; }

        public NutritionOfDailyMeal Nutrition { get; set; }
        public List<MealForDailyMeal> Items { get; set; }
    }
    public class NutritionOfDailyMeal
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
    public class MealForDailyMeal
    {
        public Guid mealId { get; set; }
        [JsonPropertyName("type")]
        public MealType MealType { get; set; }
        public int Foods { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }

    }
    // public class GoalDailyMealDTO
    // {
    //     public string GoalType { get; set; } = string.Empty;
    //     public float CaloriesGoal { get; set; }
    //     public float ProteinGoal { get; set; }
    //     public float CarbsGoal { get; set; }
    //     public float FatGoal { get; set; }
    //     public float FiberGoal { get; set; }
    //     public float SugarGoal { get; set; }
    // }
}