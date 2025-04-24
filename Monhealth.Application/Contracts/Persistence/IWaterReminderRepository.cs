using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IWaterReminderRepository : IGenericRepository<WaterReminder, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<PaginatedResult<WaterReminder>> GetAllReminderAsync(int page, int limit, string? search, bool? recurring, bool? status);
        Task<WaterReminder> GetReminderById(Guid reminderId);
        Task<List<WaterReminder>> GetReminderByUser(Guid userId , bool? Status);
        Task<List<WaterReminder>> GetActiveRemindersAsync(string currentTime);
        Task<List<WaterReminder>> CreateReminders(float WaterIntakesGoal, Guid? userId);
        Task<List<WaterReminder>> GetAllActiveWaterRemindersAsync();
        Task UpdateWaterReminders(List<WaterReminder> reminders);
        Task<List<WaterReminder>> GetWaterRemindersByUser(Guid userId);
        Task<WaterReminder> GetWaterReminderByUser(Guid userId, DateTime date);
        Task<WaterReminder> GetByUserIdAndTimeAsync(Guid userId, string time);
    }
}