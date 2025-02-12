using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Exercise.Commands.ChangeStatusExercise;
using Monhealth.Application.Features.Exercise.Commands.CreateExercise;
using Monhealth.Application.Features.Exercise.Commands.DeleteExercise;
using Monhealth.Application.Features.Exercise.Commands.UpdateExercise;
using Monhealth.Application.Features.Exercise.Queries.GetAllExercises;
using Monhealth.Application.Features.Exercise.Queries.GetExerciseById;
using Monhealth.Application.Features.Exercise.Queries.GetExerciseByUserId;
using Monhealth.Application.Features.Exercise.Queries.GetExerciseByWorkoutId;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/exercises")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExerciseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllExercise(int page = 1, int limit = 10, string? search = null, ExerciseType? type = default, bool? status = null)
        {
            var exerciseList = await _mediator.Send(new GetAllExercisesQuery(page, limit, type, search, status));

            return new ResultModel
            {
                Data = exerciseList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{exerciseId:guid}")]
        public async Task<ActionResult<ResultModel>> GetExerciseById(Guid exerciseId)
        {
            var exercise = await _mediator.Send(new GetExerciseByIdQuery { ExerciseId = exerciseId });
            if (exercise == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Bài tập không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = exercise
            });
        }

        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetExerciseByUserId(Guid userId)
        {
            var exercise = await _mediator.Send(new GetExerciseByUserIdQuery { UserId = userId });
            if (exercise == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Bài tập không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = exercise
            });
        }
        [HttpGet("workout/{workoutId:guid}")]
        public async Task<ActionResult<ResultModel>> GetExerciseByWorkoutId([FromRoute] Guid workoutId)
        {
            var exercise = await _mediator.Send(new GetExerciseByWorkoutIdQuery() { WorkoutId = workoutId });
            if (exercise == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Bài tập không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = exercise
            });
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateExercise(CreateExerciseDTO createExerciseDTO)
        {
            var command = new CreateExerciseCommand(createExerciseDTO);
            var createExercise = await _mediator.Send(command);
            if (createExercise == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo bài tập thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo bài tập thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{exerciseId}")]
        public async Task<ActionResult<ResultModel>> UpdateExercise(Guid exerciseId, [FromBody] UpdateExerciseDTO updateExerciseDTO)
        {
            var command = new UpdateExerciseCommand(exerciseId, updateExerciseDTO);
            var result = await _mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật bài tập thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật bài tập thành công"
            };
        }

        [HttpDelete("{exerciseId}")]
        public async Task<ActionResult<ResultModel>> DeleteExercise(Guid exerciseId)
        {
            var command = new DeleteExerciseCommand { ExerciseId = exerciseId };
            var delete = await _mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy bài tập"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa bài tập thành công"
            };
        }

        [HttpPatch("{exerciseId}/status")]
        public async Task<ActionResult<ResultModel>> ChangeStatusExercise(Guid exerciseId)
        {
            var command = new ChangeStatusExerciseCommand { ExerciseId = exerciseId };
            var changeStatus = await _mediator.Send(command);
            if (!changeStatus)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy bài tập"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Thay đổi trạng thái thành công"
            };
        }

    }
}
