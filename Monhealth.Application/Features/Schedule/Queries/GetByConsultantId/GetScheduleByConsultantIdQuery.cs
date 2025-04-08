using System.Text.Json.Serialization;
using MediatR;
using Monhealth.Application.Features.Schedule.Queries.GetAll;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Queries.GetByUser
{
    public class GetScheduleByConsultantIdQuery : IRequest<List<ScheduleDTO>>
    {
        public Guid ConsultantId { get; set; }
        [JsonPropertyName("type")]
        public ScheduleType? ScheduleType { get; set; }
        public DateTime? Date { get; set; }
    }
}