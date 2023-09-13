
using HRManagement.Business.Models;
using System.Net;

namespace HRManagementApi.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        //Constructor & Dependency Injection
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }
        // Proccedes with task if successfull or fires custom exception if failure
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

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            int statusCode = context.Response.StatusCode;
            string message = ex.Message;
            //Custom Error Messages based on the exception type
            switch(ex)
            {
                case NotFoundException _:
                    statusCode = (int)HttpStatusCode.NotFound;
                    message = "Item with specified id was not found.";
                    break;
                case BadRequestException _:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    message = "Bad Request. Try changing the value type.";
                    break;
            };

            await context.Response.WriteAsync(new ErrorDetails()
            {
                StatusCode = statusCode,
                Message = message
            }.ToString());
        }
    }
}
