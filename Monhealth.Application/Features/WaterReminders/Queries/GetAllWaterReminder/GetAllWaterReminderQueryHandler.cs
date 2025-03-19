using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Reminders.Queries.GetAllReminder
{
    public class GetAllReminderQueryHandler : IRequestHandler<GetAllReminderQuery, PageResult<ReminderDTO>>
    {
        private readonly IWaterReminderRepository _reminderRepository;
        private readonly IMapper _mapper;

        public GetAllReminderQueryHandler(IWaterReminderRepository reminderRepository,
        IMapper mapper)
        {
            _reminderRepository = reminderRepository;
            _mapper = mapper;
        }

        public async Task<PageResult<ReminderDTO>> Handle(GetAllReminderQuery request, CancellationToken cancellationToken)
        {
            var reminderPaging = await _reminderRepository.GetAllReminderAsync(request.Page, request.Limit, request.Search, request.Recurring, request.Status);

            return new PageResult<ReminderDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(reminderPaging.TotalCount / (double)request.Limit),
                TotalItems = reminderPaging.TotalCount,
                Items = _mapper.Map<List<ReminderDTO>>(reminderPaging.Items)
            };
        }
    }
}