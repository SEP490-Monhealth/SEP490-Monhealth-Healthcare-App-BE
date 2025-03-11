using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class TimeSlotConfiguration : IEntityTypeConfiguration<TimeSlot>
    {
        public void Configure(EntityTypeBuilder<TimeSlot> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region TimeSlot 1
            new TimeSlot
            {
                TimeSlotId = Guid.NewGuid(),
                StartTime = TimeOnly.Parse("08:00:00"),
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region TimeSlot 2
            new TimeSlot
            {
                TimeSlotId = Guid.NewGuid(),
                StartTime = TimeOnly.Parse("09:00:00"),
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region TimeSlot 3
            new TimeSlot
            {
                TimeSlotId = Guid.NewGuid(),
                StartTime = TimeOnly.Parse("10:00:00"),
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region TimeSlot 4
            new TimeSlot
            {
                TimeSlotId = Guid.NewGuid(),
                StartTime = TimeOnly.Parse("11:00:00"),
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region TimeSlot 5
            new TimeSlot
            {
                TimeSlotId = Guid.NewGuid(),
                StartTime = TimeOnly.Parse("14:00:00"),
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region TimeSlot 6
            new TimeSlot
            {
                TimeSlotId = Guid.NewGuid(),
                StartTime = TimeOnly.Parse("15:00:00"),
                CreatedAt = today,
                UpdatedAt = today,
            },
            #endregion

            #region TimeSlot 7
            new TimeSlot
            {
                TimeSlotId = Guid.NewGuid(),
                StartTime = TimeOnly.Parse("16:00:00"),
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion
            );
        }
    }
}
