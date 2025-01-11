using System.Text.Json.Serialization;
using Monhealth.Domain.Common;
namespace Monhealth.Application.Features.DailyMeal.Queries.GetAllDailyMeal
{
    public class DailyMealDTO : BaseEntity
    {
        public Guid DailyMealId { get; set; }
        public Guid UserId { get; set; }
        // public GoalDailyMealDTO Goal { get; set; }
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
        public string MealType { get; set; } = string.Empty;
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