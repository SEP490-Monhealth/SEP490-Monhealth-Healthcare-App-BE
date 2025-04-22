using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException
{
    public class ScheduleExceptionDto : BaseEntity
    {
        public Guid ScheduleExceptionId { get; set; }
        public Guid? ConsultantId { get; set; }
        public DateOnly Date { get; set; }
        public string? Reason { get; set; }
        public ConsultantForGetAllScheduleExceptionDTO? Consultant { get; set; }
        public ScheduleExceptionStatus Status { get; set; }
    }
    public class ConsultantForGetAllScheduleExceptionDTO
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        [JsonPropertyName("avatarUrl")]
        public string? Avatar { get; set; }
    }
}
