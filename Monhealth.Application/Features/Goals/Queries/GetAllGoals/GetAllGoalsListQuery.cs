using MediatR;
using Monhealth.Application.Features.Goals.Queries.GetAllGoalQuery;

namespace Monhealth.Application.Features.Goals.Queries.GetAllGoals
{
    public class GetAllGoalsListQuery : IRequest<List<GetAllGoalsDTO>>
    {

    }
}
