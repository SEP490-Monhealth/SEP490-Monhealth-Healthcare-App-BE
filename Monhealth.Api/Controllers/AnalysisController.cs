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
        [HttpGet("users/total-accounts")]
        [SwaggerOperation(Summary = "Lấy tổng số account của user")]
        public async Task<ActionResult<ResultModel>> GetTotalAccountOfUsersAnalysis()
        {
            List<TotalAmountDTO> result = await _mediator.Send(new TotalAccountAmountQuery());

            return Ok(new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            });
        }
        [HttpGet("dashboard/overview")]
        [SwaggerOperation(Summary = "Lấy độ tăng trưởng")]
        public async Task<ActionResult<ResultModel>> GetTotalAnalysis()
        {
            TotalAmountAnalysisDTO result = await _mediator.Send(new TotalAmountAnalysisQuery());

            return Ok(new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            });
        }
    }
}