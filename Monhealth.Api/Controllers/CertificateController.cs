using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Certificate.Commands.CreateCertificate;
using Monhealth.Application.Features.Certificate.Commands.DeleteCertificate;
using Monhealth.Application.Features.Certificate.Commands.UpdateCertificate;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificate;
using Monhealth.Application.Features.Certificate.Queries.GetCertificateById;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/certificates")]
    [ApiController]
    public class CertificateController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách chứng chỉ")]
        public async Task<ActionResult<ResultModel>> GetAllCertificate(int page = 1, int limit = 10, string? search = null, bool? verified = null)
        {
            var certificates = await mediator.Send(new GetAllCertificateQuery(page, limit, search, verified));
            return new ResultModel
            {
                Data = certificates,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("consultant/{consultantId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách chứng chỉ theo ID chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetCertificateByConsultant(Guid consultantId)
        {
            var certificate = await mediator.Send(new GetAllCertificateByConsultantQuery { ConsultantId = consultantId });
            return new ResultModel
            {
                Data = certificate,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("{certificateId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin chứng chỉ theo ID")]
        public async Task<ActionResult<ResultModel>> GetCertificateById(Guid certificateId)
        {
            var certificate = await mediator.Send(new GetCertificateByIdQuery { CertificateId = certificateId });
            return new ResultModel
            {
                Data = certificate,
                Status = 200,
                Success = true,
            };
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo chứng chỉ")]
        public async Task<ActionResult<ResultModel>> CreateCertificate([FromBody] CertificateCommand certificateCommand)
        {
            var result = await mediator.Send(certificateCommand);
            if (result != null)
            {
                return Ok(new ResultModel
                {
                    Success = true,
                    Message = "Tạo chứng chỉ thành công",
                    Status = 201,
                });
            }

            return BadRequest(new ResultModel
            {
                Success = false,
                Message = "Tạo chứng chỉ thất bại",
                Status = 400,
            });
        }

        [HttpPut("{certificateId}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin chứng chỉ")]
        public async Task<ActionResult<ResultModel>> UpdateCertificate(Guid certificateId, [FromBody] UpdateCertificateDTO updateCertificateDTO)
        {
            var command = new UpdateCertificateCommand(certificateId, updateCertificateDTO);
            var result = await mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = 404,
                    Message = "Cập nhật chứng chỉ thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Cập nhật chứng chỉ thành công"
            };
        }

        [HttpDelete("{certificateId:guid}")]
        [SwaggerOperation(Summary = "Xóa chứng chỉ")]
        public async Task<ActionResult<ResultModel>> DeleteCertificateById(Guid certificateId)
        {
            var result = await mediator.Send(new DeleteCertificateCommand { CertificateId = certificateId });
            if (!result)
            {
                return BadRequest(new ResultModel
                {
                    Success = false,
                    Message = "Xóa chứng chỉ không thành công",
                    Status = 400,
                });
            }

            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa chứng chỉ thành công",
                Status = 201,
            });
        }

        [HttpPatch("{certificateId:guid}/verify")]
        [SwaggerOperation(Summary = "Xác thực chứng chỉ")]
        public async Task<ActionResult<ResultModel>> ChangeCertificateIsVerified(Guid certificateId)
        {
            await mediator.Send(new UpdateCertificateIsVerifiedCommand { CertificateId = certificateId });
            return new ResultModel
            {
                Status = 200,
                Message = "Xác thực chứng chỉ thành công",
                Success = true,
            };
        }
    }
}
