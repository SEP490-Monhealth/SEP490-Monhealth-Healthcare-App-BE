using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Schedule.Commands.UpdateScheduleStatus
{
    public class UpdateScheduleStatusCommandHandler(IScheduleRepository scheduleRepository) : IRequestHandler<UpdateScheduleStatusCommand, bool>
    {
        public async Task<bool> Handle(UpdateScheduleStatusCommand request, CancellationToken cancellationToken)
        {
            var schedule = await scheduleRepository.GetByIdAsync(request.ScheduleId);
            if (schedule == null) throw new BadRequestException("Không tìm thấy lịch");
            if (schedule.Status == Domain.Enum.ScheduleStatus.Available)
            {
                schedule.Status = Domain.Enum.ScheduleStatus.Unavailable;
            }
            else
            {
                schedule.Status = Domain.Enum.ScheduleStatus.Available;
            }
            scheduleRepository.Update(schedule);
            await scheduleRepository.SaveChangeAsync();
            return true;
        }
    }
}
