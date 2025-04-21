using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/six-month-users")]
    [ApiController]
    public class SixMonthUserApi : ControllerBase
    {
        private readonly IMediator mediator;

        public SixMonthUserApi(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // [HttpGet("users")]
        // [SwaggerOperation(Summary = "Lấy cumulative số lượng member theo 6 tháng")]
        // public async Task<ActionResult<ResultModel>> GetSixMonthUsers()
        // {
        //     List<GetAllMemberBySixMonthsDTO> result = await mediator.Send(new GetAllMemberBySixMonthsQuery());

        //     return Ok(new ResultModel
        //     {
        //         Data = result,
        //         Status = 200,
        //         Success = true
        //     });
        // }
    }
}