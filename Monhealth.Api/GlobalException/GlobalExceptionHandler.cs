using Microsoft.AspNetCore.Diagnostics;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Models;
using System.Net;
using System.Text.Json;

namespace Monhealth.Api.GlobalException
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = "application/json";
            var contextFeature = httpContext.Features.Get<IExceptionHandlerFeature>();
            if (contextFeature != null)
            {
                // Determine the status code based on the exception type
                httpContext.Response.StatusCode = contextFeature.Error switch
                {
                    NotFoundException => StatusCodes.Status404NotFound,
                    BadRequestException => StatusCodes.Status400BadRequest,
                    UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
                    _ => StatusCodes.Status500InternalServerError
                };

                // Log the error for debugging purposes
                //_logger.LogError($"Something went wrong: {contextFeature.Error.Message}", contextFeature.Error);

                // Prepare the response message
                var result = new ResultModel
                {
                    Status = httpContext.Response.StatusCode,
                    Message = contextFeature.Error.Message
                };

                // Serialize the response in CamelCase format
                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };

                await httpContext.Response.WriteAsync(JsonSerializer.Serialize(result, options));
            }
            else
            {
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                var result = new ResultModel
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Message = "An unexpected error occurred"
                };
                await httpContext.Response.WriteAsync(JsonSerializer.Serialize(result));
            }

            return true;
        }
    }
}
