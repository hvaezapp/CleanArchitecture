

namespace CleanArchitecture.Infrastructure.Registration;

public static class RegisterServices
{
    public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient();
        services.AddTransient<ISmsAdapter, SmsAdapter>();
        return services;
    }
}