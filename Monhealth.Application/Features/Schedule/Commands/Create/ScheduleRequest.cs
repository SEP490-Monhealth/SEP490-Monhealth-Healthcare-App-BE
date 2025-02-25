using MediatR;

namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class ScheduleRequest : IRequest<bool>
    {
        public Guid ConsultantId { get; set; } // FK 

        public List<CreateScheduleDto> Items { get; set; }


    }
}