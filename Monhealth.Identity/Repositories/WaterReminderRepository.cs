using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ReminderRepository : GenericRepository<WaterReminder, Guid>, IWaterReminderRepository
    {
        public ReminderRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public Task<List<WaterReminder>> CreateReminders(float WaterIntakesGoal, Guid? userId)
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
                var volume = WaterIntakesGoal * slot.Percentage;
                // Tạo Reminder mới
                reminders.Add(new WaterReminder
                {
                    WaterReminderId = Guid.NewGuid(),
                    UserId = userId,
                    WaterReminderName = $"Nhắc nhở {index}",
                    Time = slot.Time.ToString(@"hh\:mm"), // Thời gian nhắc nhở
                    Volume = (float)Math.Round(volume), // Lượng nước cần uống
                    Status = true, // Trạng thái mặc định
                    IsRecurring = true,
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

        public async Task<PaginatedResult<WaterReminder>> GetAllReminderAsync(int page, int limit, string? search, bool? recurring, bool? status)
        {
            search = search?.ToLower().Trim();
            IQueryable<WaterReminder> query = _context.WaterReminders.AsQueryable();
            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.WaterReminderName, "SQL_Latin1_General_CP1_CI_AI").Contains(search) || 
                                         s.WaterReminderId.ToString().ToLower().Contains(search) ||
                                         s.UserId.ToString().ToLower().Contains(search) ||
                                         EF.Functions.Collate(s.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search) ||
                                         s.AppUser.Email.ToString().ToLower().Contains(search) ||
                                         s.AppUser.PhoneNumber.ToString().ToLower().Contains(search));
            }
            if (recurring.HasValue)
            {
                query = query.Where(w => w.IsRecurring == recurring);
            }
            if (status.HasValue)
            {
                query = query.Where(w => w.Status == status);
            }

            query = query.Include(w => w.AppUser).OrderBy(w => w.Time);
            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<WaterReminder>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<WaterReminder> GetReminderById(Guid waterReminderId)
        {
            return await _context.WaterReminders.FirstOrDefaultAsync(r => r.WaterReminderId == waterReminderId);
        }

        public async Task<List<WaterReminder>> GetReminderByUser(Guid userId , bool? Status)
        {
            var queries = await _context.WaterReminders
                .Where(r => r.UserId == userId)
                .OrderBy(t => t.Time)
                .ToListAsync();
                if (Status.HasValue)
                {
                    queries = queries.Where(r => r.Status == Status.Value).ToList();
                }
                return queries;
             
        }

        public async Task<WaterReminder> GetWaterReminderByUser(Guid userId, DateTime date)
        {
            return await _context.WaterReminders
                .Where(r => r.UserId == userId && r.CreatedAt.Value.Date == date.Date)
                .FirstOrDefaultAsync();
        }

        public async Task<List<WaterReminder>> GetWaterRemindersByUser(Guid userId )
        {
            return await _context.WaterReminders.
            Where(water => water.UserId == userId).ToListAsync();
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