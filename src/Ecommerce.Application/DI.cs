using Ecommerce.Domain.Kernel.Creation;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Ecommerce.Application;

public static class DI
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        #region MediatR 配置
        services.AddMediatR(typeof(DI).Assembly);
        #endregion
        
        #region Builder & Factory 配置
        services.AddScoped<CategoryBuilder, CategoryBuilder>();
        #endregion

        return services;
    }
}