using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetNutritionByGoalId
{
    public class GetNutritionByGoalIdQuery : IRequest<GetNutritionByGoalIdDTO>
    {
        public Guid UserId { get; set; }

    }
}
