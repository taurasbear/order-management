using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Entities;
using OrderManagement.Infrastructure.Data.Builders;
using OrderManagement.Infrastructure.Data.DatabaseContext;
using OrderManagement.Infrastructure.Interfaces;

namespace OrderManagement.Infrastructure.Data.Seeders;

public class OrderSeeder(OrderContext context) : IDevelopmentSeeder
{
    public async Task SeedAsync(CancellationToken cancellationToken)
    {
        if (await context.Set<Order>().AnyAsync(cancellationToken))
        {
            return;
        }

        var orders = new OrderBuilder()
            .Build(3);

        await context.AddRangeAsync(orders, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}