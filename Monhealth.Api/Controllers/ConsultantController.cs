using System.Net;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Consultant.Commands.ChangeStatusConsultant;
using Monhealth.Application.Features.Consultant.Commands.CreateConsultant;
using Monhealth.Application.Features.Consultant.Commands.DeleteConsultant;
using Monhealth.Application.Features.Consultant.Commands.UpdateConsultant;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;
using Monhealth.Application.Features.Consultant.Queries.GetConsultantById;
using Monhealth.Application.Features.Exercise.Queries.GetExerciseById;
using Monhealth.Application.Features.Expertise.Commands.CreateExpertise;
using Monhealth.Application.Features.Expertise.Commands.DeleteExpertise;
using Monhealth.Application.Features.Expertise.Commands.UpdateExpertise;
using Monhealth.Application.Features.Expertise.Queries.GetAllExpertises;
using Monhealth.Application.Features.Food.ChangeStatus;
using Monhealth.Application.Models;
using Monhealth.Domain;

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
        public async Task<ActionResult<ResultModel>> GetAllConsultants(int page = 1, int limit = 10, bool? status = null)
        {
            var consultantsList = await _mediator.Send(new GetAllConsultantsQuery(page, limit, status));

            return new ResultModel
            {
                Data = consultantsList,
                Status = 200,
                Success = true
            };
        }
        [HttpGet("{consultantId:guid}")]
        public async Task<ActionResult<ResultModel>> GetConsultantById(Guid consultantId)
        {
            var consultant = await _mediator.Send(new GetConsultantByIdCommand { ConsultantId = consultantId });
            if (consultant == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Tư vấn viên không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = consultant
            });
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
        [HttpPut("{consultantId}")]
        public async Task<ActionResult<ResultModel>> UpdateConsultant(Guid consultantId, [FromBody] UpdateConsultantDTO updateConsultantDTO)
        {
            var command = new UpdateConsultantCommand(consultantId, updateConsultantDTO);
            var result = await _mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật tư vấn viên thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật tư vấn viên thành công"
            };
        }
        [HttpPatch("{consultantId}")]
        public async Task<ActionResult<ResultModel>> ChangeStatusConsultant(Guid consultantId)
        {
            var consultant = await _mediator.Send(new ChangeStatusConsultantCommand() { ConsultantId = consultantId });

            if (consultant == false)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Tư vấn viên không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Cập nhật tư vấn viên thành công"
            });
        }
        [HttpDelete("{consultantId}")]
        public async Task<ActionResult<ResultModel>> DeleteConsultant(Guid consultantId)
        {
            var command = new DeleteConsultantCommand { ConsultantId = consultantId };
            var delete = await _mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy tư vấn viên"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa tư vấn viên thành công"
            };
        }
    }
}
