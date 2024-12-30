namespace Monhealth.Application.Models.Identity
{
    public class JwtTokenSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public int ExpireInDays { get; set; }
    }
}
