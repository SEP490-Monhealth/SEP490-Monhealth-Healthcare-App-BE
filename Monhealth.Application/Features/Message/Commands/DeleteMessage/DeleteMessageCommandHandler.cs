using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Message.Commands.DeleteMessage
{
    public class DeleteMessageCommandHandler(IMessageRepository messageRepository) : IRequestHandler<DeleteMessageCommand, bool>
    {
        public async Task<bool> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
        {
            var message = await messageRepository.GetByIdAsync(request.MessageId);
            if (message == null) throw new BadRequestException($"Không tìm thấy tin nhắn {request.MessageId}");
            messageRepository.Remove(message);
            await messageRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
