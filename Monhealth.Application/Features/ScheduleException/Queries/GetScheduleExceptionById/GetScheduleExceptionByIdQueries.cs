using MediatR;
using Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionById
{
    public class GetScheduleExceptionByIdQueries : IRequest<ScheduleExceptionDto>
    {
        public Guid ExceptionId { get; set; }
    }
}
