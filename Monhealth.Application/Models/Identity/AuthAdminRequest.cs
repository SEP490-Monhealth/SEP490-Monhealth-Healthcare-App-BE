namespace Monhealth.Application.Models.Identity
{
    public class AuthAdminRequest
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
