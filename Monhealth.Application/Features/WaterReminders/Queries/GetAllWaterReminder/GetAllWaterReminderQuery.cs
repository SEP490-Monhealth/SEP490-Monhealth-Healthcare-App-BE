using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Reminders.Queries.GetAllReminder
{
    public class GetAllReminderQuery : IRequest<PageResult<ReminderDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public bool? Recurring { get; set; }
        public bool? Status { get; set; }

    }
}