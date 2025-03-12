using MediatR;
using Microsoft.AspNetCore.Mvc;
using Monhealth.Application.Features.Wallet.Commands.ChangeStatusWallet;
using Monhealth.Application.Features.Wallet.Commands.DeleteWallet;
using Monhealth.Application.Features.Wallet.Queries.GetAllWallets;
using Monhealth.Application.Features.Wallet.Queries.GetWalletByConsultantId;
using Monhealth.Application.Features.Wallet.Queries.GetWalletById;
using Monhealth.Application.Models;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/wallets")]
    [ApiController]
    public class WalletController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllWallets()
        {
            var wallets = await mediator.Send(new GetAllWalletsQuery());
            return new ResultModel
            {
                Data = wallets,
                Status = 200,
                Success = true,
            };
        }

        [HttpGet("consultant/{consultantId:guid}")]
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

        [HttpPatch("{walletId:guid}")]
        public async Task<ActionResult<ResultModel>> ChangeStatusWallet([FromRoute] Guid walletId)
        {
            var result = await mediator.Send(new ChangeStatusWalletCommand { WalletId = walletId });
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Message = "Cập nhập trạng thái thất bại",
                    Status = 500,
                };
            }
            return Ok(new ResultModel
            {
                Success = true,
                Message = "Cập nhập trạng thái thành công",
                Status = 200,
            });
        }
    }
}
