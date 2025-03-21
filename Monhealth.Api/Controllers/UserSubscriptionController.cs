using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/UserSubscriptions")]
    [ApiController]
    public class UserSubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserSubscriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserSubscription(Guid userId)
        {
            var result = await _mediator.Send(new GetUserSubScriptionQuery() { UserId = userId });
            if (result == null)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                };
            }
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllUserSubscription(int page = 1, int limit = 10)
        {
            var result = await _mediator.Send(new GetAllUserSubscriptionQuery(page, limit));
            return new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            };

        }


    }
}