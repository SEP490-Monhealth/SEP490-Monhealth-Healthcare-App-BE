using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.TimeSlots.Commands.CreateTimeSlots;
using Monhealth.Application.Features.TimeSlots.Commands.DeleteTimSlots;
using Monhealth.Application.Features.TimeSlots.Commands.UpdateTimeSlots;
using Monhealth.Application.Features.TimeSlots.Queries.GetAllTimSlots;
using Monhealth.Application.Features.TimeSlots.Queries.GetTimeSlotById;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/time-slots")]
    [ApiController]
    public class TimeSlotController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách khung giờ")]
        public async Task<ActionResult<ResultModel>> GetAllTimeSlot()
        {
            var results = await mediator.Send(new GetAllTimeSlotQueries());

            return new ResultModel
            {
                Data = results,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }

        [HttpGet("{timeSlotId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin khung giờ")]
        public async Task<ActionResult<ResultModel>> GetTimeSlotByDayOfWeek([FromRoute] Guid timeSlotId)
        {
            var results = await mediator.Send(new GetTimeSlotByIdQueries { TimeSlotId = timeSlotId });

            return new ResultModel
            {
                Data = results,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo khung giờ")]
        public async Task<ActionResult<ResultModel>> CreateTimeSlot([FromBody] CreateTimeSlotDTO createTimeSlotDTO)
        {
            var command = new CreateTimeSlotCommand(createTimeSlotDTO);
            var result = await mediator.Send(command);
            if (result == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo khung giờ thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo khung giờ thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{timeSlotId:guid}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin khung giờ")]
        public async Task<ActionResult<ResultModel>> UpdateTimeSlot([FromRoute] Guid timeSlotId, [FromBody] UpdateTimeSlotDto timeSlotDto)
        {
            var command = new UpdateTimeSlotCommand(timeSlotId, timeSlotDto);
            var results = await mediator.Send(command);

            return new ResultModel
            {
                Data = results,
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Cập nhật thông tin khung giờ thành công"
            };
        }

        [HttpDelete("{timeSlotId:guid}")]
        [SwaggerOperation(Summary = "Xóa khung giờ")]
        public async Task<ActionResult<ResultModel>> DelelteTimeSlot([FromRoute] Guid timeSlotId)
        {
            var results = await mediator.Send(new DeleteTimeSlotCommand { TimeSlotId = timeSlotId });

            return new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Xóa khung giờ thành công"
            };
        }
    }
}
