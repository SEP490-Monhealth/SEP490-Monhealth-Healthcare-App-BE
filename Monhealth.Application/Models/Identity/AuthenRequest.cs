namespace Monhealth.Application.Models.Identity
{
    public class AuthenRequest
    {
        public required string PhoneNumber { get; set; }
        public required string Password { get; set; }
    }
}
