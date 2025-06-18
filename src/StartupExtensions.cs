using Microsoft.Extensions.DependencyInjection;

using XperienceCommunity.CacheManager.Services;


namespace XperienceCommunity.CacheManager;

/// <summary>
/// Contains methods to initialize the module during application startup.
/// </summary>
public static class StartupExtensions
{
    /// <summary>
    /// Registers services required by the module.
    /// </summary>
    public static IServiceCollection AddCacheManager(this IServiceCollection services)
    {
        services.AddSingleton<ICacheManagerProvider, CacheManagerProvider>();

        return services;
    }
}
