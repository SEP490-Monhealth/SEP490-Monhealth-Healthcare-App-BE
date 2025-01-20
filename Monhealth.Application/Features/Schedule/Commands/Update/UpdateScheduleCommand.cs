using MediatR;

namespace Monhealth.Application.Features.Schedule.Commands.Update
{
    public class UpdateScheduleCommand : IRequest<bool>
    {

        public Guid ScheduleId { get; set; }
        public UpdateScheduleRequest Request { get; set; }
        public UpdateScheduleCommand(Guid scheduleId, UpdateScheduleRequest request)
        {
            ScheduleId = scheduleId;
            Request = request;
        }
        
    }
}