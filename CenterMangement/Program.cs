using CenterMangement.API.Extensions;
using CenterMangement.API.Middlewares;
using CenterMangement.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace CenterMangement
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region Configure Services
            builder.Services.AddControllers();
            builder.Services.AddSwaggerServicesExtension();


            builder.Services.AddDbContext<CenterMangementContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefultConnection"));
            });
            builder.Services.AddApplicationServices();
            builder.Services.AddIdentityServicesExtension(builder.Configuration);

            #endregion


            var app = builder.Build();

            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            var LoggerFactory = services.GetRequiredService<ILoggerFactory>();
            try
            {
                var dbContext = services.GetRequiredService<CenterMangementContext>(); // ask Explicilty
                await dbContext.Database.MigrateAsync(); //Aply Migrations
                //await AppDbContextSeed.SeedAsync(dbContext);

            }
            catch (Exception ex)
            {
                var Logger = LoggerFactory.CreateLogger<Program>();
                Logger.LogError(ex, ex.Message);
                Console.WriteLine(ex.ToString());
            }


            // Configure the HTTP request pipeline.
            #region Configure Kestrel Middilewares

            app.UseMiddleware<ExptionMiddleware>();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwaggerMiddleWare();
            }
            app.UseStatusCodePagesWithRedirects("/errors/{0} {1} {2}");
            app.UseCors("AllowAccess_To_API");
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            #endregion
            app.Run();
        }
    }
}