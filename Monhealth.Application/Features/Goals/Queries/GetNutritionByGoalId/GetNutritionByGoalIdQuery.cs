using MediatR;

namespace Monhealth.Application.Features.Goals.Queries.GetNutritionByGoalId
{
    public class GetNutritionByGoalIdQuery : IRequest<GetNutritionByGoalIdDto>
    {
        public Guid UserId { get; set; }

    }
}
