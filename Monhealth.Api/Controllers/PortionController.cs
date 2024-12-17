using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Monhealth.Application.Features.Portions.Commands.CreateFoodPortion;
using Monhealth.Application.Features.Portions.Queries.GetAllFoodPortion;
using Monhealth.Application.Models;
using System.Net;

namespace Monhealth.Api.Controllers
{
    [Route("api/v1/foodportions")]
    [ApiController]
    public class PortionController : Controller
    {
        private readonly IMediator _mediator;
        public PortionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllFoodPortions([FromQuery]int page = 1, [FromQuery]int limit = 10)
        {
            var query = new GetAllPortionQuery(page, limit);
            var result = await _mediator.Send(query);
            return new ResultModel
            {
                Data = result,
                Message = "Lấy danh sách khẩu phần ăn thành công",
                Status = 200,
                Success = true
            };
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateFoodPortion([FromBody]CreatePortionCommand create)
        {
            var result = await _mediator.Send(create);
            if(result == null)
            {
                return new ResultModel
                {
                    Message = "Tạo khẩu phần ăn thất bại",
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false
                };
            }
            return new ResultModel
            {
                Message = "Tạo khẩu phần ăn thành công",
                Status = 200,
                Success = true
            };
        }
    }
}
