using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Expertise.Commands.CreateExpertise;
using Monhealth.Application.Features.Expertise.Commands.DeleteExpertise;
using Monhealth.Application.Features.Expertise.Commands.UpdateExpertise;
using Monhealth.Application.Features.Expertise.Commands.UpdateExpertiseByConsultantId;
using Monhealth.Application.Features.Expertise.Queries.GetAllExpertises;
using Monhealth.Application.Features.Expertise.Queries.GetExpertiseById;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/expertise")]
    [ApiController]
    public class ExpertiseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExpertiseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách chuyên môn")]
        public async Task<ActionResult<ResultModel>> GetAllExpertises(int page = 1, int limit = 10, string? search = null)
        {
            var expertiseList = await _mediator.Send(new GetAllExpertisesQuery(page, limit, search));

            return new ResultModel
            {
                Data = expertiseList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{expertiseId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin chuyên môn")]
        public async Task<ActionResult<ResultModel>> GetExpertiseById(Guid expertiseId)
        {
            var expertise = await _mediator.Send(new GetExpertiseByIdQuery { ExpertiseId = expertiseId });
            if (expertise == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Chuyên môn không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = expertise
            });
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo chuyên môn")]
        public async Task<ActionResult<ResultModel>> CreateExpertise([FromBody] CreateExpertiseDTO createExpertiseDTO)
        {
            var command = new CreateExpertiseCommand(createExpertiseDTO);
            var createExpertise = await _mediator.Send(command);
            if (createExpertise == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo chuyên môn thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo chuyên môn thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{expertiseId}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin chuyên môn")]
        public async Task<ActionResult<ResultModel>> UpdateExpertise(Guid expertiseId, [FromBody] UpdateExpertiseDTO updateExpertiseDTO)
        {
            var command = new UpdateExpertiseCommand(expertiseId, updateExpertiseDTO);
            var result = await _mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật thông tin chuyên môn thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật thông tin chuyên môn thành công"
            };
        }

        [HttpPut("consultant/{consultantId}")]
        [SwaggerOperation(Summary = "Cập nhật chuyên môn theo chuyên viên")]
        public async Task<ActionResult<ResultModel>> UpdateExpertiseByConsultantId(Guid consultantId, [FromBody] UpdateExpertiseByConsultantIdDto updateExpertiseDto)
        {
            var result = await _mediator.Send(new UpdateExpertiseByConsultantIdCommand(consultantId, updateExpertiseDto));
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật chuyên môn thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật chuyên môn thành công"
            };
        }

        [HttpDelete("{expertiseId}")]
        [SwaggerOperation(Summary = "Xóa chuyên môn")]
        public async Task<ActionResult<ResultModel>> DeleteExpertise(Guid expertiseId)
        {
            var command = new DeleteExpertiseCommand { ExpertiseId = expertiseId };
            var delete = await _mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy chuyên môn"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa chuyên môn thành công"
            };
        }
    }
}
