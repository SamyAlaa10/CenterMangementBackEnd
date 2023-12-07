using CenterMangement.API.Errors;
using CenterMangement.Core.Repostiories;
using CenterMangement.Helpers.Maping;
using CenterMangement.Repository;
using Control.API;
using Microsoft.AspNetCore.Mvc;
namespace CenterMangement.API.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection Services)
        {
            Services.AddScoped<IUnitOfWork, UnitOfWork>();
            Services.AddAutoMapper(typeof(MapingProfiles));
            Services.AddScoped<IControlBase, ControlApi>();
         
            Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = (actionContext) =>
                {
                    var errors = actionContext.ModelState.Where(p => p.Value.Errors.Count > 0).SelectMany(p => p.Value.Errors).Select(e => e.ErrorMessage).ToArray();

                    var validationErrorResponse = new ApiValidationErrorResponse()
                    {
                        Errors = errors
                    };
                    return new BadRequestObjectResult(validationErrorResponse);
                };
            });
            return Services;
        }
    }
}
