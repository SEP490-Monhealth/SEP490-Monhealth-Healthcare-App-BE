using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Report.ReportBookingMonthly;
using Monhealth.Application.Features.Report.ReportTransaction;
using Monhealth.Application.Features.Report.ReportTransactionMonthly;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/reports")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("weekly-meals/{userId:Guid}")]
        public async Task<ActionResult<ResultModel>> GetDailyMealReport(
            [FromRoute] Guid userId,
            [FromQuery] DateTime date)
        {
            // Tạo đối tượng query dựa trên route và query string
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

        // [HttpGet("weekly-transactions/{consultantId}")]
        // public async Task<IActionResult> GetWeeklyTransactionReport(Guid consultantId, DateTime date)
        // {
        //     var result = await _mediator.Send(new ReportTransactionWeeklyQuery
        //     {
        //         ConsultantId = consultantId,
        //         Date = date
        //     });

        //     return Ok(new ResultModel
        //     {
        //         Data = result,
        //         Status = 200,
        //         Success = true
        //     });
        // }

        [HttpGet("yearly-transactions/{consultantId}")]
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

        [HttpGet("yearly-bookings/{consultantId}")]
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
    }
}
