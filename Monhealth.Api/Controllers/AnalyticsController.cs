using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/analytics")]
    [ApiController]
    public class AnalyticController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AnalyticController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("users/summary")]
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

        [HttpGet("users/subscriptions")]
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

        [HttpGet("users/registrations")]
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

        [HttpGet("overview")]
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