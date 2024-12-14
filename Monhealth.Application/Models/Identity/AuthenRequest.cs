namespace Monhealth.Application.Models.Identity
{
    public class AuthenRequest
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
