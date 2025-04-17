using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderByUser
{
    public class GetAllReminderByUserHandler : IRequestHandler<GetAllReminderByUserQuery, List<GetAllReminderByUserDTO>>
    {
        private readonly IWaterReminderRepository _reminderRepository;
        private readonly IMapper _mapper;
        public GetAllReminderByUserHandler(IWaterReminderRepository reminderRepository,
        IMapper mapper)
        {
            _reminderRepository = reminderRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllReminderByUserDTO>> Handle(GetAllReminderByUserQuery request, CancellationToken cancellationToken)
        {
            var userId = await _reminderRepository.GetReminderByUser(request.UserId , request.Status);
            return _mapper.Map<List<GetAllReminderByUserDTO>>(userId);
        }
    }
}