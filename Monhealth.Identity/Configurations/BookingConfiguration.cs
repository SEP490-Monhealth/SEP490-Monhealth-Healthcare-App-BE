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
            builder.HasData(

            #region Booking 1
            new Booking
            {
                BookingId = Guid.Parse("2816BE7A-00E3-4ACC-B7CB-28CA8F9FDD84"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("A0385565-B5F4-4AD3-915E-B95558C00F7D"),
                Day = DateOnly.Parse("2025-05-01"),
                Notes = "toi muon dat lich booking",
                StartTime = TimeOnly.Parse("16:15:00"),
                EndTime = TimeOnly.Parse("17:15:00"),
                MeetingUrl = "https://meet.google.com/svv-ekkz-boz",
                EvidenceUrls = [],
                CancellationReason = null,
                IsReviewed = false,
                CompletedAt = null,
                Status = BookingStatus.Booked,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 2
            new Booking
            {
                BookingId = Guid.Parse("9C347A04-4581-4F92-BCB0-64C421E3EEE2"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("0A9DAD22-7B87-408B-A377-71DBBE004ABC"),
                Day = DateOnly.Parse("2025-05-04"),
                Notes = "toi muon duoc tu van ve auc khoe tong quat",
                StartTime = TimeOnly.Parse("09:15:00"),
                EndTime = TimeOnly.Parse("10:15:00"),
                MeetingUrl = "https://meet.google.com/tyn-vafz-asn",
                EvidenceUrls = [],
                CancellationReason = null,
                IsReviewed = false,
                CompletedAt = null,
                Status = BookingStatus.Booked,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            },
            #endregion

            #region Booking 3
            new Booking
            {
                BookingId = Guid.Parse("D203CDA3-84D8-4B38-A09B-15975005EA82"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = Guid.Parse("6BCE17D4-909F-4FAD-B125-0074793F22BD"),
                Day = DateOnly.Parse("2025-05-09"),
                Notes = "toi muon tap the hinh",
                StartTime = TimeOnly.Parse("15:00:00"),
                EndTime = TimeOnly.Parse("16:00:00"),
                MeetingUrl = "https://meet.google.com/sfn-wpjg-fzp",
                EvidenceUrls = [],
                CancellationReason = null,
                IsReviewed = false,
                CompletedAt = null,
                Status = BookingStatus.Booked,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            }
            #endregion
            );
        }
    }
}
