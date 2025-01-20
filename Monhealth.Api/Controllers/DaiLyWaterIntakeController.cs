using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/daily-water-intakes")]
    [ApiController]
    public class DaiLyWaterIntakeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DaiLyWaterIntakeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("user")]
        public async Task<ActionResult<ResultModel>> GetDailyWaterIntakeByUser([FromQuery][Required] Guid userId,
         [FromQuery][Required] DateTime date)
        {
            var queries = await _mediator.
            Send(new GetDailyWaterByUserQuery(userId, date));

            if (queries == null)
            {
                return Ok(new ResultModel
                {
                    Success = false,
                    Message = "DailyWater không tồn tại",
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