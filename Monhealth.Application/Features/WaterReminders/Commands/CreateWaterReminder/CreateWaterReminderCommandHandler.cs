using MediatR;
using Monhealth.Application.Contracts.Persistence;
namespace Monhealth.Application.Features.Reminder.Commands.CreateReminder
{
    public class CreateWaterReminderCommandHandler : IRequestHandler<CreateWaterReminderCommand, Unit>
    {
        private readonly IWaterReminderRepository _reminderRepository;

        public CreateWaterReminderCommandHandler(IWaterReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }

        public async Task<Unit> Handle(CreateWaterReminderCommand request, CancellationToken cancellationToken)
        {
            var existingReminder = await _reminderRepository.GetByUserIdAndTimeAsync(request.UserId, request.Time);
            if (existingReminder != null)
            {
                throw new InvalidOperationException("Đã tồn tại một nhắc nhở uống nước với cùng thời gian cho người dùng này.");
            }
            var model = new Domain.WaterReminder
            {
                UserId = request.UserId,
                WaterReminderName = request.WaterReminderName,
                Time = request.Time,
                Volume = request.Volume,
                IsRecurring = request.IsRecurring,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            _reminderRepository.Add(model);
            await _reminderRepository.SaveChangeAsync();
            return Unit.Value;

        }
    }
}