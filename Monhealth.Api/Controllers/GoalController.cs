using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Goals.Commands.CreateCommand;
using Monhealth.Application.Features.Goals.Queries.GetAllGoals;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Application.Features.Metric.Queries.GetAllMetric;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/goals")]
    [ApiController]
    public class GoalController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GoalController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll()
        {
            var goals = await _mediator.Send(new GetAllGoalsListQuery());

            return new ResultModel
            {
                Data = goals,
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Lấy danh sách mục tiêu thành công"
            };
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> Create([FromBody] CreateGoalDTO createGoalDTO)
        {
            var command = new CreateGoalCommand(createGoalDTO);
            var createMetric = await _mediator.Send(command);
            if (createMetric == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo mục tiêu thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo mục tiêu thất bại.",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }
    }
}
