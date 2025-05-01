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
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                DateOfBirth = DateTime.ParseExact("27-08-2003", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 50,
                ActivityLevel = 1.375f,
                Bmi = 17.301037f,
                Bmr = 1462.5f,
                Tdee = 2010.9375f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Metric 2
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                DateOfBirth = DateTime.ParseExact("27-08-2003", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 51,
                ActivityLevel = 1.375f,
                Bmi = 17.647058f,
                Bmr = 1472.5f,
                Tdee = 2024.6875f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("05-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("05-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Metric 3
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                DateOfBirth = DateTime.ParseExact("27-08-2003", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 53,
                ActivityLevel = 1.375f,
                Bmi = 18.3391f,
                Bmr = 1492.5f,
                Tdee = 2052.1875f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("12-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("12-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Metric 4
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                DateOfBirth = DateTime.ParseExact("27-08-2003", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 54,
                ActivityLevel = 1.375f,
                Bmi = 18.68512f,
                Bmr = 1502.5f,
                Tdee = 2065.9375f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("19-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Metric 5
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                DateOfBirth = DateTime.ParseExact("27-08-2003", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 52,
                ActivityLevel = 1.375f,
                Bmi = 17.993078f,
                Bmr = 1482.5f,
                Tdee = 2038.4375f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("26-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("26-04-2025", "dd-MM-yyyy", null),
            },
            #endregion

            #region Metric 6
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                DateOfBirth = DateTime.ParseExact("27-08-2003", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 52,
                ActivityLevel = 1.375f,
                Bmi = 17.993078f,
                Bmr = 1482.5f,
                Tdee = 2038.4375f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
            }
            #endregion
            );
        }
    }
}
