
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Identity.BackGroundServiceForWaterReminder
{
    public class WaterReminderResetService
    {
        private readonly IWaterReminderRepository _repository;

        public WaterReminderResetService(IWaterReminderRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> ResetRemindersAsync()
        {
            var now = DateTime.UtcNow;
            var activeReminders = await _repository.GetAllActiveWaterRemindersAsync();
            int resetCount = 0;

            foreach (var reminder in activeReminders)
            {
                if (reminder.CreatedAt.HasValue && reminder.CreatedAt.Value.Date < now.Date)
                {
                    reminder.IsDrunk = false;
                    resetCount++;
                }
            }

            if (resetCount > 0)
            {
                await _repository.UpdateWaterReminders(activeReminders);
            }

            return resetCount;
        }
    }

}