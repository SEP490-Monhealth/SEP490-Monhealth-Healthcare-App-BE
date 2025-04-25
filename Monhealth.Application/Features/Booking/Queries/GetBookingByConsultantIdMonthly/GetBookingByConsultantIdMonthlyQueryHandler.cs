using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantIdMonthly
{
    public class GetBookingByConsultantIdMonthlyQueryHandler(IBookingRepository bookingRepository, IReportRepository reportRepository, IMapper mapper) : IRequestHandler<GetBookingByConsultantIdMonthlyQuery, PageResult<GetBookingByConsultantIdMonthlyDTO>>
    {
        public async Task<PageResult<GetBookingByConsultantIdMonthlyDTO>> Handle(GetBookingByConsultantIdMonthlyQuery request, CancellationToken cancellationToken)
        {
            var monthValue = request.Month ?? DateTime.UtcNow;
            // xac dinh ngay dau tien va ngay cuoi cung cua thang
            var startDate = new DateTime(monthValue.Year, monthValue.Month, 1); 
            var endDate = startDate.AddMonths(1).AddTicks(-1); 

            // Lấy danh sách bookings theo ConsultantId và phạm vi ngày (startDate đến endDate)
            var bookings = await bookingRepository.GetBookingByConsultantIdMonthly(
                request.Page,
                request.Limit,
                request.ConsultantId,
                startDate,
                endDate
            );

            //var bookingDtos = mapper.Map<List<GetBookingByConsultantIdMonthlyDTO>>(bookings.Items);
            var bookingDtos = mapper.Map<List<GetBookingByConsultantIdMonthlyDTO>>(bookings.Items);

            var bookingId = bookingDtos.Select(b => b.BookingId).ToList();

            var reportedBookingIds = await reportRepository.GetReportedBookingIdsAsync(bookingId);

            bookingDtos.ForEach(dto => dto.IsReported = reportedBookingIds.Contains(dto.BookingId));


            return new PageResult<GetBookingByConsultantIdMonthlyDTO>()
            {
                Items = bookingDtos,
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(bookings.TotalCount / (double)request.Limit),
                TotalItems = bookings.TotalCount,
            };
        }
    }
}
