﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Booking.Commands.CreateBooking;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Features.Booking.Queries.GetBookingById;
using Monhealth.Application.Features.Booking.Queries.GetBookingByUserId;
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

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllBooking(int page = 1, int limit = 10)
        {
            var bookings = await mediator.Send(new GetAllBookingQueries { Page = page, Limit = limit });
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


    }
}
