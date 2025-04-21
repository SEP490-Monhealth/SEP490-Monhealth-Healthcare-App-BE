using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Booking.Commands.CreateBooking;
using Monhealth.Application.Features.Booking.Commands.DeleteBooking;
using Monhealth.Application.Features.Booking.Commands.UpdateBooking;
using Monhealth.Application.Features.Booking.Commands.UpdateBookingCancel;
using Monhealth.Application.Features.Booking.Commands.UpdateBookingStatus;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantId;
using Monhealth.Application.Features.Booking.Queries.GetBookingById;
using Monhealth.Application.Features.Booking.Queries.GetBookingByUserId;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/bookings")]
    [ApiController]
    public class BookingController(IMediator mediator) : ControllerBase
    {

        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách lịch hẹn")]
        public async Task<ActionResult<ResultModel>> GetAllBooking(int page = 1, int limit = 10, string? search = null, BookingStatus? status = null)
        {
            var bookings = await mediator.Send(new GetAllBookingQueries { Page = page, Limit = limit, Search = search, Status = status });
            return new ResultModel
            {
                Data = bookings,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("{bookingId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin lịch hẹn theo ID")]
        public async Task<ActionResult<ResultModel>> GetBookingById([FromRoute] Guid bookingId)
        {
            var booking = await mediator.Send(new GetBookingByIdQueries { BookingId = bookingId });
            return new ResultModel
            {
                Data = booking,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("user/{userId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách lịch hẹn theo ID người dùng")]
        public async Task<ActionResult<ResultModel>> GetBookingByUserId([FromRoute] Guid userId)
        {
            var booking = await mediator.Send(new GetBookingByUserIdQueries { UserId = userId });
            return new ResultModel
            {
                Data = booking,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("consultant/{consultantId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách lịch hẹn theo ID chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetBookingByConsultantId([FromRoute] Guid consultantId, DateTime? date = null)
        {
            var booking = await mediator.Send(new GetByConsultantIdQueries { ConsultantId = consultantId, Date = date });
            return new ResultModel
            {
                Data = booking,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("user/{userId:guid}/consultant/{consultantId:guid}")]
        public async Task<ActionResult<ResultModel>> GetBookingByUserIdAndConsultant(Guid userId, Guid consultantId)
        {
            var booking = await mediator.Send(new GetAllBookingByConsultantAndUser
            {
                UserId = userId,
                ConsultantId = consultantId
            });

            return new ResultModel
            {
                Data = booking,
                Status = 200,
                Success = true,
            };
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo lịch hẹn")]
        public async Task<ActionResult<ResultModel>> CreateBooking([FromBody] CreateBookingCommand command)
        {
            await mediator.Send(command);
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Tạo lịch hẹn thành công",
                Status = 201,
            });
        }

        [HttpPut("{bookingId:guid}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin lịch hẹn")]
        public async Task<ActionResult<ResultModel>> UpdateBookingById([FromRoute] Guid bookingId, [FromBody] UpdateBookingDto command)
        {
            await mediator.Send(new UpdateBookingCommand(bookingId, command));
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập lịch hẹn thành công",
                Status = 201,
            });
        }

        [HttpPut("{bookingId:guid}/cancel")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái hủy lịch hẹn")]
        public async Task<ActionResult<ResultModel>> UpdateBookingCancelStatus([FromRoute] Guid bookingId, [FromBody] UpdateBookingCancelDTO request)
        {
            var command = new UpdateBookingCancelCommand(bookingId, request);
            var result = await mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập trạng thái thất bại",
                    Status = 500,
                };
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập trạng thái thành công",
                Status = 200,
            });
        }

        [HttpDelete("{bookingId:guid}")]
        [SwaggerOperation(Summary = "Xóa lịch hẹn")]
        public async Task<ActionResult<ResultModel>> DeleteBookingById([FromRoute] Guid bookingId)
        {
            await mediator.Send(new DeleteBookingCommand { BookingId = bookingId });
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa lịch hẹn thành công",
                Status = 204,
            });
        }

        [HttpPatch("{bookingId:guid}/status")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái lịch hẹn")]
        public async Task<ActionResult<ResultModel>> UpdateBookingStatus([FromRoute] Guid bookingId)
        {
            var result = await mediator.Send(new UpdateBookingStatusCommand { BookingId = bookingId });
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập trạng thái lịch hẹn thất bại",
                    Status = 500,
                };
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập trạng thái lịch hẹn thành công",
                Status = 200,
            });
        }
    }
}
