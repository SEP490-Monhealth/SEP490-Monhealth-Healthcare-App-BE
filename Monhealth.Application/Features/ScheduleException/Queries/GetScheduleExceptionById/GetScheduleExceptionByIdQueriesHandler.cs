using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionById
{
    public class GetScheduleExceptionByIdQueriesHandler(IScheduleExceptionRepository scheduleExceptionRepository, IMapper mapper) : IRequestHandler<GetScheduleExceptionByIdQueries, ScheduleExceptionDto>
    {
        public async Task<ScheduleExceptionDto> Handle(GetScheduleExceptionByIdQueries request, CancellationToken cancellationToken)
        {
            var scheduleException = await scheduleExceptionRepository.GetScheduleExceptionByIdAsync(request.ScheduleExceptionId);
            if (scheduleException == null) throw new BadRequestException("Không tìm thấy lịch bận");
            return mapper.Map<ScheduleExceptionDto>(scheduleException);
        }
    }
}
