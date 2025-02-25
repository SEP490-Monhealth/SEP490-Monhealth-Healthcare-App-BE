﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Certificate.Commands.CreateCertificate;
using Monhealth.Application.Features.Certificate.Commands.DeleteCertificate;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificate;
using Monhealth.Application.Features.Certificate.Queries.GetCertificateById;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/certificates")]
    [ApiController]
    public class CertificateController(IMediator mediator) : ControllerBase
    {

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

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllCertificate(int page = 1, int limit = 10, string? search = null, bool? status = null)
        {
            var certificates = await mediator.Send(new GetAllCertificateQuery(page, limit, search, status));
            return new ResultModel
            {
                Data = certificates,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("{certificateId:guid}")]
        public async Task<ActionResult<ResultModel>> GetCertificateById(Guid CertificateId)
        {
            var certificate = await mediator.Send(new GetCertificateByIdQuery { CertificateId = CertificateId });
            return new ResultModel
            {
                Data = certificate,
                Status = 200,
                Success = true,
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
    }
}
