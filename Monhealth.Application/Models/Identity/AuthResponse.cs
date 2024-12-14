namespace Monhealth.Application.Models.Identity
{
    public class AuthResponse
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
        public required DateTime? ExpiredAt { get; set; }
    }
}
