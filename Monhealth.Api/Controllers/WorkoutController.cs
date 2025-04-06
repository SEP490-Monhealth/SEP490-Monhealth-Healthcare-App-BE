using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Workout.Commands.ChangeStatusWorkout;
using Monhealth.Application.Features.Workout.Commands.CreateWorkout;
using Monhealth.Application.Features.Workout.Commands.DeleteWorkout;
using Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries;
using Monhealth.Application.Features.Workout.Queries.GetWorkoutByIdQueries;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/workouts")]
    [ApiController]
    public class WorkoutController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách bộ bài tập")]
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
        [SwaggerOperation(Summary = "Lấy thông tin bộ bài tập theo ID")]
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

        // [HttpGet("user/{userId:guid}")]
        // public async Task<ActionResult<ResultModel>> GetWorkoutByUserId([FromRoute] Guid userId)
        // {
        //     var workouts = await mediator.Send(new GetWorkoutByUserIdQuery(userId));

        //     return new ResultModel
        //     {
        //         Data = workouts,
        //         Status = 200,
        //         Success = true,
        //     };
        // }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo mới bộ bài tập")]
        public async Task<ActionResult<ResultModel>> CreateWorkout([FromBody] CreateWorkoutCommand command)
        {
            var result = await mediator.Send(command);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo bộ bài tập thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo bộ bài tập thất bại",
                Status = 400,
            });
        }

        [HttpPut]
        [Route("{workoutId:Guid}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin bộ bài tập")]
        public async Task<ActionResult<ResultModel>> UpdateWorkout(Guid workoutId, [FromBody] UpdateWorkoutRequest request)
        {
            var command = new UpdateWorkoutHandler(workoutId, request);
            var result = await mediator.Send(command);
            if (result == null)
                return new ResultModel
                {
                    Message = "Cập nhật bộ bài tập thất bại",
                    Success = false,
                    Data = null
                };
            return Ok(new ResultModel
            {
                Message = "Cập nhật bộ bài tập thành công",
                Success = true,
                Status = 204,
            });
        }

        [HttpDelete("{workoutId}")]
        [SwaggerOperation(Summary = "Xóa bộ bài tập")]
        public async Task<ActionResult<ResultModel>> DeleteWorkout(Guid workoutId)
        {
            var command = new DeleteWorkoutCommand { WorkoutId = workoutId };
            var delete = await mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy bộ bài tập"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa workout thành công"
            };
        }

        [HttpPatch("{workoutId}/status")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái bộ bài tập")]
        public async Task<ActionResult<ResultModel>> ChangeStatusWorkout(Guid workoutId)
        {
            var command = new ChangeStatusWorkoutCommand { WorkoutId = workoutId };
            var changeStatus = await mediator.Send(command);
            if (!changeStatus)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy bộ bài tập"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật trạng thái bộ bài tập thành công"
            };
        }
    }
}
