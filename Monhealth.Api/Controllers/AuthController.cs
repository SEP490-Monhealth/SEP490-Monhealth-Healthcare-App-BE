using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Contracts.Identity;
using Monhealth.Application.Models;
using Monhealth.Application.Models.Identity;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/[controller]")]
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
    }
}
