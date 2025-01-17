using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ReminderRepository : GenericRepository<WaterReminder, Guid>, IReminderRepository
    {
        public ReminderRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public Task<List<WaterReminder>> CreateReminders(float waterGoal, Guid? userId)
        {
            // Các khung giờ cố định và phần trăm tổng lượng nước
            var timeSlots = new List<(string Time, float Percentage)>
            {
                ("07:00", 0.15f),
                ("09:00", 0.10f),
                ("11:00", 0.10f),
                ("13:00", 0.15f),
                ("15:30", 0.15f),
                ("17:00", 0.15f),
                ("19:30", 0.10f),
                ("21:30", 0.10f)
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
                    WaterReminderId = Guid.NewGuid(), // Tạo ID duy nhất
                    UserId = userId,// Liên kết với mục tiêu
                    WaterReminderName = $"Nhắc nhở {index}", // Tên nhắc nhở
                    Time = slot.Time, // Thời gian nhắc nhở
                    Volume = volume, // Lượng nước cần uống
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

        public async Task<List<WaterReminder>> GetAllReminderAsync()
        {
            return await _context.WaterReminders.Include(r => r.AppUser).ToListAsync();
        }

        public async Task<WaterReminder> GetReminderById(Guid waterReminderId)
        {
            return await _context.WaterReminders.FirstOrDefaultAsync(r => r.WaterReminderId == waterReminderId);
        }

        public async Task<List<WaterReminder>> GetReminderByUser(Guid userId)
        {
            return await _context.WaterReminders.Where(r => r.UserId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}