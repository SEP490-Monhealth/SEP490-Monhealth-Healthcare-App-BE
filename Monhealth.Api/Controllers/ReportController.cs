using System.Net;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Booking.Commands.UpdateBookingStatus;
using Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Commands.DeleteConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Commands.UpdateConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Queries.GetAllConsultantBanks;
using Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankById;
using Monhealth.Application.Features.Portions.Commands.CreateFoodPortion;
using Monhealth.Application.Features.Report.Commands.ChangeStatusReportToApproved;
using Monhealth.Application.Features.Report.Commands.ChangeStatusReportToRejected;
using Monhealth.Application.Features.Report.Commands.CreateReport;
using Monhealth.Application.Features.Report.Commands.DeleteReport;
using Monhealth.Application.Features.Report.Commands.UpdateReport;
using Monhealth.Application.Features.Report.Queries.GetAllReports;
using Monhealth.Application.Features.Report.Queries.GetReportByBookingId;
using Monhealth.Application.Features.Report.Queries.GetReportByConsultantId;
using Monhealth.Application.Features.Report.Queries.GetReportById;
using Monhealth.Application.Features.Report.Queries.GetReportByUserId;
using Monhealth.Application.Features.Report.ReportBookingMonthly;
using Monhealth.Application.Features.Report.ReportTransaction;
using Monhealth.Application.Features.Report.ReportTransactionMonthly;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;
using Swashbuckle.AspNetCore.Annotations;

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

        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách báo cáo")]
        public async Task<ActionResult<ResultModel>> GetAllConsultantBanks(int page = 1, int limit = 10, string? search = null, StatusReport? status = null)
        {
            var reportList = await _mediator.Send(new GetAllReportsQuery{ Page = page, Limit = limit, Search = search, Status = status });

            return new ResultModel
            {
                Data = reportList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{reportId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin báo cáo theo ID")]
        public async Task<ActionResult<ResultModel>> GetReportById(Guid reportId)
        {
            var report = await _mediator.Send(new GetReportByIdQuery { ReportId = reportId });
            if (report == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Báo cáo không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = report
            });
        }
        [HttpGet("booking/{bookingId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin báo cáo theo booking ID")]
        public async Task<ActionResult<ResultModel>> GetReportByBookingId(Guid bookingId)
        {
            var report = await _mediator.Send(new GetReportByBookingIdQuery { BookingId = bookingId });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = report
            });
        }

        [HttpGet("consultant/{consultantId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin báo cáo theo consultant")]
        public async Task<ActionResult<ResultModel>> GetReportByConsultantId(Guid consultantId)
        {
            var report = await _mediator.Send(new GetReportByConsultantIdQuery { ConsultantId = consultantId });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = report
            });
        }

        [HttpGet("user/{userId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin báo cáo theo user")]
        public async Task<ActionResult<ResultModel>> GetReportByUserId(Guid userId)
        {
            var report = await _mediator.Send(new GetReportByUserIdQuery { UserId = userId });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = report
            });
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo báo cáo")]
        public async Task<ActionResult<ResultModel>> CreateReport([FromBody] CreateReportDTO createReportDTO)
        {
            var command = new CreateReportCommand(createReportDTO);
            var create = await _mediator.Send(command);
            if (create == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo báo cáo thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo báo cáo thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }
        [HttpPut("{reportId}")]
        [SwaggerOperation(Summary = "Cập nhật báo cáo")]
        public async Task<ActionResult<ResultModel>> UpdateConsultantBank(Guid reportId, [FromBody] UpdateReportDTO updateReportDTO)
        {
            var command = new UpdateReportCommand(reportId, updateReportDTO);
            var result = await _mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật báo cáo thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật báo cáo thành công"
            };
        }
        [HttpDelete("{reportId}")]
        [SwaggerOperation(Summary = "Xóa báo cáo")]
        public async Task<ActionResult<ResultModel>> DeleteReport(Guid reportId)
        {
            var command = new DeleteReportCommand { ReportId = reportId };
            var delete = await _mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Xóa báo cáo thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa báo cáo thành công"
            };
        }
        [HttpPatch("{reportId:guid}/approved")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái lịch hẹn")]
        public async Task<ActionResult<ResultModel>> ChangeStatusReportApproved([FromRoute] Guid reportId)
        {
            var result = await _mediator.Send(new ChangeStatusReportToApprovedCommand { ReportId = reportId });
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập trạng thái báo cáo thất bại",
                    Status = 500,
                };
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập trạng thái báo cáo thành công",
                Status = 200,
            });
        }
        [HttpPatch("{reportId:guid}/rejected")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái lịch hẹn")]
        public async Task<ActionResult<ResultModel>> ChangeStatusReportRejected([FromRoute] Guid reportId)
        {
            var result = await _mediator.Send(new ChangeStatusReportToRejectedCommand { ReportId = reportId });
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập trạng thái báo cáo thất bại",
                    Status = 500,
                };
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập trạng thái báo cáo thành công",
                Status = 200,
            });
        }
    }
}
