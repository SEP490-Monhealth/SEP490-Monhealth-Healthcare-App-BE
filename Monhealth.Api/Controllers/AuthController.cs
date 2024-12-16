using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Contracts.Identity;
using Monhealth.Application.Models;
using Monhealth.Application.Models.Identity;
using System.Net;
using System.Security.Claims;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
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
                Message = "Login successfully",
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
                Message = "Register successfully",
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
            var user = await _authService.GetInfomationCurrentUser(phoneNumber);
            return new ResultModel
            {
                Success = true,
                Data = user,
            };
        }
    }
}
