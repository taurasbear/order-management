using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Application.Interfaces.Data;
using OrderManagement.Infrastructure.Data;
using OrderManagement.Infrastructure.Data.DatabaseContext;
using OrderManagement.Infrastructure.Data.Seeders;
using OrderManagement.Infrastructure.Interfaces;

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

        services.AddScoped<IRepository, Repository>();

        services.AddScoped<IDevelopmentSeeder, ProductSeeder>();
        services.AddScoped<IDevelopmentSeeder, OrderSeeder>();
        services.AddScoped<IDevelopmentSeeder, OrderProductSeeder>();
    }
}