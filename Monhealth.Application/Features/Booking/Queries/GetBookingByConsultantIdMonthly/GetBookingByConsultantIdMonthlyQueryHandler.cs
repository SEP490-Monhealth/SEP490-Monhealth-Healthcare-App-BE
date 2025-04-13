using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantIdMonthly
{
    public class GetBookingByConsultantIdMonthlyQueryHandler(IBookingRepository bookingRepository, IMapper mapper) : IRequestHandler<GetBookingByConsultantIdMonthlyQuery, PageResult<GetBookingByConsultantIdMonthlyDTO>>
    {
        public async Task<PageResult<GetBookingByConsultantIdMonthlyDTO>> Handle(GetBookingByConsultantIdMonthlyQuery request, CancellationToken cancellationToken)
        {
            var monthValue = request.Month ?? DateTime.Now;
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

            var bookingDtos = mapper.Map<List<GetBookingByConsultantIdMonthlyDTO>>(bookings.Items);

            return new PageResult<GetBookingByConsultantIdMonthlyDTO>()
            {
                Items = mapper.Map<List<GetBookingByConsultantIdMonthlyDTO>>(bookings.Items),
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(bookings.TotalCount / (double)request.Limit),
                TotalItems = bookings.TotalCount,
            };
        }
    }
}
