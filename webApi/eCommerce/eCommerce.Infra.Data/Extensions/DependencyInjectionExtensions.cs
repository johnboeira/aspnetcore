using eCommerce.Infra.Data.Features.Users;
using eCommerce.WebApi.Infra.Data;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infra.Data.Extensions;

public static class DependencyInjectionExtensions
{
    public static void AddInfraData(this IServiceCollection services)
    {
        services.AddScoped<ProductRepository>();
        services.AddScoped<UserRepository>();
    }
}