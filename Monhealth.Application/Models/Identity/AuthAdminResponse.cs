namespace Monhealth.Application.Models.Identity
{
    public class AuthAdminResponse
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
        public required DateTime? ExpiredAt { get; set; }
    }
}
