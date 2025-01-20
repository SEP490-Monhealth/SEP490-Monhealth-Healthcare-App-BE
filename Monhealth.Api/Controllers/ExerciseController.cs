using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Exercise.Commands.CreateExercise;
using Monhealth.Application.Features.Exercise.Queries.GetAllExercises;
using Monhealth.Application.Features.Exercise.Queries.GetExerciseById;
using Monhealth.Application.Features.Goals.Commands.CreateCommand;
using Monhealth.Application.Models;

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
        public async Task<ActionResult<ResultModel>> GetAllExercise(int page = 1, int limit = 10, string type = null, string search = null, bool? popular = null)
        {
            var exerciseList = await _mediator.Send(new GetAllExercisesQuery(page, limit, type, search, popular));

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
    }
}
