using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Certificate.Commands.CreateCertificate;
using Monhealth.Application.Features.Certificate.Commands.DeleteCertificate;
using Monhealth.Application.Features.Certificate.Commands.UpdateCertificate;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificate;
using Monhealth.Application.Features.Certificate.Queries.GetCertificateById;
using Monhealth.Application.Features.Expertise.Commands.UpdateExpertise;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/certificates")]
    [ApiController]
    public class CertificateController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
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

        [HttpGet("{certificateId:guid}")]
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
                Status = 500,
            });
        }
        [HttpPut("{certificateId}")]
        public async Task<ActionResult<ResultModel>> UpdateCertificate(Guid certificateId, [FromBody] UpdateCertificateDTO updateCertificateDTO)
        {
            var command = new UpdateCertificateCommand(certificateId, updateCertificateDTO);
            var result = await mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật chứng chỉ thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật chứng chỉ thành công"
            };
        }

        [HttpDelete("{certificateId:guid}")]
        public async Task<ActionResult<ResultModel>> DeleteCertificateById(Guid certificateId)
        {
            var result = await mediator.Send(new DeleteCertificateCommand { CertificateId = certificateId });
            if (!result)
            {
                return BadRequest(new ResultModel
                {
                    Success = false,
                    Message = "Xóa chứng chỉ không thành công",
                    Status = (int)HttpStatusCode.BadRequest,
                    Data = null
                });
            }

            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa chứng chỉ thành công",
                Status = 204,
                Data = null
            });
        }

        [HttpPatch("{certificateId:guid}/verify")]
        public async Task<ActionResult<ResultModel>> ChangeCertificateIsVerified(Guid certificateId)
        {
            await mediator.Send(new UpdateCertificateIsVerifiedCommand { CertificateId = certificateId });
            return new ResultModel
            {
                Data = null,
                Status = 200,
                Message = "Xác minh chứng chỉ thành công",
                Success = true,
            };
        }
    }
}
