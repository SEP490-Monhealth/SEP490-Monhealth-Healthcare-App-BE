using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;

namespace Monhealth.Application
{
    public class GetAllBookingByConsultantAndUser : IRequest<List<BookingDto>>
    {
        public Guid UserId { get; set; }
        public Guid ConsultantId { get; set; }
    }

    public class GetAllBookingByConsultantAndUserQueryHandler(IBookingRepository bookingRepository
    , IMapper mapper , ILogger<GetAllBookingByConsultantAndUserQueryHandler> _logger)
     : IRequestHandler<GetAllBookingByConsultantAndUser, List<BookingDto>>
    {
        public async Task<List<BookingDto>> Handle(GetAllBookingByConsultantAndUser request, CancellationToken cancellationToken)
        {
            var queries = await bookingRepository.GetBookingByUserAndConsultant(request.UserId, request.ConsultantId);
            if (queries == null || !queries.Any())
            {
                _logger.LogWarning($"No bookings found for UserId: {request.UserId}, ConsultantId: {request.ConsultantId}");
            }
            else
            {
                _logger.LogInformation($"Found {queries.Count} bookings for UserId: {request.UserId}, ConsultantId: {request.ConsultantId}");
            }
            return mapper.Map<List<BookingDto>>(queries);

        }
    }
}