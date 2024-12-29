using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.MealFood.Queries
{
    public class GetMealFoodByMealIdDTO : BaseEntity
    {
        public Guid MealFoodId { get; set; }
        public Guid FoodId { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; } = string.Empty;
        public MealFoodPortionDTO1 Portions { get; set; }
        public NutritionDTO1 Nutrition { get; set; }

    }
    public class NutritionDTO1
    {
        public float Calories { get; set; }
    }
    public class MealFoodPortionDTO1
    {
        public string Size { get; set; } = string.Empty;
        public float? Weight { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}