using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleTimeSlotRepository : IGenericRepository<ScheduleTimeSlot, Guid>
    {
        Task<List<Guid>> GetTimslotIdsByScheduleId(Guid scheduleId);
    }
}
