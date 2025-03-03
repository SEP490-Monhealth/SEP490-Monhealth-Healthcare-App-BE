using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class ExpertiseConfiguration : IEntityTypeConfiguration<Expertise>
    {
        public void Configure(EntityTypeBuilder<Expertise> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Expertise 1
            new Expertise
            {
                ExpertiseId = Guid.Parse("7a61f09f-f999-44fd-8973-105e22df1401"),
                ExpertiseName = "Dinh dưỡng lâm sàng",
                CreatedAt = today,
                UpdatedAt = today,
            }
            #endregion
            );
        }
    }
}