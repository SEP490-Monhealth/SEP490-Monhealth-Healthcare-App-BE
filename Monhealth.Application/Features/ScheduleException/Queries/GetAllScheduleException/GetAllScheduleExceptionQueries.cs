using MediatR;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException
{
    public class GetAllScheduleExceptionQueries : IRequest<IEnumerable<ScheduleExceptionDto>>
    {

    }
}
