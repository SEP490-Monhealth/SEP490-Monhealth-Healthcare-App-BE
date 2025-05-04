using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class WaterReminderConfiguration : IEntityTypeConfiguration<WaterReminder>
    {
        public void Configure(EntityTypeBuilder<WaterReminder> builder)
        {
            var admin = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6");

            builder.HasData(

            #region Water Reminder 1
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = admin,
                WaterReminderName = "Nhắc nhở 1",
                Time = "07:00",
                Volume = 273.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Water Reminder 2
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = admin,
                WaterReminderName = "Nhắc nhở 2",
                Time = "09:00",
                Volume = 182.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Water Reminder 3
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = admin,
                WaterReminderName = "Nhắc nhở 3",
                Time = "11:00",
                Volume = 182.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Water Reminder 4
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = admin,
                WaterReminderName = "Nhắc nhở 4",
                Time = "13:00",
                Volume = 273.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Water Reminder 5
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = admin,
                WaterReminderName = "Nhắc nhở 5",
                Time = "15:30",
                Volume = 273.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Water Reminder 6
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = admin,
                WaterReminderName = "Nhắc nhở 6",
                Time = "17:00",
                Volume = 273.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Water Reminder 7
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = admin,
                WaterReminderName = "Nhắc nhở 7",
                Time = "19:30",
                Volume = 182.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Water Reminder 8
            new WaterReminder
            {
                WaterReminderId = Guid.NewGuid(),
                UserId = admin,
                WaterReminderName = "Nhắc nhở 8",
                Time = "21:00",
                Volume = 182.0f,
                IsRecurring = true,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            }
            #endregion
            );
        }
    }
}
