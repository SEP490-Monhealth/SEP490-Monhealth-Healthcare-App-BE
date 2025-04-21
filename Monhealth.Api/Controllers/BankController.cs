using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Bank.Commands.ChangeStatusBank;
using Monhealth.Application.Features.Bank.Commands.CreateBank;
using Monhealth.Application.Features.Bank.Commands.DeleteBank;
using Monhealth.Application.Features.Bank.Commands.UpdateBank;
using Monhealth.Application.Features.Bank.Queries.GetAllBanks;
using Monhealth.Application.Features.Bank.Queries.GetBankById;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Authorize]
    [Route("api/v1/banks")]
    [ApiController]
    public class BankController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách ngân hàng")]
        public async Task<ActionResult<ResultModel>> GetAllBanks(int page = 1, int limit = 10, string? search = null, bool? status = null)
        {
            var bankList = await mediator.Send(new GetAllBanksQuery(page, limit, search, status));

            return new ResultModel
            {
                Data = bankList,
                Status = 200,
                Success = true
            };
        }

        [HttpGet("{bankId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin ngân hàng theo ID")]
        public async Task<ActionResult<ResultModel>> GetBankById(Guid bankId)
        {
            var bank = await mediator.Send(new GetBankByIdQuery { BankId = bankId });
            if (bank == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Message = "Ngân hàng không tồn tại",
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = 200,
                Data = bank
            });
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Tạo ngân hàng")]
        public async Task<ActionResult<ResultModel>> CreateBank([FromBody] CreateBankDTO createBankDTO)
        {
            var command = new CreateBankCommand(createBankDTO);
            var createBank = await mediator.Send(command);
            if (createBank == Unit.Value)
            {
                return new ResultModel
                {
                    Message = "Tạo ngân hàng thành công",
                    Status = 201,
                    Success = true
                };
            }
            return new ResultModel
            {
                Message = "Tạo ngân hàng thất bại",
                Status = (int)HttpStatusCode.BadRequest,
                Success = false
            };
        }

        [HttpPut("{bankId}")]
        [SwaggerOperation(Summary = "Cập nhật thông tin ngân hàng")]
        public async Task<ActionResult<ResultModel>> UpdateBank(Guid bankId, [FromBody] UpdateBankDTO updateBankDTO)
        {
            var command = new UpdateBankCommand(bankId, updateBankDTO);
            var result = await mediator.Send(command);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cập nhật ngân hàng thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật ngân hàng thành công"
            };
        }

        [HttpDelete("{bankId}")]
        [SwaggerOperation(Summary = "Xóa ngân hàng")]
        public async Task<ActionResult<ResultModel>> DeleteBank(Guid bankId)
        {
            var command = new DeleteBankCommand { BankId = bankId };
            var delete = await mediator.Send(command);
            if (!delete)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Xóa ngân hàng thất bại"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa ngân hàng thành công"
            };
        }

        [HttpPatch("{bankId}/status")]
        [SwaggerOperation(Summary = "Cập nhật trạng thái ngân hàng")]
        public async Task<ActionResult<ResultModel>> ChangeStatusBank(Guid bankId)
        {
            var command = new ChangeStatusBankCommand { BankId = bankId };
            var changeStatus = await mediator.Send(command);
            if (!changeStatus)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy ngân hàng"
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật trạng thái ngân hàng thành công"
            };
        }
    }
}
