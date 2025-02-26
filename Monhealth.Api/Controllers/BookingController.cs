using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Booking.Commands.CreateBooking;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/bookings")]
    [ApiController]
    public class BookingController(IMediator mediator) : ControllerBase
    {

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
    }
}
