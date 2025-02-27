using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByUserId
{
    public class GetBookingByUserIdQueriesHandler(IMapper mapper, IBookingRepository bookingRepository) : IRequestHandler<GetBookingByUserIdQueries, GetBookingByUserIdDto>
    {
        public async Task<GetBookingByUserIdDto> Handle(GetBookingByUserIdQueries request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetBookingByUserId(request.UserId);
            if (booking == null) throw new BadRequestException("Không tìm thấy lịch hẹn với người dùng này");
            return mapper.Map<GetBookingByUserIdDto>(booking);
        }
    }
}
