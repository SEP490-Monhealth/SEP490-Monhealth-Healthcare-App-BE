using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantIdMonthly;
using Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId;
using Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser;
using Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater;
using Monhealth.Application.Features.Report.ReportBookingMonthly;
using Monhealth.Application.Features.Report.ReportTransactionMonthly;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/trackers")]
    [ApiController]
    public class TrackerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TrackerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("user/{userId:guid}/meals/daily")]
        [SwaggerOperation(Summary = "Lấy báo cáo bữa ăn hằng ngày theo người dùng")]
        public async Task<ActionResult<ResultModel>> GetDailyMealByUser(Guid userId, [FromQuery][Required] DateTime date)
        {
            var queries = await _mediator.Send(new GetDailyMealByUserQuery(userId, date));

            if (queries == null)
            {
                return Ok(new ResultModel
                {
                    Success = false,
                    Message = "Bữa ăn hằng ngày không tồn tại",
                    Status = 200,
                    Data = queries
                });
            }

            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpGet("user/{userId:Guid}/meal/weekly")]
        [SwaggerOperation(Summary = "Lấy báo cáo bữa ăn hằng tuần theo người dùng")]
        public async Task<ActionResult<ResultModel>> GetDailyMealReport(
            [FromRoute] Guid userId,
            [FromQuery] DateTime date)
        {
            var query = new GetDailyMealReportByUserQuery
            {
                UserId = userId,
                date = date
            };

            var result = await _mediator.Send(query);
            return Ok(new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            });
        }

        [HttpGet]
        [Route("user/{userId:guid}/water-intakes/daily")]
        [SwaggerOperation(Summary = "Lấy báo cáo lượng nước hằng ngày theo người dùng")]
        public async Task<ActionResult<ResultModel>> GetDailyWaterIntakeByUser(Guid userId, [FromQuery][Required] DateTime date)
        {
            var query = await _mediator.Send(new GetDailyWaterByUserQuery(userId, date));

            if (query == null)
            {
                return Ok(new ResultModel
                {
                    Success = false,
                    Message = "Lượng nước hằng ngày không tồn tại",
                    Status = 200,
                    Data = query
                });
            }

            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = query
            });
        }

        [HttpGet]
        [Route("user/{userId:guid}/activities/daily")]
        [SwaggerOperation(Summary = "Lấy báo cáo hoạt động hằng ngày theo người dùng")]
        public async Task<ActionResult<ResultModel>> GetDailyActivityByUserId(Guid userId, [FromQuery][Required] DateTime date)
        {
            var queries = await _mediator.Send(new GetDailyActivityByUserIdQuery(userId, date));

            if (queries == null)
            {
                return Ok(new ResultModel
                {
                    Success = false,
                    Message = "Hoạt động hằng ngày không tồn tại",
                    Status = 200,
                    Data = queries
                });
            }

            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = queries
            });
        }

        [HttpGet("consultant/{consultantId:guid}/bookings/monthly")]
        [SwaggerOperation(Summary = "Lấy danh sách lịch hẹn theo tháng theo chuyên viên tư vấn")]
        public async Task<ActionResult<ResultModel>> GetBookingByConsultantIdMonthly([FromRoute] Guid consultantId, int page = 1, int limit = 10, DateTime? month = null)
        {
            var booking = await _mediator.Send(new GetBookingByConsultantIdMonthlyQuery { Page = page, Limit = limit, ConsultantId = consultantId, Month = month });
            return new ResultModel
            {
                Data = booking,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("consultant/{consultantId}/bookings/yearly")]
        [SwaggerOperation(Summary = "Lấy báo cáo lịch hẹn theo tháng theo chuyên viên tư vấn")]
        public async Task<IActionResult> GetMonthlyBookingReport(Guid consultantId, DateTime date)
        {
            var result = await _mediator.Send(new ReportBookingMonthlyQuery
            {
                ConsultantId = consultantId,
                Date = date
            });

            return Ok(new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            });
        }

        [HttpGet("consultant/{consultantId}/transactions/yearly")]
        [SwaggerOperation(Summary = "Lấy báo cáo giao dịch theo tháng theo chuyên viên tư vấn")]
        public async Task<IActionResult> GetMonthlyTransactionReport(Guid consultantId, DateTime date)
        {
            var result = await _mediator.Send(new ReportTransactionMonthlyQuery
            {
                ConsultantId = consultantId,
                Date = date
            });

            return Ok(new ResultModel
            {
                Data = result,
                Status = 200,
                Success = true
            });
        }
    }
}