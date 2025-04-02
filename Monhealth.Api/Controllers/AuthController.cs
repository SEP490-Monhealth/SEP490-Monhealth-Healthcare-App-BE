using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Contracts.Identity;
using Monhealth.Application.Contracts.Phone;
using Monhealth.Application.Models;
using Monhealth.Application.Models.Identity;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Security.Claims;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IOtpService _otpService;
        public AuthController(IAuthService authService, IOtpService otpService)
        {
            _authService = authService;
            _otpService = otpService;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<ResultModel>> Login([FromBody] AuthenRequest request)
        {
            var result = await _authService.Login(request);

            return new ResultModel
            {
                Data = result,
                Message = "Đăng nhập thành công",
                Status = (int)HttpStatusCode.OK,
                Success = true
            };
        }

        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public async Task<ActionResult<ResultModel>> Register([FromBody] RegistrationRequest request)
        {
            await _authService.Register(request);
            return new ResultModel
            {
                Message = "Đăng ký thành công",
                Status = (int)HttpStatusCode.OK,
                Success = true
            };
        }

        [HttpGet]
        [Route("me")]
        [Authorize]
        public async Task<ActionResult<ResultModel>> GetInformationOfUser()
        {
            var phoneNumber = User.FindFirst(ClaimTypes.MobilePhone)?.Value;
            if (phoneNumber == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Message = "Không tìm thấy thông tin người dùng",
                    Status = (int)HttpStatusCode.BadRequest
                };
            }

            var user = await _authService.GetInfomationCurrentUser(phoneNumber);
            return new ResultModel
            {
                Success = true,
                Data = user,
            };
        }

        [HttpPost("logout")]
        public async Task<ActionResult<ResultModel>> Logout()
        {
            await _authService.LogoutAsync();
            return new ResultModel
            {
                Success = true,
                Message = "Đăng xuất thành công"
            };
        }

        [HttpPost("otp-verification")]
        public async Task<IActionResult> SendOtp([FromBody] OtpRequest request)
        {
            try
            {
                var sid = await _otpService.SendOtpAsync(request.PhoneNumber);
                return Ok(new { MessageSid = sid });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult<ResultModel>> RefreshToken([FromBody] TokenDto tokenDto)
        {
            var result = await _authService.RefreshToken(tokenDto);
            return new ResultModel
            {
                Success = true,
                Message = "Cập nhập token thành công",
                Data = result

            };
        }
        public class OtpRequest
        {
            public string PhoneNumber { get; set; }
        }

        public class OtpVerifyRequest
        {
            public string PhoneNumber { get; set; }
            public string Otp { get; set; }
        }
    }
}
