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
            message.UpdatedAt = DateTime.Now;
            await messageRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
