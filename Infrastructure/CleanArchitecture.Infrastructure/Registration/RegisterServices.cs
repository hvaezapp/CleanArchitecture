using CleanArchitecture.Application.Common;
using CleanArchitecture.Infrastructure.SmsProvider;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

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