
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
               TimeSlotId = Guid.Parse("8a0f1db6-8007-487d-96e3-67e49f697767"),
               StartTime = TimeOnly.Parse("08:00:00"),
               CreatedAt = today,
               UpdatedAt = today,
           },
            #endregion

            #region TimeSlot 2
           new TimeSlot
           {
               TimeSlotId = Guid.Parse("c366221c-1be4-4ffe-9271-e1357f3cf8e3"),
               StartTime = TimeOnly.Parse("09:00:00"),
               CreatedAt = today,
               UpdatedAt = today,
           },
            #endregion

            #region TimeSlot 3
           new TimeSlot
           {
               TimeSlotId = Guid.Parse("6ad5f232-ddec-44c0-bae5-b977bd46a3bd"),
               StartTime = TimeOnly.Parse("10:00:00"),
               CreatedAt = today,
               UpdatedAt = today,
           },
            #endregion

            #region TimeSlot 4
           new TimeSlot
           {
               TimeSlotId = Guid.Parse("8affe245-30a2-4164-ad48-7d3032fa91df"),
               StartTime = TimeOnly.Parse("11:00:00"),
               CreatedAt = today,
               UpdatedAt = today,
           },
            #endregion

            #region TimeSlot 5
           new TimeSlot
           {
               TimeSlotId = Guid.Parse("54da261e-ad94-4bd8-a696-82f77c47fc1f"),
               StartTime = TimeOnly.Parse("14:00:00"),
               CreatedAt = today,
               UpdatedAt = today,
           },
            #endregion

            #region TimeSlot 6
           new TimeSlot
           {
               TimeSlotId = Guid.Parse("cf1c96eb-0193-49b7-9813-23c1d9646e5e"),
               StartTime = TimeOnly.Parse("15:00:00"),
               CreatedAt = today,
               UpdatedAt = today,
           },
            #endregion

            #region TimeSlot 7
           new TimeSlot
           {
               TimeSlotId = Guid.Parse("b8b71edc-d48b-44ea-9dc3-b7d214c582c1"),
               StartTime = TimeOnly.Parse("16:00:00"),
               CreatedAt = today,
               UpdatedAt = today,
           }
           #endregion
           );
        }
    }
}
