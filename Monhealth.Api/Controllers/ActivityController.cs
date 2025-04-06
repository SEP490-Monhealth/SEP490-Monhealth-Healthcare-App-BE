using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Activity.Commands.ChangeIsCompletedActivity;
using Monhealth.Application.Features.Activity.Commands.CreateActivity;
using Monhealth.Application.Features.Activity.Commands.DeleteActivity;
using Monhealth.Application.Features.Activity.Queries.GetActivityByUserId;
using Monhealth.Application.Features.Activity.Queries.GetAllActivities;
using Monhealth.Application.Features.Exercise.Commands.ChangeStatusExercise;
using Monhealth.Application.Models;
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

        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách hoạt động")]
        public async Task<ActionResult<ResultModel>> GetAllActivities()
        {
            var activities = await _mediator.Send(new GetAllActivitiesQuery());

            return new ResultModel
            {
                Data = activities,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("user/{userId}")]
        [SwaggerOperation(Summary = "Lấy danh sách hoạt động theo ID người dùng")]
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

        [HttpGet("{activityId}")]
        [SwaggerOperation(Summary = "Lấy thông tin hoạt động theo ID")]
        public async Task<ActionResult<ResultModel>> GetById(Guid activityId)
        {
            var activities = await _mediator.Send(new GetActivityByIdQuery(activityId));

            return new ResultModel
            {
                Data = activities,
                Status = 200,
                Success = true,
            };
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo hoạt động")]
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
        [SwaggerOperation(Summary = "Xóa hoạt động")]
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

        [HttpPatch("{activityId}/completed")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái hoàn thành của hoạt động")]
        public async Task<ActionResult<ResultModel>> ChangeIsCompleted(Guid activityId)
        {
            var command = new ChangeIsCompletedActivityCommand { ActivityId = activityId };
            var changeStatus = await _mediator.Send(command);
            if (!changeStatus)
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
            };
        }
    }
}
