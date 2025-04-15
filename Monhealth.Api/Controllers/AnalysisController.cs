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