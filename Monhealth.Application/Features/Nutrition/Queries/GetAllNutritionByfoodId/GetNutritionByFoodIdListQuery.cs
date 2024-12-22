using MediatR;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition;

namespace Monhealth.Application.Features.Nutrition.Queries.GetAllNutritionByfoodId
{
    public class GetNutritionByFoodIdListQuery : IRequest<List<NutritionByFoodIdDto>>
    {
         public Guid FoodId { get; set; }
    }
}