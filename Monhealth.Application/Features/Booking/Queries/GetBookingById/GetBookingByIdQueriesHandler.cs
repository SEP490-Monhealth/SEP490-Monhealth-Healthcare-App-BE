using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingById
{
    public class GetBookingByIdQueriesHandler(IMapper mapper, IBookingRepository bookingRepository, IReportRepository reportRepository) : IRequestHandler<GetBookingByIdQueries, BookingDto>
    {
        public async Task<BookingDto> Handle(GetBookingByIdQueries request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetBookingByBookingIdAsync(request.BookingId);

            if (booking == null)
            {
                return null;
            }

            var bookingDto = mapper.Map<BookingDto>(booking);

            var isReported = await reportRepository.GetReportedBookingIdsAsync(new List<Guid> { request.BookingId });

            bookingDto.IsReported = isReported.Contains(request.BookingId);

            return bookingDto;

            //return mapper.Map<BookingDto>(booking);
        }
    }
}
