﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.TimeSlots.Commands.CreateTimeSlots;
using Monhealth.Application.Features.TimeSlots.Commands.DeleteTimSlots;
using Monhealth.Application.Features.TimeSlots.Commands.UpdateTimeSlots;
using Monhealth.Application.Features.TimeSlots.Queries.GetAllTimSlots;
using Monhealth.Application.Features.TimeSlots.Queries.GetTimeSlotById;
using Monhealth.Application.Models;
using System.Net;
using Swashbuckle.AspNetCore.Annotations;
using Monhealth.Application.Features.Schedule.Queries.GetAll;
using Monhealth.Domain;

namespace Monhealth.Api.Controllers
{
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
        [SwaggerOperation(Summary = "Lấy khung giờ theo ID")]
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
        [SwaggerOperation(Summary = "Cập nhật khung giờ")]
        public async Task<ActionResult<ResultModel>> UpdateTimeSlot([FromRoute] Guid timeSlotId, [FromBody] UpdateTimeSlotDto timeSlotDto)
        {
            var command = new UpdateTimeSlotCommand(timeSlotId, timeSlotDto);
            var results = await mediator.Send(command);

            return new ResultModel
            {
                Data = results,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }

        [HttpDelete("{timeSlotId:guid}")]
        [SwaggerOperation(Summary = "Xóa khung giờ")]
        public async Task<ActionResult<ResultModel>> DelelteTimeSlot([FromRoute] Guid timeSlotId)
        {
            var results = await mediator.Send(new DeleteTimeSlotCommand { TimeSlotId = timeSlotId });

            return new ResultModel
            {
                Data = results,
                Status = (int)HttpStatusCode.OK,
                Success = true,
            };
        }
    }
}
