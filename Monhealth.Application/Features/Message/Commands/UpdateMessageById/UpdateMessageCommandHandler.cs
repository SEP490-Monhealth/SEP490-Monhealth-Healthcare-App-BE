using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Message.Commands.UpdateMessageById
{
    public class UpdateMessageCommandHandler(IMessageRepository messageRepository) : IRequestHandler<UpdateMessageCommand, bool>
    {
        public async Task<bool> Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
        {
            string content = request.UpdateMessageDto.Content.Trim();
            if (string.IsNullOrEmpty(content)) throw new BadRequestException("Nội dung không hợp lệ");
            var message = await messageRepository.GetByIdAsync(request.MessageId);
            message.Content = content;
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
