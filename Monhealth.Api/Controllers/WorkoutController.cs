using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Workout.Commands.CreateWorkout;
using Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries;
using Monhealth.Application.Features.Workout.Queries.GetWorkoutByIdQueries;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/workouts")]
    [ApiController]
    public class WorkoutController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllWorkouts(int page = 1, int limit = 10, string? category = null, string? search = null, DifficultyLevel? difficulty = null, bool? popular = null, bool? status = null)
        {
            var workouts = await mediator.Send(new GetAllWorkoutQuery(page, limit, category, search, difficulty, popular, status));

            return new ResultModel
            {
                Data = workouts,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("{workoutId:guid}")]
        public async Task<ActionResult<ResultModel>> GetWorkoutById([FromRoute] Guid workoutId)
        {
            var workouts = await mediator.Send(new GetWorkoutByIdQuery(workoutId));

            return new ResultModel
            {
                Data = workouts,
                Status = 200,
                Success = true,
            };
        }
        [HttpPut]
        [Route("{workoutId:Guid}")]
        public async Task<ActionResult<ResultModel>> UpdateWorkout(Guid workoutId, [FromBody] UpdateWorkoutRequest request)
        {
            var command = new UpdateWorkoutHandler(workoutId, request);
            var result = await mediator.Send(command);
            if (result == null )
                return new ResultModel
                {
                    Message = "Cập nhật bài tập thất bại",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật bài tập thành công",
                Success = true,
                Status = 204,
            });
        }

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
