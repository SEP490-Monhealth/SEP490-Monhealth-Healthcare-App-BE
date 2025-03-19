using System.Net;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Activity.Commands.CreateActivity;
using Monhealth.Application.Features.Activity.Commands.DeleteActivity;
using Monhealth.Application.Features.Activity.Queries.GetActivityByUserId;
using Monhealth.Application.Features.Expertise.Commands.CreateExpertise;
using Monhealth.Application.Features.Workout.Commands.DeleteWorkout;
using Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries;
using Monhealth.Application.Models;
using Monhealth.Core.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/activities")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ActivityController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{userId}")]
        public async Task<ActionResult<ResultModel>> GetActivitiesByUserId(Guid userId)
        {
            var activities = await _mediator.Send(new GetActivityByUserIdQuery(userId));

            return new ResultModel
            {
                Data = activities,
                Status = 200,
                Success = true,
            };
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateActivity([FromBody] CreateActivityDTO createActivityDTO)
        {
            var command = new CreateActivityCommand(createActivityDTO);
            var createActivity = await _mediator.Send(command);
            if (createActivity == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo hoạt động thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo hoạt động thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }
        [HttpDelete("{activityId}")]
        public async Task<ActionResult<ResultModel>> DeleteActivity(Guid activityId)
        {
            var command = new DeleteActivityCommand { ActivityId = activityId };
            var delete = await _mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy hoạt động"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa hoạt động thành công"
            };
        }
    }
}
