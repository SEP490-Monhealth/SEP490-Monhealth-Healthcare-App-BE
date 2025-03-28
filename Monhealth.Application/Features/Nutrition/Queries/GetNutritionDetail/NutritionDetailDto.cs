using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Nutrition.Queries.GetNutritionDetail
{
    public class NutritionDetailDto : BaseEntity
    {
        public Guid NutritionId { get; set; }
        public Guid? FoodId { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
        public float? SaturatedFat { get; set; }
        public float? UnsaturatedFat { get; set; }
        public float? Cholesterol { get; set; }
        public float? Sodium { get; set; }
        public float? Potassium { get; set; }
        public float? Calcium { get; set; }
        public float? Iron { get; set; }
        public float? VitaminA { get; set; }
        public float? VitaminB1 { get; set; }
        public float? VitaminB2 { get; set; }
        public float? VitaminC { get; set; }
        public float? VitaminD { get; set; }
        public float? VitaminE { get; set; }
    }
}