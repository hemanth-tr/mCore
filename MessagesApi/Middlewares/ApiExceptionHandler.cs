
using Microsoft.AspNetCore.Diagnostics;

namespace MessagesApi.Middlewares
{
    public class ApiExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            httpContext.Response.StatusCode = 500;
            await httpContext.Response.WriteAsync(new { Error = exception.Message }.ToString());
            return true;
        }
    }
}
