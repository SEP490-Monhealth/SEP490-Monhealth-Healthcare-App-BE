using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{

    [Route("api/v1/analysis")]
    [ApiController]
    public class AnalysisController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AnalysisController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("users")]
        [SwaggerOperation(Summary = "Lấy tỷ lệ tăng trưởng của user đăng ký vào hệ thống")]
        public async Task<ActionResult<ResultModel>> GetSixMonthUsers()
        {
            AnalysisUserDTO result = await _mediator.Send(new AnalysisUserQuery());

            return Ok(new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            });
        }
    }
}