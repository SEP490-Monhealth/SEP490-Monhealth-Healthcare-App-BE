using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.ScheduleException.Commands.CreateScheduleException
{
    public class CreateScheduleExceptionCommandHandler(IMapper mapper,
        IScheduleExceptionRepository scheduleExceptionRepository,
        IBookingRepository bookingRepository
        )
        : IRequestHandler<CreateScheduleExceptionCommand, Unit>
    {
        public async Task<Unit> Handle(CreateScheduleExceptionCommand request, CancellationToken cancellationToken)
        {
            var scheduleException = mapper.Map<Domain.ScheduleException>(request);

            var bookings = await bookingRepository.GetBookingsByConsultantIdAndDate((Guid)request.ConsultantId, request.Date);
            if (bookings == null || !bookings.Any())
            {
                scheduleException.Status = ScheduleExceptionStatus.Approved;
            }
            scheduleExceptionRepository.Add(scheduleException);
            await scheduleExceptionRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
