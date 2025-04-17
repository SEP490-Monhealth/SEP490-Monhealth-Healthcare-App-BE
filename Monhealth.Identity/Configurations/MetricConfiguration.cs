using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class MetricConfiguration : IEntityTypeConfiguration<Metric>
    {
        public void Configure(EntityTypeBuilder<Metric> builder)
        {
            builder.HasData(

            #region Metric 1
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("06114384-3057-49ea-b106-e03c0e0e8f20"),
                DateOfBirth = DateTime.ParseExact("27-08-2003", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 50,
                ActivityLevel = 1.375f,
                Bmi = 17.3f,
                Bmr = 1462.5f,
                Tdee = 2010.938f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("24-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("24-04-2025", "dd-MM-yyyy", null),
            }
            #endregion
            );
        }
    }
}
