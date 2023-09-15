using HRManagement.DataAccess.Exceptions;
using HRManagement.Business.Models;
using System.Net;

namespace HRManagementApi.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR: {ex}");
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            httpContext.Response.ContentType = "application/json";
            int statusCode = httpContext.Response.StatusCode;
            string message = ex.Message;
            switch(ex)
            {
                case NotFoundException _:
                    statusCode = (int)HttpStatusCode.NotFound;
                    message = "Item with specified id was not found.";
                    break;
                case BadRequestException _:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    message = "Bad Request.";
                    break;
                default:
                    statusCode = (int)HttpStatusCode.InternalServerError;
                    message = ex.Message;
                    break;
            };
            httpContext.Response.StatusCode = statusCode;

            await httpContext.Response.WriteAsync(new ErrorDetails()
            {
                StatusCode = statusCode,
                Message = message
            }.ToString());
        }
    }
}
