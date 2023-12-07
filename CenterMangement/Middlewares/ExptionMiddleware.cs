using CenterMangement.API.Errors;
using System.Net;
using System.Text.Json;

namespace CenterMangement.API.Middlewares
{
    public class ExptionMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExptionMiddleware> logger;
        private readonly IHostEnvironment Eve;

        public ExptionMiddleware(RequestDelegate next, ILogger<ExptionMiddleware> logger, IHostEnvironment eve)
        {
            this.next = next;
            this.logger = logger;
            Eve = eve;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var response = Eve.IsDevelopment() ?
                    new ApiExptionResponse((int)HttpStatusCode.InternalServerError, ex.Message, ex.StackTrace.ToString())
                   : new ApiExptionResponse((int)HttpStatusCode.InternalServerError);

                var options = new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

                var json = JsonSerializer.Serialize(response, options);
                await context.Response.WriteAsync(json);

            }
        }
    }
}
