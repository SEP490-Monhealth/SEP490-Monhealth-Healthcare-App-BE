using System.Net.NetworkInformation;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class RemoveScheduleTimeSlot : IRequest<bool>
    {
        public Guid ScheduleTimeSlotId { get; set; }
        public RemoveScheduleTimeSlot(Guid scheduleTimeSlotId)
        {
            ScheduleTimeSlotId = scheduleTimeSlotId;
        }


    }
    public class RemoveScheduleTimeSlotCommandHandler : IRequestHandler<RemoveScheduleTimeSlot, bool>
    {
        private readonly IScheduleTimeSlotRepository _scheduleTimeSlotRepository;
        public RemoveScheduleTimeSlotCommandHandler(IScheduleTimeSlotRepository scheduleTimeSlotRepository)
        {
            _scheduleTimeSlotRepository = scheduleTimeSlotRepository;
        }


        public async Task<bool> Handle(RemoveScheduleTimeSlot request, CancellationToken cancellationToken)
        {
            var scheduleTimeSlot = await _scheduleTimeSlotRepository.GetByIdAsync(request.ScheduleTimeSlotId);
            if (scheduleTimeSlot == null)
            {
                throw new Exception("ScheduleTimeSlot not found");
            }
            _scheduleTimeSlotRepository.Remove(scheduleTimeSlot);
            await _scheduleTimeSlotRepository.SaveChangesAsync();
            return true;
        }
    }
}