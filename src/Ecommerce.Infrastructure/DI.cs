using Ecommerce.Application.Interfaces.Database;
using Ecommerce.Domain.Kernel.Repositories;
using Ecommerce.Domain.Services;
using Ecommerce.Infrastructure.Persistence.Repositories;
using Ecommerce.Infrastructure.Persistence.Settings;
using Ecommerce.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infrastructure;

public static class DI
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        #region Service 配置
        services.AddSingleton<IIdentityService>(_ => new IdentityService(new Random().Next(1,31), new Random().Next(1,31)));
        #endregion

        #region Repository 配置
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        #endregion
        
        #region Database 配置
        services.AddScoped<IUnitOfWork, UnitOfWork>();        
        services.AddDbContext<AppDbContext>(ctx => 
            ctx.UseNpgsql(configuration.GetConnectionString("Postgres")));
        #endregion

        return services;
    }
}