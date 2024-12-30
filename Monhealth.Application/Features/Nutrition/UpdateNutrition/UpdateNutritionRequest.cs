using MediatR;

namespace Monhealth.Application.Features.Nutrition.UpdateNutrition
{
    public class UpdateNutritionRequest : IRequest<bool>
    {
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Fiber { get; set; }
        public float Sugar { get; set; }
    }
}