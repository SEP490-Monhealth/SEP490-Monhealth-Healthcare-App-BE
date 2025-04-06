using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.ConsultantBank.Commands.ChangeIsDefaultConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Commands.ChangeStatusConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Commands.DeleteConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Commands.UpdateConsultantBank;
using Monhealth.Application.Features.ConsultantBank.Queries.GetAllConsultantBanks;
using Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankByConsultantId;
using Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankById;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/consultant-banks")]
    [ApiController]
    public class ConsultantBankController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách tài khoản ngân hàng")]
        public async Task<ActionResult<ResultModel>> GetAllConsultantBanks(int page = 1, int limit = 10, string? search = null)
        {
            var consultantBankList = await mediator.Send(new GetAllConsultantBanksQuery(page, limit, search));

            return new ResultModel
            {
                Data = consultantBankList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{consultantBankId:guid}")]
        [SwaggerOperation(Summary = "Lấy tài khoản ngân hàng theo ID")]
        public async Task<ActionResult<ResultModel>> GetConsultantBankById(Guid consultantBankId)
        {
            var consultantBank = await mediator.Send(new GetConsultantBankByIdQuery { ConsultantBankId = consultantBankId });
            if (consultantBank == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Tài khoản ngân hàng chuyên viên không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = consultantBank
            });
        }

        [HttpGet("consultant/{consultantId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách tài khoản ngân hàng theo ID chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetConsultantBankByConsultantId(Guid consultantId)
        {
            var consultantBank = await mediator.Send(new GetConsultantBankByConsultantIdQuery { ConsultantId = consultantId });
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = consultantBank
            });
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo tài khoản ngân hàng")]
        public async Task<ActionResult<ResultModel>> CreateConsultantBank([FromBody] CreateConsultantBankDTO createConsultantBankDTO)
        {
            var command = new CreateConsultantBankCommand(createConsultantBankDTO);
            var create = await mediator.Send(command);
            if (create == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo tài khoản ngân hàng thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo tài khoản ngân hàng thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{consultantBankId}")]
        [SwaggerOperation(Summary = "Cập nhật tài khoản ngân hàng")]
        public async Task<ActionResult<ResultModel>> UpdateConsultantBank(Guid consultantBankId, [FromBody] UpdateConsultantBankDTO updateConsultantBankDTO)
        {
            var command = new UpdateConsultantBankCommand(consultantBankId, updateConsultantBankDTO);
            var result = await mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật tài khoản ngân hàng chuyên viên thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật tài khoản ngân hàng chuyên viên thành công"
            };
        }

        [HttpDelete("{consultantBankId}")]
        [SwaggerOperation(Summary = "Xóa tài khoản ngân hàng")]
        public async Task<ActionResult<ResultModel>> DeleteConsultantBank(Guid consultantBankId)
        {
            var command = new DeleteConsultantBankCommand { ConsultantBankId = consultantBankId };
            var delete = await mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Xóa tài khoản ngân hàng chuyên viên thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa tài khoản ngân hàng chuyên viên thành công"
            };
        }

        [HttpPatch("{consultantBankId}/default")]
        [SwaggerOperation(Summary = "Cập nhật tài khoản ngân hàng mặc định")]
        public async Task<ActionResult<ResultModel>> ChangeIsDefaultConsultantBank(Guid consultantBankId)
        {
            var command = new ChangeIsDefaultConsultantBankCommand { ConsultantBankId = consultantBankId };
            var changeStatus = await mediator.Send(command);
            if (!changeStatus)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy tài khoản ngân hàng chuyên viên"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật tài khoản mặc định thành công"
            };
        }

        //[HttpPatch("{consultantBankId}/status")]
        //public async Task<ActionResult<ResultModel>> ChangeStatusConsultantBank(Guid consultantBankId)
        //{
        //    var command = new ChangeStatusConsultantBankCommand { ConsultantBankId = consultantBankId };
        //    var changeStatus = await mediator.Send(command);
        //    if (!changeStatus)
        //    {
        //        return new ResultModel
        //        {
        //            Success = false,
        //            Status = (int)HttpStatusCode.NotFound,
        //            Message = "Không tìm thấy tài khoản ngân hàng chuyên viên"
        //        };
        //    }
        //    return new ResultModel
        //    {
        //        Success = true,
        //        Status = (int)HttpStatusCode.OK,
        //        Message = "Thay đổi trạng thái thành công"
        //    };
        //}
    }
}
