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

            #region ScheduleTimeSlot 1-1-1
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

            #region ScheduleTimeSlot 1-1-2
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

            #region ScheduleTimeSlot 1-1-3
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

            #region ScheduleTimeSlot 1-1-4
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

            #region ScheduleTimeSlot 1-1-5
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

            #region ScheduleTimeSlot 1-1-6
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

            #region ScheduleTimeSlot 1-2-1
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

            #region ScheduleTimeSlot 1-2-2
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

            #region ScheduleTimeSlot 1-2-3
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

            #region ScheduleTimeSlot 1-2-4
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

            #region ScheduleTimeSlot 1-2-5
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

            #region ScheduleTimeSlot 1-2-6
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

            #region ScheduleTimeSlot 1-3-1
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

            #region ScheduleTimeSlot 1-3-2
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

            #region ScheduleTimeSlot 1-3-3
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

            #region ScheduleTimeSlot 1-3-4
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

            #region ScheduleTimeSlot 1-3-5
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

            #region ScheduleTimeSlot 1-3-6
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

            #region ScheduleTimeSlot 1-4-1
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

            #region ScheduleTimeSlot 1-4-2
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

            #region ScheduleTimeSlot 1-4-3
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

            #region ScheduleTimeSlot 1-4-4
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

            #region ScheduleTimeSlot 1-4-5
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

            #region ScheduleTimeSlot 1-4-6
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

            #region ScheduleTimeSlot 1-5-1
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

            #region ScheduleTimeSlot 1-5-2
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

            #region ScheduleTimeSlot 1-5-3
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

            #region ScheduleTimeSlot 1-5-4
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

            #region ScheduleTimeSlot 1-5-5
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

            #region ScheduleTimeSlot 1-5-6
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

            #region ScheduleTimeSlot 1-6-1
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

            #region ScheduleTimeSlot 1-6-2
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

            #region ScheduleTimeSlot 1-6-3
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

            #region ScheduleTimeSlot 1-6-4
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

            #region ScheduleTimeSlot 1-6-5
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

            #region ScheduleTimeSlot 1-7-1
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

            #region ScheduleTimeSlot 1-7-2
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

            #region ScheduleTimeSlot 1-7-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("02d9b5f6-5fdd-4f07-a9a0-ff468d661c05"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-1-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("79370315-ebc7-49e3-b408-9f882e925d0b"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-1-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("79370315-ebc7-49e3-b408-9f882e925d0b"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-1-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("79370315-ebc7-49e3-b408-9f882e925d0b"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-1-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("79370315-ebc7-49e3-b408-9f882e925d0b"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-1-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("79370315-ebc7-49e3-b408-9f882e925d0b"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-1-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("79370315-ebc7-49e3-b408-9f882e925d0b"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-2-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-2-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-2-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-2-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-2-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-2-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ca3d30fe-255b-4bbe-bb7f-1c9f1d12a579"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-3-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-3-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-3-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-3-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-3-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-3-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2a0c644a-83b2-4cc9-8d2e-2b17877303e3"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-4-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("1b7d907f-1f57-42bf-8c26-1d870f2159ea"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-4-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("1b7d907f-1f57-42bf-8c26-1d870f2159ea"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-4-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("1b7d907f-1f57-42bf-8c26-1d870f2159ea"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-4-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("1b7d907f-1f57-42bf-8c26-1d870f2159ea"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-4-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("1b7d907f-1f57-42bf-8c26-1d870f2159ea"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-4-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("1b7d907f-1f57-42bf-8c26-1d870f2159ea"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-5-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("a089c869-6406-4007-8bfb-8098c02cde67"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-5-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("a089c869-6406-4007-8bfb-8098c02cde67"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-5-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("a089c869-6406-4007-8bfb-8098c02cde67"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-5-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("a089c869-6406-4007-8bfb-8098c02cde67"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-5-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("a089c869-6406-4007-8bfb-8098c02cde67"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-5-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("a089c869-6406-4007-8bfb-8098c02cde67"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-6-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("21515171-04ee-46dc-b978-07bf7d01896d"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-6-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("21515171-04ee-46dc-b978-07bf7d01896d"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-6-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("21515171-04ee-46dc-b978-07bf7d01896d"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-6-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("21515171-04ee-46dc-b978-07bf7d01896d"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-6-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("21515171-04ee-46dc-b978-07bf7d01896d"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-7-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("68f7dc95-0090-4b7f-a044-5ff48ecf313c"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-7-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("68f7dc95-0090-4b7f-a044-5ff48ecf313c"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 2-7-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("68f7dc95-0090-4b7f-a044-5ff48ecf313c"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-1-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("28a0bd9c-3143-419e-8f7c-dcc9ecf4b8c3"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-1-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("28a0bd9c-3143-419e-8f7c-dcc9ecf4b8c3"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-1-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("28a0bd9c-3143-419e-8f7c-dcc9ecf4b8c3"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-1-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("28a0bd9c-3143-419e-8f7c-dcc9ecf4b8c3"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-1-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("28a0bd9c-3143-419e-8f7c-dcc9ecf4b8c3"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-1-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("28a0bd9c-3143-419e-8f7c-dcc9ecf4b8c3"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-2-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e07fbf18-d636-4433-9d6f-a36b042edcb7"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-2-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e07fbf18-d636-4433-9d6f-a36b042edcb7"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-2-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e07fbf18-d636-4433-9d6f-a36b042edcb7"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-2-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e07fbf18-d636-4433-9d6f-a36b042edcb7"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-2-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e07fbf18-d636-4433-9d6f-a36b042edcb7"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-2-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e07fbf18-d636-4433-9d6f-a36b042edcb7"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-3-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("b0ad1eef-d237-4f59-8632-0efd095adbce"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-3-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("b0ad1eef-d237-4f59-8632-0efd095adbce"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-3-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("b0ad1eef-d237-4f59-8632-0efd095adbce"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-3-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("b0ad1eef-d237-4f59-8632-0efd095adbce"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-3-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("b0ad1eef-d237-4f59-8632-0efd095adbce"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-3-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("b0ad1eef-d237-4f59-8632-0efd095adbce"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-4-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ec332031-64e2-4075-b9f8-0bc1deb48a17"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-4-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ec332031-64e2-4075-b9f8-0bc1deb48a17"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-4-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ec332031-64e2-4075-b9f8-0bc1deb48a17"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-4-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ec332031-64e2-4075-b9f8-0bc1deb48a17"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-4-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ec332031-64e2-4075-b9f8-0bc1deb48a17"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-4-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("ec332031-64e2-4075-b9f8-0bc1deb48a17"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-5-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("8078c630-1553-49e0-8bdf-6a49da058595"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-5-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("8078c630-1553-49e0-8bdf-6a49da058595"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-5-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("8078c630-1553-49e0-8bdf-6a49da058595"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-5-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("8078c630-1553-49e0-8bdf-6a49da058595"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-5-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("8078c630-1553-49e0-8bdf-6a49da058595"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-5-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("8078c630-1553-49e0-8bdf-6a49da058595"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-6-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("87e6c204-ffa4-4554-a75c-cc45d1daf6f4"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-6-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("87e6c204-ffa4-4554-a75c-cc45d1daf6f4"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-6-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("87e6c204-ffa4-4554-a75c-cc45d1daf6f4"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-6-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("87e6c204-ffa4-4554-a75c-cc45d1daf6f4"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-6-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("87e6c204-ffa4-4554-a75c-cc45d1daf6f4"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-7-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("b949934b-eee3-44a8-ab4a-41090e71ead1"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-7-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("b949934b-eee3-44a8-ab4a-41090e71ead1"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 3-7-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("b949934b-eee3-44a8-ab4a-41090e71ead1"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-1-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("763e5b18-8368-4204-86bd-5753a29b8d08"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-1-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("763e5b18-8368-4204-86bd-5753a29b8d08"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-1-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("763e5b18-8368-4204-86bd-5753a29b8d08"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-1-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("763e5b18-8368-4204-86bd-5753a29b8d08"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-1-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("763e5b18-8368-4204-86bd-5753a29b8d08"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-1-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("763e5b18-8368-4204-86bd-5753a29b8d08"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-2-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("399d0071-c3dd-4703-a10f-30dc1b00e114"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-2-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("399d0071-c3dd-4703-a10f-30dc1b00e114"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-2-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("399d0071-c3dd-4703-a10f-30dc1b00e114"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-2-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("399d0071-c3dd-4703-a10f-30dc1b00e114"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-2-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("399d0071-c3dd-4703-a10f-30dc1b00e114"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-2-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("399d0071-c3dd-4703-a10f-30dc1b00e114"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-3-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2f316ea1-fce9-43fb-b364-e82bf918026d"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-3-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2f316ea1-fce9-43fb-b364-e82bf918026d"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-3-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2f316ea1-fce9-43fb-b364-e82bf918026d"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-3-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2f316ea1-fce9-43fb-b364-e82bf918026d"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-3-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2f316ea1-fce9-43fb-b364-e82bf918026d"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-3-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("2f316ea1-fce9-43fb-b364-e82bf918026d"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-4-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("076a615b-d38a-4a00-95ef-527b0f1fb798"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-4-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("076a615b-d38a-4a00-95ef-527b0f1fb798"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-4-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("076a615b-d38a-4a00-95ef-527b0f1fb798"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-4-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("076a615b-d38a-4a00-95ef-527b0f1fb798"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-4-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("076a615b-d38a-4a00-95ef-527b0f1fb798"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-4-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("076a615b-d38a-4a00-95ef-527b0f1fb798"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-5-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("82cd38dc-7c55-4bf8-91e3-0c4c5999c031"),
                TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-5-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("82cd38dc-7c55-4bf8-91e3-0c4c5999c031"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-5-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("82cd38dc-7c55-4bf8-91e3-0c4c5999c031"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-5-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("82cd38dc-7c55-4bf8-91e3-0c4c5999c031"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-5-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("82cd38dc-7c55-4bf8-91e3-0c4c5999c031"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-5-6
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("82cd38dc-7c55-4bf8-91e3-0c4c5999c031"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-6-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e5f419f3-c744-40a7-8b32-f71418a6d2b4"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-6-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e5f419f3-c744-40a7-8b32-f71418a6d2b4"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-6-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e5f419f3-c744-40a7-8b32-f71418a6d2b4"),
                TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-6-4
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e5f419f3-c744-40a7-8b32-f71418a6d2b4"),
                TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-6-5
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("e5f419f3-c744-40a7-8b32-f71418a6d2b4"),
                TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-7-1
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("4c824b7e-7be6-4c41-8c14-84654d00a3b9"),
                TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-7-2
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("4c824b7e-7be6-4c41-8c14-84654d00a3b9"),
                TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region ScheduleTimeSlot 4-7-3
            new ScheduleTimeSlot
            {
                ScheduleTimeSlotId = Guid.NewGuid(),
                ScheduleId = Guid.Parse("4c824b7e-7be6-4c41-8c14-84654d00a3b9"),
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
