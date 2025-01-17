using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Reminders.Queries.GetAllReminder
{
    public class GetAllReminderQueryHandler : IRequestHandler<GetAllReminderQuery, List<ReminderDTo>>
    {
        private readonly IWaterReminderRepository _reminderRepository;
        private readonly IMapper _mapper;

        public GetAllReminderQueryHandler(IWaterReminderRepository reminderRepository,
        IMapper mapper)
        {
            _reminderRepository = reminderRepository;
            _mapper = mapper;
        }

        public async Task<List<ReminderDTo>> Handle(GetAllReminderQuery request, CancellationToken cancellationToken)
        {
            var query = await _reminderRepository.GetAllReminderAsync();
            return _mapper.Map<List<ReminderDTo>>(query);
        }
    }
}