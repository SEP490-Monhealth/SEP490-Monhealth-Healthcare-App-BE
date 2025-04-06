using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/daily-activities")]
    [ApiController]
    public class DailyActivityController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [Route("user")]
        [SwaggerOperation(Summary = "Lấy hoạt động hằng ngày theo người dùng")]
        public async Task<ActionResult<ResultModel>> GetDailyActivityByUserId([FromQuery][Required] Guid userId,
         [FromQuery][Required] DateTime date)
        {
            var queries = await mediator.Send(new GetDailyActivityByUserIdQuery(userId, date));

            if (queries == null)
            {
                return Ok(new ResultModel
                {
                    Success = false,
                    Message = "Hoạt động hằng ngày không tồn tại",
                    Status = 200,
                    Data = queries
                });
            }

            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }
    }
}
