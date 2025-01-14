using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ReminderRepository : GenericRepository<Reminder, Guid>, IReminderRepository
    {
        public ReminderRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public Task<List<Reminder>> CreateReminders(float waterGoal, Guid goalId , Guid? userId)
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
            var reminders = new List<Reminder>();

            foreach (var slot in timeSlots)
            {
                // Tính toán lượng nước cho từng khung giờ
                var volume = waterGoal * slot.Percentage;

                // Tạo Reminder mới
                reminders.Add(new Reminder
                {
                    ReminderId = Guid.NewGuid(), // Tạo ID duy nhất
                    GoalId = goalId,
                    UserId = userId,// Liên kết với mục tiêu
                    Time = slot.Time, // Thời gian nhắc nhở
                    Volume = volume, // Lượng nước cần uống
                    ReminderName = $"Uống nước {volume}ml vào {slot.Time}", // Tên nhắc nhở
                    Status = true, // Trạng thái mặc định
                    IsDefault = true, // Đánh dấu nhắc nhở mặc định
                    CreatedAt = DateTime.Now, // Thời gian tạo
                    UpdatedAt = DateTime.Now // Thời gian cập nhật
                });
            }

            // Trả về danh sách Reminder dưới dạng Task
            return Task.FromResult(reminders);
        }


        public async Task<List<Reminder>> GetActiveRemindersAsync(string currentTime)
        {
            return await _context.Reminders
            .Where(r => r.Status && r.Time == currentTime)
            .ToListAsync();

        }

        public async Task<List<Reminder>> GetAllReminderAsync()
        {
            return await _context.Reminders.Include(r => r.AppUser).ToListAsync();
        }

        public async Task<Reminder> GetReminderById(Guid reminderId)
        {
            return await _context.Reminders.FirstOrDefaultAsync(r => r.ReminderId == reminderId);
        }

        public async Task<List<Reminder>> GetReminderByUser(Guid userId)
        {
            return await _context.Reminders.Where(r => r.UserId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}