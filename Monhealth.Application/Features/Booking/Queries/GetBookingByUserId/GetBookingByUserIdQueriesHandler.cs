using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantIdMonthly;
using Monhealth.Application.Models.Paging;


namespace Monhealth.Application.Features.Booking.Queries.GetBookingByUserId
{
    public class GetBookingByUserIdQueriesHandler(IMapper mapper, IBookingRepository bookingRepository, IReportRepository reportRepository) :
     IRequestHandler<GetBookingByUserIdQueries, PageResult<BookingDto>>
    {
        public async Task<PageResult<BookingDto>> Handle(GetBookingByUserIdQueries request, CancellationToken cancellationToken)
        {
            var bookings = await bookingRepository.GetBookingByUserId(request.UserId , request.Page, request.Limit);

            var bookingDtos = mapper.Map<List<BookingDto>>(bookings.Items);

            var bookingId = bookingDtos.Select(b => b.BookingId).ToList();

            var reportedBookingIds = await reportRepository.GetReportedBookingIdsAsync(bookingId);

            bookingDtos.ForEach(dto => dto.IsReported = reportedBookingIds.Contains(dto.BookingId));

            return new PageResult<BookingDto>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(bookings.TotalCount / (double)request.Limit),
                TotalItems = bookings.TotalCount,
                Items = bookingDtos
            };
        }
    }
}
