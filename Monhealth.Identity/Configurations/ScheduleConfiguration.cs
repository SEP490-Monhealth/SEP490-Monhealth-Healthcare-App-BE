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

            #region Schedule 1-1
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

            #region Schedule 1-2
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

            #region Schedule 1-3
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

            #region Schedule 1-4
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

            #region Schedule 1-5
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

            #region Schedule 1-6
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

            #region Schedule 1-7
            new Schedule
            {
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sun,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 2-1
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

            #region Schedule 2-2
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

            #region Schedule 2-3
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

            #region Schedule 2-4
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

            #region Schedule 2-5
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

            #region Schedule 2-6
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

            #region Schedule 2-7
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

            #region Schedule 3-1
            new Schedule
            {
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-2
            new Schedule
            {
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-3
            new Schedule
            {
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-4
            new Schedule
            {
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-5
            new Schedule
            {
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-6
            new Schedule
            {
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-7
            new Schedule
            {
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sun,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-1
            new Schedule
            {
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-2
            new Schedule
            {
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-3
            new Schedule
            {
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-4
            new Schedule
            {
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-5
            new Schedule
            {
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-6
            new Schedule
            {
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-7
            new Schedule
            {
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sun,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 5-1
            new Schedule
            {
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 5-2
            new Schedule
            {
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 5-3
            new Schedule
            {
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 5-4
            new Schedule
            {
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 5-5
            new Schedule
            {
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 5-6
            new Schedule
            {
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 5-7
            new Schedule
            {
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sun,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 6-1
            new Schedule
            {
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 6-2
            new Schedule
            {
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 6-3
            new Schedule
            {
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 6-4
            new Schedule
            {
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 6-5
            new Schedule
            {
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 6-6
            new Schedule
            {
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 6-7
            new Schedule
            {
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sun,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 7-1
            new Schedule
            {
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 7-2
            new Schedule
            {
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 7-3
            new Schedule
            {
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 7-4
            new Schedule
            {
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 7-5
            new Schedule
            {
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 7-6
            new Schedule
            {
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 7-7
            new Schedule
            {
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sun,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 8-1
            new Schedule
            {
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 8-2
            new Schedule
            {
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 8-3
            new Schedule
            {
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 8-4
            new Schedule
            {
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 8-5
            new Schedule
            {
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 8-6
            new Schedule
            {
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 8-7
            new Schedule
            {
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
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
