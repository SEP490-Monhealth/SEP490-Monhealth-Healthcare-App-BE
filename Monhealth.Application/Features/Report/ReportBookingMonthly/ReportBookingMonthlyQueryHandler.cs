using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.ReportBookingMonthly
{
    public class ReportBookingMonthlyQueryHandler(IBookingRepository bookingRepository) : IRequestHandler<ReportBookingMonthlyQuery, List<ReportBookingMonthlyDTO>>
    {
        public async Task<List<ReportBookingMonthlyDTO>> Handle(ReportBookingMonthlyQuery request, CancellationToken cancellationToken)
        {
            // tinh 6 thang = 5 thang truoc + 1 thang hien tai
            var targetMonth = new DateTime(request.Date.Year, request.Date.Month, 1);
            var months = Enumerable.Range(-5, 6)
                .Select(o => targetMonth.AddMonths(o))
                .ToList();

            var fromDate = months.First();
            var toDate = months.Last().AddMonths(1); // loai tru cuoi thang

            var bookings = await bookingRepository.GetBookingsByConsultantAndDateRange(
                request.ConsultantId,
                fromDate,
                toDate
            );

            // Gom nhom theo thang
            var bookingGrouped = bookings
                .GroupBy(b => new { b.Day.Year, b.Day.Month })
                .ToDictionary(
                    g => $"{g.Key.Year}-{g.Key.Month:D2}",
                    g => g.Count()
                );

            var result = months.Select(month => new ReportBookingMonthlyDTO
            {
                Month = month.ToString("yyyy-MM"),
                Bookings = bookingGrouped.TryGetValue(month.ToString("yyyy-MM"), out var count) ? count : 0
            }).ToList();

            return result;
        }
    }
}
