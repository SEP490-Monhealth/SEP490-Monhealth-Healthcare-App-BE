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
            await messageRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
