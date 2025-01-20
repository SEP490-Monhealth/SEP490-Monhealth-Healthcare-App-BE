using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.User.Queries.GetAllUser
{
    public class UserDto : BaseEntity
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? AvatarUrl { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
    }
}
