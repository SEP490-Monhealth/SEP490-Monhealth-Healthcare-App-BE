using MediatR;

namespace Monhealth.Application.Features.Schedule.Queries.GetByUser
{
    public class GetScheduleByUserQuery : IRequest<List<GetScheduleByUserDTO>>
    {
        public Guid UserId { get; set; }
    }
}