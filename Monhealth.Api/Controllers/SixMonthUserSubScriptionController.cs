using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/six-month-subscriptions")]
    [ApiController]
    public class SixMonthUserSubScriptionController : ControllerBase
    {
        private readonly IMediator mediator;

        public SixMonthUserSubScriptionController(IMediator _mediator)
        {
            mediator = _mediator;
        }

        // [HttpGet("users")]
        // [SwaggerOperation(Summary = "Lấy tổng số gói đăng ký theo 6 tháng")]
        // public async Task<ActionResult<ResultModel>> GetSixMonthUsers()
        // {
        //     List<GetAllUserSubscriptionBySixMonthsDTO> result = await mediator.Send(new GetAllUserSubscriptionBySixMonthQuery());

        //     return Ok(new ResultModel
        //     {
        //         Data = result,
        //         Status = 200,
        //         Success = true
        //     });
        // }
    }
}