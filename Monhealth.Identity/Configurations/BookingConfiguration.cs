using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);
            var user = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B");

            builder.HasData(
            #region Booking 1
            new Booking
            {
                BookingId = Guid.Parse("776bdd18-a51b-47e8-9a2b-80e5a3c4508c"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-06-15"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = false,
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("15:30:00"),
                Status = BookingStatus.Booked,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-06-15"),
                UpdatedAt = DateTime.Parse("2025-06-15"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 2
            new Booking
            {
                BookingId = Guid.Parse("65e52e15-bab1-44a3-8d44-2d8c576893ca"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-08-17"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = false,
                StartTime = TimeOnly.Parse("08:00:00"),
                EndTime = TimeOnly.Parse("08:30:00"),
                Status = BookingStatus.Booked,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-08-17"),
                UpdatedAt = DateTime.Parse("2025-08-17"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 3
            new Booking
            {
                BookingId = Guid.Parse("55d19add-608b-4917-a01b-51867788698c"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-08-23"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("15:30:00"),
                Status = BookingStatus.Booked,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-08-23"),
                UpdatedAt = DateTime.Parse("2025-08-23"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 4
            new Booking
            {
                BookingId = Guid.Parse("361ed440-ec6c-489f-baba-ec5c753c0fda"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-08-14"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("10:00:00"),
                EndTime = TimeOnly.Parse("10:30:00"),
                Status = BookingStatus.Completed,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-08-14"),
                UpdatedAt = DateTime.Parse("2025-08-14"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 5
            new Booking
            {
                BookingId = Guid.Parse("0ed395d8-58b5-4015-b120-866217233c14"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-06-02"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("15:30:00"),
                Status = BookingStatus.Booked,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-06-02"),
                UpdatedAt = DateTime.Parse("2025-06-02"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 6
            new Booking
            {
                BookingId = Guid.Parse("a799880f-663c-4d78-a5ad-c7aedea8ca2a"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-12-29"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("15:30:00"),
                Status = BookingStatus.Completed,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-12-29"),
                UpdatedAt = DateTime.Parse("2025-12-29"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 7
            new Booking
            {
                BookingId = Guid.Parse("a1076e97-c893-4f8a-baad-be900e28babf"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-01-02"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = false,
                StartTime = TimeOnly.Parse("14:00:00"),
                EndTime = TimeOnly.Parse("14:30:00"),
                Status = BookingStatus.Cancelled,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-01-02"),
                UpdatedAt = DateTime.Parse("2025-01-02"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 8
            new Booking
            {
                BookingId = Guid.Parse("4218c40e-3376-4121-885d-e38b2d2e577b"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-10-11"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = false,
                StartTime = TimeOnly.Parse("09:00:00"),
                EndTime = TimeOnly.Parse("09:30:00"),
                Status = BookingStatus.Cancelled,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-10-11"),
                UpdatedAt = DateTime.Parse("2025-10-11"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 9
            new Booking
            {
                BookingId = Guid.Parse("e4fdd367-e318-4e44-aa96-733f1c6bc852"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-12-20"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = false,
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("15:30:00"),
                Status = BookingStatus.Cancelled,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-12-20"),
                UpdatedAt = DateTime.Parse("2025-12-20"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 10
            new Booking
            {
                BookingId = Guid.Parse("2cff5672-6bfe-4a8d-b602-89429c44ce9e"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-10-17"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = false,
                StartTime = TimeOnly.Parse("09:00:00"),
                EndTime = TimeOnly.Parse("09:30:00"),
                Status = BookingStatus.Booked,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-10-17"),
                UpdatedAt = DateTime.Parse("2025-10-17"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 11
            new Booking
            {
                BookingId = Guid.Parse("450efb98-f509-4e56-b2a0-a9010a4d723b"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-07-08"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("10:00:00"),
                EndTime = TimeOnly.Parse("10:30:00"),
                Status = BookingStatus.Cancelled,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-07-08"),
                UpdatedAt = DateTime.Parse("2025-07-08"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 12
            new Booking
            {
                BookingId = Guid.Parse("f91d1896-2346-428d-853f-55edc8249879"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-07-17"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = false,
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("15:30:00"),
                Status = BookingStatus.Cancelled,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-07-17"),
                UpdatedAt = DateTime.Parse("2025-07-17"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 13
            new Booking
            {
                BookingId = Guid.Parse("3215df6a-49c9-4a30-8d9c-66b2590eb8d4"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-05-02"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("10:00:00"),
                EndTime = TimeOnly.Parse("10:30:00"),
                Status = BookingStatus.Booked,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-05-02"),
                UpdatedAt = DateTime.Parse("2025-05-02"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 14
            new Booking
            {
                BookingId = Guid.Parse("c5ed4b6f-5e11-4f3b-a5e1-0af67a486b43"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-11-27"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = false,
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("15:30:00"),
                Status = BookingStatus.Booked,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-11-27"),
                UpdatedAt = DateTime.Parse("2025-11-27"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 15
            new Booking
            {
                BookingId = Guid.Parse("5281b866-94a3-4842-a314-81c71df46679"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-03-01"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("10:00:00"),
                EndTime = TimeOnly.Parse("10:30:00"),
                Status = BookingStatus.Cancelled,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-03-01"),
                UpdatedAt = DateTime.Parse("2025-03-01"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 16
            new Booking
            {
                BookingId = Guid.Parse("b5395abf-9989-41c4-ad2b-f9d4eadcbf46"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-10-22"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("09:00:00"),
                EndTime = TimeOnly.Parse("09:30:00"),
                Status = BookingStatus.Booked,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-10-22"),
                UpdatedAt = DateTime.Parse("2025-10-22"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 17
            new Booking
            {
                BookingId = Guid.Parse("1112ee1f-e10f-4e16-931d-e8e9016208bc"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-03-13"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("09:00:00"),
                EndTime = TimeOnly.Parse("09:30:00"),
                Status = BookingStatus.Completed,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-03-13"),
                UpdatedAt = DateTime.Parse("2025-03-13"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 18
            new Booking
            {
                BookingId = Guid.Parse("e62b8f6d-fde0-4d08-8fa7-e9eed072e639"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-02-06"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("09:00:00"),
                EndTime = TimeOnly.Parse("09:30:00"),
                Status = BookingStatus.Cancelled,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-02-06"),
                UpdatedAt = DateTime.Parse("2025-02-06"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 19
            new Booking
            {
                BookingId = Guid.Parse("383c081e-d22a-4b2c-8f06-4db1fe11cec6"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-10-11"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("15:30:00"),
                Status = BookingStatus.Completed,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-10-11"),
                UpdatedAt = DateTime.Parse("2025-10-11"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 20
            new Booking
            {
                BookingId = Guid.Parse("d269da28-eef5-4d81-a2af-df3481cfc698"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("122DC7DF-16DE-49A3-AB83-5299686F6203"),
                Day = DateOnly.Parse("2025-11-21"),
                Notes = null,
                CancellationReason = null,
                IsReviewed = true,
                StartTime = TimeOnly.Parse("08:00:00"),
                EndTime = TimeOnly.Parse("08:30:00"),
                Status = BookingStatus.Completed,
                CompletedAt = null,
                CreatedAt = DateTime.Parse("2025-11-21"),
                UpdatedAt = DateTime.Parse("2025-11-21"),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            }
            #endregion
            );
        }
    }
}
