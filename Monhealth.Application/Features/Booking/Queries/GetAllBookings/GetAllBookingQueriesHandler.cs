using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Booking.Queries.GetAllBookings
{
    public class GetAllBookingQueriesHandler(IMapper mapper, IBookingRepository bookingRepository, IReportRepository reportRepository) : IRequestHandler<GetAllBookingQueries, PageResult<BookingDto>>
    {
        public async Task<PageResult<BookingDto>> Handle(GetAllBookingQueries request, CancellationToken cancellationToken)
        {
            var pagingBooking = await bookingRepository.GetAllBookingAsync(
                request.Page, request.Limit, request.Search, request.Status);

            var bookingDtos = mapper.Map<List<BookingDto>>(pagingBooking.Items);

            var bookingId = bookingDtos.Select(b => b.BookingId).ToList();

            var reportedBookingIds = await reportRepository.GetReportedBookingIdsAsync(bookingId);

            bookingDtos.ForEach(dto => dto.IsReported = reportedBookingIds.Contains(dto.BookingId));
            return new PageResult<BookingDto>()
            {
                Items = bookingDtos,
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(pagingBooking.TotalCount / (double)request.Limit),
                TotalItems = pagingBooking.TotalCount,
            };
        }
    }
}
