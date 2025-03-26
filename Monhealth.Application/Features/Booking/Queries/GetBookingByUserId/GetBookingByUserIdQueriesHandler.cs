using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByUserId
{
    public class GetBookingByUserIdQueriesHandler(IMapper mapper, IBookingRepository bookingRepository) : IRequestHandler<GetBookingByUserIdQueries, List<BookingDto>>
    {
        public async Task<List<BookingDto>> Handle(GetBookingByUserIdQueries request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetBookingByUserId(request.UserId);
            return mapper.Map<List<BookingDto>>(booking);
        }
    }
}
