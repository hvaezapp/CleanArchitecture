namespace CleanArchitecture.Presentation.Registration;
public static class RegisterServices
{
    public static IServiceCollection RegisterPresentationServices(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        return services;
    }
}


