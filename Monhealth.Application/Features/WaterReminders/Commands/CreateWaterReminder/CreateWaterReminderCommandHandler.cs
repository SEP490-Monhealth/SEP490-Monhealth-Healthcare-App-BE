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
            var model = new Monhealth.Domain.WaterReminder
            {
                UserId = request.UserId,
                WaterReminderName = request.WaterReminderName,
                Time = request.Time,
                Volume = request.Volume,
                IsRecurring = request.IsRecurring,
                IsDrunk = false,
                Status = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            _reminderRepository.Add(model);
            await _reminderRepository.SaveChangeAsync();
            return Unit.Value;

        }
    }
}