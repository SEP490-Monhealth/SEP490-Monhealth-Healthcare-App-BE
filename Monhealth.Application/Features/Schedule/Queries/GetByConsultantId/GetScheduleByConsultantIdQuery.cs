using MediatR;
using Monhealth.Application.Features.Schedule.Queries.GetAll;

namespace Monhealth.Application.Features.Schedule.Queries.GetByUser
{
    public class GetScheduleByConsultantIdQuery : IRequest<List<ScheduleDTO>>
    {
        public Guid ConsultantId { get; set; }
        public DateTime? Date { get; set; }
    }
}