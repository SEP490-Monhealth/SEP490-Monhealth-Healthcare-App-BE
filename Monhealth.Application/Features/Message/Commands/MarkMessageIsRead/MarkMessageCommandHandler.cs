using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Message.Commands.MarkMessageIsRead
{
    public class MarkMessageCommandHandler(IMessageRepository messageRepository) : IRequestHandler<MarkMessageCommand, bool>
    {
        public async Task<bool> Handle(MarkMessageCommand request, CancellationToken cancellationToken)
        {
            var message = await messageRepository.GetByIdAsync(request.MessageId);
            if (message == null) throw new BadRequestException("Không tìm thấy tin nhắn");
            message.IsRead = true;
            message.UpdatedAt = GetCurrentVietnamTime();
            await messageRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
