using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ITimeSlotRepository : IGenericRepository<TimeSlot, Guid>
    {
        Task<List<TimeSlot>> GetExistTimeSlotByListTimeAsync(List<TimeOnly> timeSlots);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        Task<TimeSlot> GetTimeSlotByStartTime(TimeOnly startTime);

    }
}
