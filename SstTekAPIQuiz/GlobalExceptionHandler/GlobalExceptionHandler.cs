using Newtonsoft.Json;

namespace SstTekAPIQuiz.GlobalExceptionHandler
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _request;

        public GlobalExceptionHandler(RequestDelegate request)
        {
            _request = request;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _request(httpContext);
            }
            catch (Exception e)
            {

                await HandleMailException(httpContext, e);
            }
        }

        private async Task HandleMailException(HttpContext context, Exception exception)
        {
            await context.Response.WriteAsync(JsonConvert.SerializeObject(new Error
            {
                StatusCode = context.Response.StatusCode,
                Message = exception.Message
            }));
        }
    }

    public class Error
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}
