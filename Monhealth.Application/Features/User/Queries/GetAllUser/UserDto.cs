namespace Monhealth.Application.Features.User.Queries.GetAllUser
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Avatar { get; set; }
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
