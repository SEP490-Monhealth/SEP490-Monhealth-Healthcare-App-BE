using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Certificate.Commands.CreateCertificate;
using Monhealth.Application.Models;

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

    }
}
