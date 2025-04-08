using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Schedule.Commands.Create;
using Monhealth.Application.Features.Schedule.Commands.Delete;
using Monhealth.Application.Features.Schedule.Commands.Update;
using Monhealth.Application.Features.Schedule.Queries.GetAll;
using Monhealth.Application.Features.Schedule.Queries.GetByUser;
using Monhealth.Application.Features.Subscription.Queries.GetById;
using Monhealth.Application.Features.TimeSlots.Queries.GetAllTimeSlotForDayOfWeek;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/schedules")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ScheduleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách lịch trình")]
        public async Task<ActionResult<ResultModel>> GetAllSchedule(int page = 1, int limit = 10)
        {
            var scheduleList = await _mediator.Send(new GetAllScheduleQuery
            {
                Page = page,
                Limit = limit
            });

            return new ResultModel
            {
                Data = scheduleList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet]
        [Route("consultant/{consultantId:Guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách lịch trình theo ID chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetScheduleByUser(Guid consultantId, [FromQuery] DateTime? date = null, ScheduleType? type = null)
        {
            var queries = await _mediator.
            Send(new GetScheduleByConsultantIdQuery { ConsultantId = consultantId, Date = date, ScheduleType = type });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Lịch trình không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpGet]
        [Route("{scheduleId:Guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin lịch trình theo ID")]
        public async Task<ActionResult<ResultModel>> GetScheduleDetail(Guid scheduleId)
        {
            var queries = await _mediator.
            Send(new GetDetailScheduleQuery { ScheduleId = scheduleId });

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Lịch trình không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo lịch trình")]
        public async Task<ResultModel> Create([FromBody] CreateScheduleCommand request)
        {
            var create = await _mediator.Send(request);
            //if (create == true)
            //{
            //    return new ResultModel
            //    {
            //        Message = "Tạo lịch trình thành công",
            //        Status = 201,
            //        Success = true
            //    };
            //}
            return new ResultModel
            {
                Message = "Tạo lịch trình thành công",
                Status = (int)HttpStatusCode.OK,
                Success = true
            };
        }

        [HttpPut]
        [Route("{scheduleId:Guid}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin lịch trình")]
        public async Task<ActionResult<ResultModel>> UpdateCategory(Guid scheduleId, [FromBody] UpdateScheduleRequest request)
        {
            var command = new UpdateScheduleCommand(scheduleId, request);
            var result = await _mediator.Send(command);
            if (!result)
                return new ResultModel
                {
                    Message = "Cập nhật lịch trình thất bại",
                    Success = false,
                    Data = null
                };
            return Ok(
                new ResultModel
                {
                    Message = "Cập nhật lịch trình thành công",
                    Success = true,
                    Status = 204,
                }
            );
        }

        [HttpDelete]
        [Route("{scheduleId:Guid}")]
        [SwaggerOperation(Summary = "Xóa lịch trình")]
        public async Task<ActionResult<ResultModel>> Delete(Guid scheduleId)
        {
            var queries = await _mediator.
            Send(new DeleteScheduleRequest(scheduleId));

            if (queries == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Lịch trình không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 204,
                Data = queries
            });
        }

        [HttpGet("time-slots")]
        [SwaggerOperation(Summary = "Lấy danh sách khung giờ")]
        public async Task<ActionResult<ResultModel>> GetTimeSlotByDayOfWeek()
        {
            var results = await _mediator.Send(new GetAllTimeSlotForDayOfWeekQueries());

            return new ResultModel
            {
                Data = results,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }
    }
}