using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class CreateScheduleCommand : IRequest<Unit>
    {
        public Guid ConsultantId { get; set; }
        public ScheduleType ScheduleType { get; set; }
        public List<CreateScheduleDto> Schedules { get; set; }
    }
}
