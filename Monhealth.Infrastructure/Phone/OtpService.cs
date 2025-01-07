using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Phone;
using Monhealth.Application.Models.Phone;
using Monhealth.Identity.Models;
using Twilio;
using Twilio.Rest.Verify.V2.Service;

namespace Monhealth.Infrastructure.Phone
{
    public class OtpService : IOtpService
    {
        private readonly TwilioSettings _twilioSettings;
        private readonly UserManager<AppUser> _userManager;
        public OtpService(TwilioSettings twilioSettings, UserManager<AppUser> userManager)
        {
            _twilioSettings = twilioSettings;
            _userManager = userManager;
            TwilioClient.Init(_twilioSettings.AccountSID, _twilioSettings.AuthToken);
        }
        public async Task<string> SendOtpAsync(string phoneNumber)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
            if (user == null)
                throw new Exception("User not found.");

            var otp = new Random().Next(100000, 999999).ToString();
            user.SecurityStamp = otp; // Save OTP temporarily in the database
            await _userManager.UpdateAsync(user);

            var verification = await VerificationResource.CreateAsync(
            to: "+84937056922",
            channel: "sms",
            pathServiceSid: "VAa402caa012c1f366f5401aca0431d017");

            return verification.Sid; // Return the message SID for tracking        
        }

        public async Task<bool> VerifyOtpAsync(string phoneNumber, string otp)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
            if (user == null)
                return false;

            if (user.SecurityStamp == otp)
            {
                user.SecurityStamp = Guid.NewGuid().ToString(); // Clear OTP
                await _userManager.UpdateAsync(user);
                return true;
            }

            return false;
        }
    }
}
