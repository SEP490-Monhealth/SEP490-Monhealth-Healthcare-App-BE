using MediatR;

namespace Monhealth.Application.Features.Schedule.Commands.Update
{
    public class UpdateScheduleRequest : IRequest<bool>
    {
        public DateOnly? Date { get; set; }
        public TimeOnly? Time { get; set; }

        public Guid ConsultantId { get; set; } // FK 

    }
}