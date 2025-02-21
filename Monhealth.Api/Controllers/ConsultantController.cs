using System.Net;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Consultant.Commands.CreateConsultant;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;
using Monhealth.Application.Features.Expertise.Commands.CreateExpertise;
using Monhealth.Application.Features.Expertise.Queries.GetAllExpertises;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/consultants")]
    [ApiController]
    public class ConsultantController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ConsultantController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllConsultants()
        {
            var consultantsList = await _mediator.Send(new GetAllConsultantsQuery());

            return new ResultModel
            {
                Data = consultantsList,
                Status = 200,
                Success = true
            };
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateConsultant([FromBody] CreateConsultantDTO createConsultantDTO)
        {
            var command = new CreateConsultantCommand(createConsultantDTO);
            var createConsultant = await _mediator.Send(command);
            if (createConsultant == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo tư vấn viên thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo tư vấn viên thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }
    }
}
