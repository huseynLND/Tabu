using FirstAPI.Services.Abstract;
using FirstAPI.Services.Implements;
namespace FirstAPI;


public static class ServiceRegistration
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<LanguageService, LanguageService>();
        return services;
    }
}
