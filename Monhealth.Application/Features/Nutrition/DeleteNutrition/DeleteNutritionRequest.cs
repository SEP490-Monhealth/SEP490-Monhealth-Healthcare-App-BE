using MediatR;

namespace Monhealth.Application.Features.Nutrition.DeleteNutrition
{
    public class DeleteNutritionRequest : IRequest<bool>
    {
        public Guid NutritionId { get; set; }
        public DeleteNutritionRequest(Guid nutritionId)
        {
            NutritionId = nutritionId;
        }


    }
}