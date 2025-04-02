using MediatR;

namespace Monhealth.Application.Features.Message.Queries.GetAllMessages
{
    public class GetAllMessageQueries : IRequest<List<MessageDto>>
    {

    }
}
