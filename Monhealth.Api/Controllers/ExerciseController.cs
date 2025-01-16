using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Exercise.Queries.GetAllExercises;
using Monhealth.Application.Features.Nutrition.Queries.GetAllNutrition;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/exercises")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExerciseController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllExercise(int page = 1, int limit = 10, string search = null, bool? popular = null, string type = null)
        {
            var exerciseList = await _mediator.Send(new GetAllExercisesQuery(page, limit, search, popular, type));

            return new ResultModel
            {
                Data = exerciseList,
                Status = 200,
                Success = true
            };
        }
    }
}
