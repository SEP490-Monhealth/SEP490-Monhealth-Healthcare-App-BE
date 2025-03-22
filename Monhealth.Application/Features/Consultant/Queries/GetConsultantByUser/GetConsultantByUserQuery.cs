using MediatR;

namespace Monhealth.Application
{
    public class GetConsultantByUserQuery : IRequest<GetConsultantByUserDTO>
    {
           public Guid UserId { get; set; }
    }
}