using Monhealth.Core;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IWaterReminderRepository : IGenericRepository<WaterReminder, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<List<WaterReminder>> GetAllReminderAsync();
        Task<WaterReminder> GetReminderById(Guid reminderId);
        Task<List<WaterReminder>> GetReminderByUser(Guid userId);
        Task<List<WaterReminder>> GetActiveRemindersAsync(string currentTime);
        Task<List<WaterReminder>> CreateReminders(float WaterIntakesGoal, Guid? userId);
        Task<List<WaterReminder>>GetAllActiveWaterRemindersAsync();
        Task UpdateWaterReminders(List<WaterReminder> reminders);
        Task<List<WaterReminder>>GetWaterRemindersByUser(Guid userId);
    }
}