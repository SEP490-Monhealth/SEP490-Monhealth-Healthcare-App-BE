using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetNutritionByGoalId
{
    public class GetNutritionByGoalIdQuery : IRequest<GetNutritionByGoalIdDto>
    {
        public Guid GoalId { get; set; }

    }
}
