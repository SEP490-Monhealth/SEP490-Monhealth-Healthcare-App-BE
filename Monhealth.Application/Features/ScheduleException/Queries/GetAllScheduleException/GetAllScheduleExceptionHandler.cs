using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException
{
    public class GetAllScheduleExceptionHandler(IScheduleExceptionRepository scheduleExceptionRepository, IMapper mapper) : IRequestHandler<GetAllScheduleExceptionQueries, IEnumerable<ScheduleExceptionDto>>
    {
        public async Task<IEnumerable<ScheduleExceptionDto>> Handle(GetAllScheduleExceptionQueries request, CancellationToken cancellationToken)
        {
            var scheduleExceptions = await scheduleExceptionRepository.GetAllAsync();
            return mapper.Map<List<ScheduleExceptionDto>>(scheduleExceptions);
        }
    }
}
