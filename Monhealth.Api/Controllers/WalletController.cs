using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Wallet.Commands.ChangeStatusWallet;
using Monhealth.Application.Features.Wallet.Commands.DeleteWallet;
using Monhealth.Application.Features.Wallet.Queries.GetAllWallets;
using Monhealth.Application.Features.Wallet.Queries.GetWalletByConsultantId;
using Monhealth.Application.Features.Wallet.Queries.GetWalletById;
using Monhealth.Application.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/wallets")]
    [ApiController]
    public class WalletController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Lấy danh sách ví")]
        public async Task<ActionResult<ResultModel>> GetAllWallets(int page = 1, int limit = 10, bool? status = null)
        {
            var wallets = await mediator.Send(new GetAllWalletsQuery { Page = page, Limit = limit, Status = status });

            return new ResultModel
            {
                Data = wallets,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("consultant/{consultantId:guid}")]
        [SwaggerOperation(Summary = "Lấy danh sách ví theo ID chuyên viên")]
        public async Task<ActionResult<ResultModel>> GetWalletByConsultantId([FromRoute] Guid consultantId)
        {
            var wallet = await mediator.Send(new GetWalletByConsultantIdQuery { ConsultantId = consultantId });
            return new ResultModel
            {
                Data = wallet,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("{walletId:guid}")]
        [SwaggerOperation(Summary = "Lấy thông tin ví theo ID")]
        public async Task<ActionResult<ResultModel>> GetWalletById([FromRoute] Guid walletId)
        {
            var wallet = await mediator.Send(new GetWalletByIdQuery { WalletId = walletId });
            return new ResultModel
            {
                Data = wallet,
                Status = 200,
                Success = true,
            };
        }

        [HttpDelete("{walletId:guid}")]
        [SwaggerOperation(Summary = "Xóa ví theo ID")]
        public async Task<ActionResult<ResultModel>> DeleteWallet([FromRoute] Guid walletId)
        {
            await mediator.Send(new DeleteWalletCommand { WalletId = walletId });
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Xóa ví thành công",
                Status = 204,
            });
        }

        [HttpPatch("{walletId:guid}/status")]
        [SwaggerOperation(Summary = "Cập nhật thông tin trạng thái ví")]
        public async Task<ActionResult<ResultModel>> ChangeStatusWallet([FromRoute] Guid walletId)
        {
            var result = await mediator.Send(new ChangeStatusWalletCommand { WalletId = walletId });
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập trạng thái ví thất bại",
                    Status = 500,
                };
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập trạng thái ví thành công",
                Status = 200,
            });
        }
    }
}
