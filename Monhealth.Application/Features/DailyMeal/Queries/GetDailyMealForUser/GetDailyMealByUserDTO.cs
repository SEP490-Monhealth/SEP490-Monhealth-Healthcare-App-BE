using Monhealth.Core.Enum;
using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser
{
    public class GetDailyMealByUserDTO : TimeEntity
    {
        public Guid DailyMealId { get; set; }
        public GoalType GoalType { get; set; }
        [JsonPropertyName("date")]
        public DateTime DailyMealDate { get; set; }
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
        public MealType MealType { get; set; }
        public int Foods { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
}