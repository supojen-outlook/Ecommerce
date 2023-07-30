using System.Reflection;
using Mapster;
using MapsterMapper;
using NSwag;
using NSwag.Generation.Processors.Security;

namespace Ecommerce.Presentation;

/// <summary>
/// 
/// </summary>
public static class DI
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddPresentation(this IServiceCollection services, ConfigurationManager configuration)
    {
        #region MapSter 配置
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetCallingAssembly());
        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();
        #endregion
        
        #region Swagger 配置
        services.AddSwaggerDocument(settings =>
        {
            //設定文件名稱
            settings.DocumentName = "v1";
            // 設定文件或 API 版本資訊
            settings.Version = $"0.0.0";
            // 設定文件標題 (當顯示 Swagger/ReDoc UI 的時候會顯示在畫面上)
            settings.Title = "E-Commerce Template";
            // 設定文件簡要說明
            settings.Description = "嘗試撰寫電商平台後台";
        });
        #endregion
        
        return services;
    }
}