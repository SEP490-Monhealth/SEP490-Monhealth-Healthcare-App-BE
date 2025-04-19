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
            }
            #endregion
            );
        }
    }
}
