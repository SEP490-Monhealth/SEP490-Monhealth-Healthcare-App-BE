// using System.ComponentModel.DataAnnotations;
// using MediatR;
// using Microsoft.AspNetCore.Mvc;
// using Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealForUser;
// using Monhealth.Application.Models;
// using Swashbuckle.AspNetCore.Annotations;

// namespace Monhealth.Api.Controllers
// {
//     [Route("api/v1/daily-meals")]
//     [ApiController]
//     public class DailyMealController : ControllerBase
//     {
//         private readonly IMediator _mediator;
//         public DailyMealController(IMediator mediator)
//         {
//             _mediator = mediator;
//         }

//         // [HttpGet]
//         // public async Task<ActionResult<ResultModel>> GetAllDailyMeals()
//         // {
//         //     var dailyMeals = await _mediator.Send(new GetDailyMealQuery());

//         //     return new ResultModel
//         //     {
//         //         Data = dailyMeals,
//         //         Status = 200,
//         //         Success = true
//         //     };
//         // }

//         // [HttpGet]
//         // [Route("{date:DateTime}")]
//         // public async Task<ActionResult<ResultModel>> GetDailyMealDetail(DateTime date)
//         // {
//         //     var categories = await _mediator.
//         //     Send(new GetDailyMealByCreateAtQuery() { CreateAt = date });

//         //     if (categories == null)
//         //     {
//         //         return NotFound(new ResultModel
//         //         {
//         //             Success = false,
//         //             Message = "Không tìm thấy ngày nào",
//         //             Status = (int)HttpStatusCode.NotFound,
//         //             Data = null
//         //         });
//         //     }
//         //     return Ok(new ResultModel
//         //     {
//         //         Success = true,
//         //         Status = 200,
//         //         Data = categories
//         //     });
//         // }

//         [HttpGet]
//         [Route("user")]
//         [SwaggerOperation(Summary = "Lấy bữa ăn hằng ngày theo người dùng")]
//         public async Task<ActionResult<ResultModel>> GetDailyMealByUser([FromQuery][Required] Guid userId,
//          [FromQuery][Required] DateTime date)
//         {
//             var queries = await _mediator.Send(new GetDailyMealByUserQuery(userId, date));

//             if (queries == null)
//             {
//                 return Ok(new ResultModel
//                 {
//                     Success = false,
//                     Message = "Bữa ăn hằng ngày không tồn tại",
//                     Status = 200,
//                     Data = queries
//                 });
//             }

//             return Ok(new ResultModel
//             {
//                 Success = true,
//                 Status = 200,
//                 Data = queries
//             });
//         }
//     }
// }