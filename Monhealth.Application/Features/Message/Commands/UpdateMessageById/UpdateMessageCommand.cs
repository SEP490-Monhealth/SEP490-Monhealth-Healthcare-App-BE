using MediatR;

namespace Monhealth.Application.Features.Message.Commands.UpdateMessageById
{
    public class UpdateMessageCommand : IRequest<bool>
    {
        public Guid MessageId { get; set; }
        public UpdateMessageDto UpdateMessageDto { get; set; }

        public UpdateMessageCommand(Guid messageId, UpdateMessageDto message)
        {
            MessageId = messageId;
            UpdateMessageDto = message;
        }


    }
}
