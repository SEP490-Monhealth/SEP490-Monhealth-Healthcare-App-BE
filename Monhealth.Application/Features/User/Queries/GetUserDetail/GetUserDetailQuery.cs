using MediatR;

namespace Monhealth.Application.Features.User.Queries.GetUserDetail
{
    public class GetUserDetailQuery : IRequest<UserDetailDto>
    {
        public Guid Id { get; set; }
    }
}
