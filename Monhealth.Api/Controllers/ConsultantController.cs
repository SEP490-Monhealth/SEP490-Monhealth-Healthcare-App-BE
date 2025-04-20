using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application;
using Monhealth.Application.Features.Consultant.Commands.ChangeStatusConsultant;
using Monhealth.Application.Features.Consultant.Commands.CreateConsultant;
using Monhealth.Application.Features.Consultant.Commands.DeleteConsultant;
using Monhealth.Application.Features.Consultant.Commands.RejectConsultant;
using Monhealth.Application.Features.Consultant.Commands.UpdateConsultant;
using Monhealth.Application.Features.Consultant.Commands.VeryfiedConsultant;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;
using Monhealth.Application.Features.Consultant.Queries.GetConsultantById;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
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
        [SwaggerOperation(Summary = "Lấy danh sách chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetAllConsultants(int page = 1, int limit = 10, string? expertise = null, string? search = null, bool? verified = null, bool? popular = null, bool? status = null)
        {
            var consultantsList = await _mediator.Send(new GetAllConsultantsQuery(page, limit, expertise, search, verified, popular, status));

            return new ResultModel
            {
                Data = consultantsList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{consultantId:guid}")]
        [SwaggerOperation(Summary = "Lấy chuyên viên theo ID")]
        public async Task<ActionResult<ResultModel>> GetConsultantById(Guid consultantId)
        {
            var consultant = await _mediator.Send(new GetConsultantByIdCommand { ConsultantId = consultantId });
            if (consultant == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "chuyên viên không tồn tại",
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


        [HttpGet("user/{userId:guid}")]
        [SwaggerOperation(Summary = "Lấy chuyên viên theo ID người dùng")]
        public async Task<ActionResult<ResultModel>> GetConsultantByUserId(Guid userId)
        {
            var consultant = await _mediator.Send(new GetConsultantByUserQuery { UserId = userId });
            if (consultant == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Chuyên viên không tồn tại",
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
        [SwaggerOperation(Summary = "Tạo chuyên viên")]
        public async Task<ActionResult<ResultModel>> CreateConsultant([FromBody] CreateConsultantDTO createConsultantDTO)
        {
            var command = new CreateConsultantCommand(createConsultantDTO);
            var createConsultant = await _mediator.Send(command);
            if (createConsultant == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo chuyên viên thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Success = false,
                Status = (int)HttpStatusCode.BadRequest,
                Message = "Tạo chuyên viên thất bại"
            };
        }

        [HttpPut("{consultantId}")]
        [SwaggerOperation(Summary = "Cập nhật chuyên viên")]
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
                    Message = "Cập nhật chuyên viên thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật chuyên viên thành công"
            };
        }

        [HttpDelete("{consultantId}")]
        [SwaggerOperation(Summary = "Xóa chuyên viên")]
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
                    Message = "Không tìm thấy chuyên viên"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa chuyên viên thành công"
            };
        }

        [HttpPatch("{consultantId}/status")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái chuyên viên")]
        public async Task<ActionResult<ResultModel>> ChangeStatusConsultant(Guid consultantId)
        {
            var consultant = await _mediator.Send(new ChangeStatusConsultantCommand() { ConsultantId = consultantId });

            if (consultant == false)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Chuyên viên không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Cập nhật trạng thái chuyên viên thành công"
            });
        }

        [HttpPatch("{consultantId}/verify")]
        [SwaggerOperation(Summary = "Xác thực chuyên viên")]
        public async Task<ActionResult<ResultModel>> VeryfiedConsultant(Guid consultantId)
        {
            var consultant = await _mediator.Send(new VeryfiedConsultantCommand() { ConsultantId = consultantId });

            if (consultant == false)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Chuyên viên không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Xác thực chuyên viên thành công."
            });
        }

        [HttpPatch("{consultantId}/reject")]
        [SwaggerOperation(Summary = "Từ chối chuyên viên")]
        public async Task<ActionResult<ResultModel>> RejectConsultant(Guid consultantId)
        {
            var consultant = await _mediator.Send(new RejectConsultantCommand() { ConsultantId = consultantId });

            if (consultant == false)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập thất bại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Từ chối chuyên viên thành công."
            });
        }
    }


}
