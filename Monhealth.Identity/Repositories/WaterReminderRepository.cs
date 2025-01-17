using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ReminderRepository : GenericRepository<WaterReminder, Guid>, IWaterReminderRepository
    {
        public ReminderRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public Task<List<WaterReminder>> CreateReminders(float waterGoal, Guid? userId)
        {
            // Các khung giờ cố định và phần trăm tổng lượng nước
            var timeSlots = new List<(TimeSpan Time, float Percentage)>
            {
                (TimeSpan.Parse("07:00"), 0.15f),
                (TimeSpan.Parse("09:00"), 0.10f),
                (TimeSpan.Parse("11:00"), 0.10f),
                (TimeSpan.Parse("13:00"), 0.15f),
                (TimeSpan.Parse("15:30"), 0.15f),
                (TimeSpan.Parse("17:00"), 0.15f),
                (TimeSpan.Parse("19:30"), 0.10f),
                (TimeSpan.Parse("21:30"), 0.10f)
            };

            // Danh sách Reminder
            var reminders = new List<WaterReminder>();
            int index = 1;

            foreach (var slot in timeSlots)
            {
                // Tính toán lượng nước cho từng khung giờ
                var volume = waterGoal * slot.Percentage;
                // Tạo Reminder mới
                reminders.Add(new WaterReminder
                {
                    WaterReminderId = Guid.NewGuid(), 
                    UserId = userId,
                    WaterReminderName = $"Nhắc nhở {index}",
                    Time = slot.Time.ToString(@"hh\:mm"), // Thời gian nhắc nhở
                    Volume = (float)Math.Round(volume), // Lượng nước cần uống
                    Status = true, // Trạng thái mặc định
                    CreatedAt = DateTime.Now, // Thời gian tạo
                    UpdatedAt = DateTime.Now // Thời gian cập nhật
                });

                index++;
            }

            // Trả về danh sách Reminder dưới dạng Task
            return Task.FromResult(reminders);
        }


        public async Task<List<WaterReminder>> GetActiveRemindersAsync(string currentTime)
        {
            return await _context.WaterReminders
            .Where(r => r.Status && r.Time == currentTime)
            .ToListAsync();

        }

        public async Task<List<WaterReminder>> GetAllActiveWaterRemindersAsync()
        {
            return await _context.WaterReminders.
            Where(water => water.IsDrunk == true).ToListAsync();
        }

        public async Task<List<WaterReminder>> GetAllReminderAsync()
        {
            return await _context.WaterReminders.Include(r => r.AppUser)
                .OrderBy(t => t.Time)
                .ToListAsync();
        }

        public async Task<WaterReminder> GetReminderById(Guid waterReminderId)
        {
            return await _context.WaterReminders.FirstOrDefaultAsync(r => r.WaterReminderId == waterReminderId);
        }

        public async Task<List<WaterReminder>> GetReminderByUser(Guid userId)
        {
            return await _context.WaterReminders
                .Where(r => r.UserId == userId)
                .OrderBy(t => t.Time)
                .ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task UpdateWaterReminders(List<WaterReminder> reminders)
        {
            _context.WaterReminders.UpdateRange(reminders);
            await _context.SaveChangesAsync();
        }
    }
}