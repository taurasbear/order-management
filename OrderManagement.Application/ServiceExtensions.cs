using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Application.Common.Behaviors;
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
            cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddScoped<IOrderInvoiceService, OrderInvoiceService>();
        services.AddScoped<IProductReportService, ProductReportService>();
    }
}