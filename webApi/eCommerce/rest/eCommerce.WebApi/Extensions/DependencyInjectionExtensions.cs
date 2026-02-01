using eCommerce.WebApi.Infra;

namespace eCommerce.WebApi.Extensions;

public static class DependencyInjectionExtensions
{
    public static void AddInfra(this IServiceCollection services)
    {
        services.AddScoped<ProductRepository>();
        services.AddScoped<AuthenticationRepository>();
    }
}