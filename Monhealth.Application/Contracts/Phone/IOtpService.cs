namespace Monhealth.Application.Contracts.Phone
{
    public interface IOtpService
    {
        Task<string> SendOtpAsync(string phoneNumber);
        Task<bool> VerifyOtpAsync(string phoneNumber, string otp);
    }
}
