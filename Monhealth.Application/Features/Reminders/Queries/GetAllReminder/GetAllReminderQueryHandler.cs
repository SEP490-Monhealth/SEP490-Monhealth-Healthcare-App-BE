using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Reminders.Queries.GetAllReminder
{
    public class GetAllReminderQueryHandler : IRequestHandler<GetAllReminderQuery, List<ReminderDTo>>
    {
        private readonly IReminderRepository _reminderRepository;

        public GetAllReminderQueryHandler(IReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }

        public Task<List<ReminderDTo>> Handle(GetAllReminderQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}