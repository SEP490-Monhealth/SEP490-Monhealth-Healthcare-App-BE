using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class WaterReminderConfiguration : IEntityTypeConfiguration<WaterReminder>
    {
        public void Configure(EntityTypeBuilder<WaterReminder> builder)
        {
            var userId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Water Reminder 1
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = userId,
                WaterReminderName = "Nhắc nhở 1",
                Time = "07:00",
                Volume = 273.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Water Reminder 2
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = userId,
                WaterReminderName = "Nhắc nhở 2",
                Time = "09:00",
                Volume = 182.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Water Reminder 3
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = userId,
                WaterReminderName = "Nhắc nhở 3",
                Time = "11:00",
                Volume = 182.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Water Reminder 4
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = userId,
                WaterReminderName = "Nhắc nhở 4",
                Time = "13:00",
                Volume = 273.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Water Reminder 5
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = userId,
                WaterReminderName = "Nhắc nhở 5",
                Time = "15:30",
                Volume = 273.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Water Reminder 6
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = userId,
                WaterReminderName = "Nhắc nhở 6",
                Time = "17:00",
                Volume = 273.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Water Reminder 7
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = userId,
                WaterReminderName = "Nhắc nhở 7",
                Time = "19:30",
                Volume = 182.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Water Reminder 8
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = userId,
                WaterReminderName = "Nhắc nhở 8",
                Time = "21:00",
                Volume = 182.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            }
            #endregion
            );
        }
    }
}
