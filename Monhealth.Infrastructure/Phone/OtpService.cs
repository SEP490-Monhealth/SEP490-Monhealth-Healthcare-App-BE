using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Phone;
using Monhealth.Application.Models.Phone;
using Monhealth.Identity.Models;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

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
        }
        public async Task<string> SendOtpAsync(string phoneNumber)
        {
            //var user = await _userManager.Users.SingleOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
            //if (user == null)
            //    throw new Exception("User not found.");

            //string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            //string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
            //string phoneNumber = Environment.GetEnvironmentVariable("PhoneNumber");

            TwilioClient.Init(_twilioSettings.AccountSID, _twilioSettings.AuthToken);


            var message = await MessageResource.CreateAsync(
                body: "This is the ship that made the Kessel Run in fourteen parsecs?",
                from: new Twilio.Types.PhoneNumber(_twilioSettings.PhoneNumber),
                to: new Twilio.Types.PhoneNumber("+84937056922"));

            Console.WriteLine(message);

            return message.Sid; // Return the message SID for tracking        
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
