using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Features.Reminders.Queries.GetAllReminder;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderByUser
{
    public class GetAllReminderByUserQuery :  IRequest<List<GetAllReminderByUserDTO>>
    {
        public Guid UserId { get; set; }
    }
}