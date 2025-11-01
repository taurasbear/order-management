using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Infrastructure.Data.DatabaseContext;

namespace OrderManagement.Infrastructure;

public static class ServiceExtensions
{
    public static void ConfigureInfrastructure(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<OrderContext>(
            opt => opt
                .UseLazyLoadingProxies()
                .UseNpgsql(connectionString)
        );
    }
}