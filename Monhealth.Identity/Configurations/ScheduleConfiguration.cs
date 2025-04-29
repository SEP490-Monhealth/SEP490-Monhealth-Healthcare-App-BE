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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
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
            },
            #endregion

            #region Schedule 3-1
            new Schedule
            {
                ScheduleId = Guid.Parse("28a0bd9c-3143-419e-8f7c-dcc9ecf4b8c3"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-2
            new Schedule
            {
                ScheduleId = Guid.Parse("e07fbf18-d636-4433-9d6f-a36b042edcb7"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-3
            new Schedule
            {
                ScheduleId = Guid.Parse("b0ad1eef-d237-4f59-8632-0efd095adbce"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-4
            new Schedule
            {
                ScheduleId = Guid.Parse("ec332031-64e2-4075-b9f8-0bc1deb48a17"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-5
            new Schedule
            {
                ScheduleId = Guid.Parse("8078c630-1553-49e0-8bdf-6a49da058595"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-6
            new Schedule
            {
                ScheduleId = Guid.Parse("87e6c204-ffa4-4554-a75c-cc45d1daf6f4"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 3-7
            new Schedule
            {
                ScheduleId = Guid.Parse("b949934b-eee3-44a8-ab4a-41090e71ead1"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sun,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-1
            new Schedule
            {
                ScheduleId = Guid.Parse("763e5b18-8368-4204-86bd-5753a29b8d08"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Mon,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-2
            new Schedule
            {
                ScheduleId = Guid.Parse("399d0071-c3dd-4703-a10f-30dc1b00e114"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Tue,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-3
            new Schedule
            {
                ScheduleId = Guid.Parse("2f316ea1-fce9-43fb-b364-e82bf918026d"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Wed,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-4
            new Schedule
            {
                ScheduleId = Guid.Parse("076a615b-d38a-4a00-95ef-527b0f1fb798"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Thu,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-5
            new Schedule
            {
                ScheduleId = Guid.Parse("82cd38dc-7c55-4bf8-91e3-0c4c5999c031"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Fri,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-6
            new Schedule
            {
                ScheduleId = Guid.Parse("e5f419f3-c744-40a7-8b32-f71418a6d2b4"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                ScheduleType = ScheduleType.Recurring,
                RecurringDay = RecurringDay.Sat,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region Schedule 4-7
            new Schedule
            {
                ScheduleId = Guid.Parse("4c824b7e-7be6-4c41-8c14-84654d00a3b9"),
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
