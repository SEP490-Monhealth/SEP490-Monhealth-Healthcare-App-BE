using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Booking.Commands.CreateBooking
{
    public class CreateBookingCommandHandler(IMapper mapper, IBookingRepository bookingRepository
    , IConsultantRepository consultantRepository) : IRequestHandler<CreateBookingCommand, Unit>
    {
        public async Task<Unit> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var consultant = await consultantRepository.GetConsultantById(request.ConsultantId);

            if (consultant != null)
            {
                consultant.BookingCount++; 
                consultantRepository.Update(consultant);
                await consultantRepository.SaveChangeAsync(cancellationToken); 
            }
            var booking = new Domain.Booking
            {
                BookingId = Guid.NewGuid(),
                UserId = request.UserId,
                ConsultantId = request.ConsultantId,
                Day = request.Day,
                Notes = request.Notes
            };


            bookingRepository.Add(booking);
            await bookingRepository.SaveChangeAsync(cancellationToken);

            return Unit.Value; 
        }

    }
}
