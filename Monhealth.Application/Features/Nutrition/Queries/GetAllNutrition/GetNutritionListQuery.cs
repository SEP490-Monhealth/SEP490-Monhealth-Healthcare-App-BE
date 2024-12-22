using MediatR;

namespace Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition
{
    public class GetNutritionListQuery : IRequest<List<NutritionDto>>
    {
        
    }
}