using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/userAllergies")]
    [ApiController]
    public class UserAllergyController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserAllergyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> Add([FromBody] CreateUserAllergyRequest request)
        {
            var result = await _mediator.Send(request);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo Dị ứng người dùng thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo dị ứng người dùng thất bại",
                Status = 400,
            });
        }
    }
}