using System.Text.Json;
using Ecommerce.Application;
using Ecommerce.Infrastructure;
using Ecommerce.Presentation;
using Serilog;

var configuration = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .Build();

Log.Logger = new LoggerConfiguration()
                 .ReadFrom.Configuration(configuration)
                 .CreateLogger();


try
{
    Log.Information("Application Starting Up");

    var builder = WebApplication.CreateBuilder(args);
    {
        builder.Host.UseSerilog();

        builder.Services
               .AddControllers()
               .AddJsonOptions(opt =>
               {
                   opt.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
               });

        builder.Services
               .AddApplication()
               .AddInfrastructure(builder.Configuration)
               .AddPresentation(builder.Configuration);
    }

    var app = builder.Build();
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
        app.UseHttpsRedirection();
        app.MapControllers();
        app.Run();
    }

}
catch (Exception ex)
{
    Log.Fatal(ex, "The application failed to start correctly");
}
finally
{
    Log.CloseAndFlush();
}