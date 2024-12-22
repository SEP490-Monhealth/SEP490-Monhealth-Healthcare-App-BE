using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition
{
    public class NutritionByFoodIdDto : BaseEntity
    {
        public Guid NutritionId { get; set; }
        public Guid? UserFoodId { get; set; }
        public Guid? FoodId { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
}