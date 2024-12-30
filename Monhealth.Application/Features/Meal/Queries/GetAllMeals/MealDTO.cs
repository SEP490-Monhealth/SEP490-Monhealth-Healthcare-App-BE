using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Meal.Queries.GetAllMeals
{
    public class MealDTO : BaseEntity
    {
        public Guid MealId { get; set; }
        public Guid UserId { get; set; }
        [JsonPropertyName("type")]
        public string MealType { get; set; } = string.Empty;
        public MealFoodNutritionDTO Nutrition { get; set; }
        // public List<MealFoodDTO> Items { get; set; }


    }
    // public class MealFoodDTO
    // {
    //     public Guid MealFoodId { get; set; }
    //     public Guid FoodId { get; set; }
    //     public int Quantity { get; set; }
    //     public string Name { get; set; } = string.Empty;
    //     public MealFoodPortionDTO Portions { get; set; }
    //     public float Calories { get; set; }


    // }
    public class MealFoodPortionDTO
    {
        public string Size { get; set; } = string.Empty;
        public float? Weight { get; set; }
        public string Unit { get; set; } = string.Empty;
    }

    public class MealFoodNutritionDTO
    {
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
}