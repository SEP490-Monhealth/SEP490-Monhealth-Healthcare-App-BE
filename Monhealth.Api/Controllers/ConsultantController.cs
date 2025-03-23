using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Consultant.Commands.ChangeStatusConsultant;
using Monhealth.Application.Features.Consultant.Commands.CreateConsultant;
using Monhealth.Application.Features.Consultant.Commands.DeleteConsultant;
using Monhealth.Application.Features.Consultant.Commands.UpdateConsultant;
using Monhealth.Application.Features.Consultant.Commands.VeryfiedConsultant;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;
using Monhealth.Application.Features.Consultant.Queries.GetConsultantById;
using Monhealth.Application.Models;
using System.Net;

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
        public async Task<ActionResult<ResultModel>> GetAllConsultants(int page = 1, int limit = 10, string? expertise = null, string? search = null, bool? verified = null, bool? status = null)
        {
            var consultantsList = await _mediator.Send(new GetAllConsultantsQuery(page, limit, expertise, search, status, verified));

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

        // [HttpGet("{userId:guid}/user")]
        // public async Task<ActionResult<ResultModel>> GetConsultantByUserId(Guid userId)
        // {
        //     var consultant = await _mediator.Send(new GetConsultantByUserQuery { UserId = userId });
        //     if (consultant == null)
        //     {
        //         return NotFound(new ResultModel
        //         {
        //             Success = false,
        //             Message = "Tư vấn viên không tồn tại",
        //             Status = (int)HttpStatusCode.NotFound,
        //             Data = null
        //         });
        //     }
        //     return Ok(new ResultModel
        //     {
        //         Success = true,
        //         Status = 200,
        //         Data = consultant
        //     });
        // }

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

        [HttpPatch("{consultantId}/status")]
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

        [HttpPatch("{consultantId}/verify")]
        public async Task<ActionResult<ResultModel>> VeryfiedConsultant(Guid consultantId)
        {
            var consultant = await _mediator.Send(new VeryfiedConsultantCommand() { ConsultantId = consultantId });

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
                Message = "Xác minh tư vấn viên thành công"
            });
        }
    }
}
