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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sun,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 2-1
            new Schedule
            {
                ScheduleId = Guid.Parse("79370315-ebc7-49e3-b408-9f882e925d0b"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 2-2
            new Schedule
            {
                ScheduleId = Guid.Parse("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 2-3
            new Schedule
            {
                ScheduleId = Guid.Parse("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 2-4
            new Schedule
            {
                ScheduleId = Guid.Parse("1b7d907f-1f57-42bf-8c26-1d870f2159ea"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 2-5
            new Schedule
            {
                ScheduleId = Guid.Parse("a089c869-6406-4007-8bfb-8098c02cde67"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 2-6
            new Schedule
            {
                ScheduleId = Guid.Parse("21515171-04ee-46dc-b978-07bf7d01896d"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 2-7
            new Schedule
            {
                ScheduleId = Guid.Parse("68f7dc95-0090-4b7f-a044-5ff48ecf313c"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
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
