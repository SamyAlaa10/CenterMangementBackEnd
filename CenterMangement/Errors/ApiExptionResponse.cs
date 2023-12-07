namespace CenterMangement.API.Errors
{
    public class ApiExptionResponse : ApiResponse
    {
        public string? Details { get; set; }
        public ApiExptionResponse(int statusCode, string? message = null, string? details = null) : base(statusCode, message)
        {
            Details = details;
        }
    }
}
