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

            // Toàn
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
            },
            #endregion


            // Đại
            #region Metric 7
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                DateOfBirth = DateTime.ParseExact("26-10-2002", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 54,
                ActivityLevel = 1.375f,
                Bmi = 18.68512f,
                Bmr = 1502.5f,
                Tdee = 2065.9375f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
            },
            #endregion

            // Khải
            #region Metric 8
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                DateOfBirth = DateTime.ParseExact("15-05-2003", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 54,
                ActivityLevel = 1.375f,
                Bmi = 18.68512f,
                Bmr = 1502.5f,
                Tdee = 2065.9375f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
            },
            #endregion

            // Duy
            #region Metric 9
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                DateOfBirth = DateTime.ParseExact("15-02-2002", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 54,
                ActivityLevel = 1.375f,
                Bmi = 18.68512f,
                Bmr = 1502.5f,
                Tdee = 2065.9375f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
            },
            #endregion

            // Khanh
            #region Metric 10
            new Metric
            {
                MetricId = Guid.NewGuid(),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                DateOfBirth = DateTime.ParseExact("11-09-2002", "dd-MM-yyyy", null),
                Gender = Gender.Male,
                Height = 170,
                Weight = 54,
                ActivityLevel = 1.375f,
                Bmi = 18.68512f,
                Bmr = 1502.5f,
                Tdee = 2065.9375f,
                Ibw = 66.01601f,
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
            }
            #endregion

            );
        }
    }
}
