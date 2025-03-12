using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Schedule 1
            new Schedule
            {
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 2
            new Schedule
            {
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3
            new Schedule
            {
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4
            new Schedule
            {
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 5
            new Schedule
            {
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 6
            new Schedule
            {
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 7
            new Schedule
            {
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sun,
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion
            );
        }
    }
}
