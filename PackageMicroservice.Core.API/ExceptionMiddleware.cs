using System.Net;
using System.Text.Json;

namespace PackageMicroservice.Core.API
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context); // Proceed to the next middleware/request
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            // Log the exception (use a logging library like Serilog, NLog, etc.)
            Console.WriteLine($"Exception: {exception.Message}");

            // Prepare the error response
            var response = new
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = "An unexpected error occurred. Please try again later.",
                Details = exception.Message // Optional: Include only in non-production
            };

            // Set response properties
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            // Serialize and write the response
            return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }

}
