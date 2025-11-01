using Microsoft.EntityFrameworkCore;
using OrderManagement.Application;
using OrderManagement.Infrastructure;
using OrderManagement.Infrastructure.Data.DatabaseContext;
using OrderManagement.Infrastructure.Interfaces;
using OrderManagement.Server.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(opt =>
{
    opt.Filters.Add<ValidationExceptionFilter>();
    opt.Filters.Add<NotFoundExceptionFilter>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.CustomSchemaIds(type => type.FullName?.Replace("+", "."));
});

var connectionString = builder.Configuration.GetConnectionString("Development");
builder.Services.ConfigureInfrastructure(connectionString);
builder.Services.ConfigureApplication();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var orderContext = scope.ServiceProvider.GetRequiredService<OrderContext>();
    await orderContext.Database.MigrateAsync();

    foreach (var seeder in scope.ServiceProvider.GetServices<IDevelopmentSeeder>())
    {
        await seeder.SeedAsync(CancellationToken.None);
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
