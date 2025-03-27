using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.ScheduleException.Commands.CreateScheduleException
{
    public class CreateScheduleExceptionCommandHandler(IMapper mapper, IScheduleExceptionRepository scheduleExceptionRepository) : IRequestHandler<CreateScheduleExceptionCommand, Unit>
    {
        public async Task<Unit> Handle(CreateScheduleExceptionCommand request, CancellationToken cancellationToken)
        {
            var scheduleException = mapper.Map<Domain.ScheduleException>(request);
            scheduleExceptionRepository.Add(scheduleException);

            await scheduleExceptionRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
