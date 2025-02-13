using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Schedule.Commands.Update
{
    public class UpdateScheduleCommandHandler : IRequestHandler<UpdateScheduleCommand, bool>
    {
        private readonly IScheduleRepository _scheduleRepository;

        public UpdateScheduleCommandHandler(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public async Task<bool> Handle(UpdateScheduleCommand request, CancellationToken cancellationToken)
        {
            var id = await _scheduleRepository.GetByIdAsync(request.ScheduleId);
            id.Date = request.Request.Date;
            id.StarTime = request.Request.StartTime;
            id.EndTime = request.Request.EndTime;
            id.BookedSlots = request.Request.BookedSlots;
            id.MaxBookings = request.Request.MaxBookings;
            id.UpdatedAt = DateTime.Now;
            _scheduleRepository.Update(id);
            await _scheduleRepository.SaveChangeAsync();
            return true;
        }
    }
}