using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.User.Queries.GetAllUser
{
    public class GetAllUserQuery : IRequest<PageResult<UserDto>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public string? Role { get; set; }
        public string? Sort { get; set; }
        public string? Order { get; set; }
        public bool? Status { get; set; }
    }
}
