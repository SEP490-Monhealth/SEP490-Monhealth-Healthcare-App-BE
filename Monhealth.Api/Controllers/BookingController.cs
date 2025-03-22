using MediatR;
using Microsoft.AspNetCore.Mvc;
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

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/bookings")]
    [ApiController]
    public class BookingController(IMediator mediator) : ControllerBase
    {

        [HttpGet]
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
        public async Task<ActionResult<ResultModel>> GetBookingByConsultantId([FromRoute] Guid consultantId)
        {
            var booking = await mediator.Send(new GetByConsultantIdQueries { ConsultantId = consultantId });
            return new ResultModel
            {
                Data = booking,
                Status = 200,
                Success = true,
            };
        }

        [HttpPost]
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

        [HttpDelete("{bookingId:guid}")]
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

        [HttpPatch("{bookingId:guid}/completed")]
        public async Task<ActionResult<ResultModel>> UpdateBookingStatus([FromRoute] Guid bookingId)
        {
            var result = await mediator.Send(new UpdateBookingStatusCommand { BookingId = bookingId });
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

        [HttpPut("{bookingId:guid}/cancel")]
        public async Task<ActionResult<ResultModel>> UpdateBookingCancelStatus([FromRoute] Guid bookingId, [FromBody] string cancellationReason)
        {
            var command = new UpdateBookingCancelCommand(bookingId, cancellationReason);
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
    }
}
