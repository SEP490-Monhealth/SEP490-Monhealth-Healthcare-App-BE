using Monhealth.Core;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IReminderRepository : IGenericRepository<WaterReminder, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<List<WaterReminder>> GetAllReminderAsync();
        Task<WaterReminder> GetReminderById(Guid reminderId);
        Task<List<WaterReminder>> GetReminderByUser(Guid userId);
        Task<List<WaterReminder>> GetActiveRemindersAsync(string currentTime);
        Task<List<WaterReminder>>CreateReminders(float waterGoal ,Guid? userId);
    }
}