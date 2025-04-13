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
        [HttpGet("users/user-subscription-six-months")]
        [SwaggerOperation(Summary = "Lấy tổng số gói đăng ký theo 6 tháng")]
        public async Task<ActionResult<ResultModel>> GetUserSixMonthUsers()
        {
            List<GetAllUserSubscriptionBySixMonthsDTO> result = await _mediator.Send(new GetAllUserSubscriptionBySixMonthQuery());

            return Ok(new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            });
        }
        [HttpGet("users/user-six-months")]
        [SwaggerOperation(Summary = "Lấy cumulative số lượng member theo 6 tháng")]
        public async Task<ActionResult<ResultModel>> GetSixMonthUsersAnalysis()
        {
            List<GetAllMemberBySixMonthsDTO> result = await _mediator.Send(new GetAllMemberBySixMonthsQuery());

            return Ok(new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            });
        }
    }
}