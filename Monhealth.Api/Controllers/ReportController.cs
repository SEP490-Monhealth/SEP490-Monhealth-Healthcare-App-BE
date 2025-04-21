using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/reports")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllConsultantBanks(int page = 1, int limit = 10, string? search = null, StatusReport? status = null)
        {
            var reportList = await _mediator.Send(new GetAllReportsQuery { Page = page, Limit = limit, Search = search, Status = status });

            return new ResultModel
            {
                Data = reportList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{reportId:guid}")]
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
        public async Task<ActionResult<ResultModel>> GetReportByConsultantId(Guid consultantId, int page = 1, int limit = 10)
        {
            var report = await _mediator.Send(new GetReportByConsultantIdQuery(consultantId, page, limit));
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = report
            });
        }

        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReportByUserId(Guid userId, int page = 1, int limit = 10)
        {
            var report = await _mediator.Send(new GetReportByUserIdQuery(userId, page, limit));
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = report
            });
        }

        [HttpPost]
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
