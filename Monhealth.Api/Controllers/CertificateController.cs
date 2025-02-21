using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Certificate.Queries.GetAllCertificates;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CertificateController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllCertificate()
        {
            var certificatesList = await _mediator.Send(new GetAllCertificatesQuery());

            return new ResultModel
            {
                Data = certificatesList,
                Status = 200,
                Success = true
            };
        }
    }
}
