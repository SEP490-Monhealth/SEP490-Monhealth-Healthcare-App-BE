using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Bank.Commands.ChangeStatusBank;
using Monhealth.Application.Features.Bank.Commands.CreateBank;
using Monhealth.Application.Features.Bank.Commands.DeleteBank;
using Monhealth.Application.Features.Bank.Commands.UpdateBank;
using Monhealth.Application.Features.Exercise.Commands.ChangeStatusExercise;
using Monhealth.Application.Features.Exercise.Commands.CreateExercise;
using Monhealth.Application.Features.Portions.Commands.CreateFoodPortion;
using Monhealth.Application.Features.Portions.Commands.UpdateFoodPortion;
using Monhealth.Application.Features.Portions.Commands.UpdatePortion;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/banks")]
    [ApiController]
    public class BankController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
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
                Message = "Thay đổi trạng thái thành công"
            };
        }
    }
}
