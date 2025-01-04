using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderDetail
{
    public class GetReminderDetailQueryHandler : IRequestHandler<GerReminderDetailQuery, ReminderDetailDTO>
    {
        private readonly IReminderRepository _reminderRepository;
        private readonly IMapper _mapper;

        public GetReminderDetailQueryHandler(IReminderRepository reminderRepository,
        IMapper mapper)
        {
            _reminderRepository = reminderRepository;
            _mapper = mapper;
        }

        public async Task<ReminderDetailDTO> Handle(GerReminderDetailQuery request, CancellationToken cancellationToken)
        {
            var query = await _reminderRepository.GetReminderById(request.ReminderId);
            return _mapper.Map<ReminderDetailDTO>(query);
        }
    }
}