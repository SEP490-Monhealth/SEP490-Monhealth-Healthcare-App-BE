using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class ScheduleTimeSlotConfiguration : IEntityTypeConfiguration<ScheduleTimeSlot>
    {
        public void Configure(EntityTypeBuilder<ScheduleTimeSlot> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region ScheduleTimeSlot 1-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 1-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 1-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 1-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 1-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 1-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ddcb76f3-e4a2-4ee3-a90c-44792a2c023d"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("17e9439c-fc1c-4309-bbac-2a0a2eab2a7d"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("5b988823-2ed9-4835-a0ae-f73c125f589a"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("afb3cb6e-3844-49e6-aa7f-d40a819fd7ca"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 5-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 5-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 5-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 5-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 5-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 5-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2794c45b-08fb-428c-b863-37059ef29d1f"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 6-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 6-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 6-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 6-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 6-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("7640d26b-ea65-4901-b9fc-e78bed626fcb"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 7-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 7-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 7-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion
            );
        }
    }
}
