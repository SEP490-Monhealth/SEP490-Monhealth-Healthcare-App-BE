using Monhealth.Core;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IReminderRepository : IGenericRepository<Reminder, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<List<Reminder>> GetAllReminderAsync();
        Task<Reminder> GetReminderById(Guid reminderId);
        Task<List<Reminder>> GetReminderByUser(Guid userId);
        Task<List<Reminder>> GetActiveRemindersAsync(string currentTime);
        Task<List<Reminder>>CreateReminders(float waterGoal, Guid goalId ,Guid? userId);
    }
}