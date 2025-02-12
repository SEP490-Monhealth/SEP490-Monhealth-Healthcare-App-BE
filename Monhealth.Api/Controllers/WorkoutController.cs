using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Workout.Commands.CreateWorkout;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/workouts")]
    [ApiController]
    public class WorkoutController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateWorkout([FromBody] CreateWorkoutCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo bài tập thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo bài tập thất bại",
                Status = 400,
            });
        }
    }
}
