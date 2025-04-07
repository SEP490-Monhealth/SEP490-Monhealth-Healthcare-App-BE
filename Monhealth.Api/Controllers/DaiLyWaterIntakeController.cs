using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/daily-water-intakes")]
    [ApiController]
    public class DailyWaterIntakeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DailyWaterIntakeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("user")]
        [SwaggerOperation(Summary = "Lấy lượng nước hằng ngày theo người dùng")]
        public async Task<ActionResult<ResultModel>> GetDailyWaterIntakeByUser(
            [FromQuery][Required] Guid userId,
            [FromQuery][Required] DateTime date)
        {
            var query = await _mediator.Send(new GetDailyWaterByUserQuery(userId, date));

            if (query == null)
            {
                return Ok(new ResultModel
                {
                    Success = false,
                    Message = "Lượng nước hằng ngày không tồn tại",
                    Status = 200,
                    Data = query
                });
            }

            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = query
            });
        }
    }
}
