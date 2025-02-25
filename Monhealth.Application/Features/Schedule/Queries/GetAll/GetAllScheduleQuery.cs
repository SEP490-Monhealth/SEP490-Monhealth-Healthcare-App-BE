using MediatR;

namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class GetAllScheduleQuery : IRequest<List<ScheduleDTO>>
    {

    }
}