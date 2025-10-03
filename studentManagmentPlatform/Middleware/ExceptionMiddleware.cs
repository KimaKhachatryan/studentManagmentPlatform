using System.Net;
using System.Text.Json;
using studentManagmentPlatform.Core.ExceptionHandling;

namespace studentManagmentPlatform.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            await HandleException(context, ex);
        }
    }

    private static Task HandleException(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";

        int statusCode;
        object response;

        switch (exception)
        {
            case NotFoundException notFoundEx:
                statusCode = (int)HttpStatusCode.NotFound;
                response = new { message = notFoundEx.Message };
                break;
            
            case Core.ExceptionHandling.ArgumentNullException arfEx:
                statusCode = (int)HttpStatusCode.BadRequest;
                response = new { message = arfEx.Message };
                break;
            case Core.ExceptionHandling.HttpRequestException httpRequestEx:
                statusCode = (int)HttpStatusCode.BadRequest;
                response = new { message = httpRequestEx.Message };
                break;
            case Core.ExceptionHandling.InvalidOperationException invalidOperationEx:
                statusCode = (int)HttpStatusCode.BadRequest;
                response = new { message = invalidOperationEx };
                break;
            case Core.ExceptionHandling.NullReferenceException nullReferenceEx:
                statusCode = (int)HttpStatusCode.BadRequest;
                response = new { message = "NullReferenceException" };
                break;
            case PostgresException postgresEx:
                statusCode = (int)HttpStatusCode.BadRequest;
                response = new { message = postgresEx.Message };
                break;
            default:
                statusCode = (int)HttpStatusCode.InternalServerError;
                response = new { message = "Sorry internal server error" };
                break;
        }
        context.Response.StatusCode = statusCode;
        var json = JsonSerializer.Serialize(response);
        return context.Response.WriteAsync(json);

    }
}