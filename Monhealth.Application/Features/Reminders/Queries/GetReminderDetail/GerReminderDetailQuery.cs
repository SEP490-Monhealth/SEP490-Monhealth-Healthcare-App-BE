using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderDetail
{
    public class GerReminderDetailQuery : IRequest<ReminderDetailDTO>
    {
        public Guid ReminderId { get; set; }
    }
}