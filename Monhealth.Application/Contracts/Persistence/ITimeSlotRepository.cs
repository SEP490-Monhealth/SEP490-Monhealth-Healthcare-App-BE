using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ITimeSlotRepository : IGenericRepository<TimeSlot, Guid>
    {
        Task<List<TimeSlot>> GetExistTimeSlotByListTimeAsync(List<(TimeOnly StartTime, TimeOnly EndTime)> timeRanges);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        Task<TimeSlot> GetTimeSlotByStartAndEndTime(TimeOnly startTime, TimeOnly endTime);
    }
}
