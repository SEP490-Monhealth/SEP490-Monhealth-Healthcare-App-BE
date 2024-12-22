namespace Monhealth.Application.Features.Nutrition.AddNutrition
{
    public class NutritionRequest
    {
        public Guid? FoodId { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
}