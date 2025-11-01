using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Application.Interfaces.Services;
using OrderManagement.Application.Services;

namespace OrderManagement.Application;

public static class ServiceExtensions
{
    public static void ConfigureApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddScoped<IOrderInvoiceService, OrderInvoiceService>();
    }
}