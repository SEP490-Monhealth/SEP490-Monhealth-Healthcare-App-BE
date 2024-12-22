using MediatR;

namespace Monhealth.Application.Features.Nutrition.Queries.GetNutritionDetail
{
    public class GetNutritionDetailQuery : IRequest<NutritionDetailDto>
    {
        public Guid NutritionId { get; set; }
    }
}