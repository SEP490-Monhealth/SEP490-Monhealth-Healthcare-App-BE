using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantId
{
    public class GetByConsultantIdQueriesHandler(IMapper mapper, IBookingRepository bookingRepository, IReportRepository reportRepository) : IRequestHandler<GetByConsultantIdQueries, PageResult<BookingDto>>
    {
        public async Task<PageResult<BookingDto>> Handle(GetByConsultantIdQueries request, CancellationToken cancellationToken)
        {
            var bookings = await bookingRepository.GetBookingByConsultantId(request.ConsultantId, request.Page, request.Limit, request.Date);

            var bookingDtos = mapper.Map<List<BookingDto>>(bookings);

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
