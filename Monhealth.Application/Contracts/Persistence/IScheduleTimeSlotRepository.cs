using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IScheduleTimeSlotRepository : IGenericRepository<ScheduleTimeSlot, Guid>
    {
        Task<List<Guid>> GetTimslotIdsByScheduleId(Guid scheduleId);
        Task<bool> ExistTimeSlot(Guid scheduleId, Guid timeSlotId);
        Task<int>SaveChangesAsync();
    }
}
