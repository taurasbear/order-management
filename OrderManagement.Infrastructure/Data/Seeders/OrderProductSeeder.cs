
using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Entities;
using OrderManagement.Infrastructure.Data.Builders;
using OrderManagement.Infrastructure.Data.DatabaseContext;
using OrderManagement.Infrastructure.Interfaces;

namespace OrderManagement.Infrastructure.Data.Seeders;

public class OrderProductSeeder(OrderContext context) : IDevelopmentSeeder
{
    public async Task SeedAsync(CancellationToken cancellationToken)
    {
        if (await context.Set<OrderProduct>().AnyAsync(cancellationToken))
        {
            return;
        }

        var orders = await context.Set<Order>()
            .ToListAsync(cancellationToken);

        var products = await context.Set<Product>()
            .ToListAsync(cancellationToken);

        for (int i = 0; i < orders.Count; i++)
        {
            var product = products
                .Skip(i % products.Count)
                .First();

            var orderProduct = new OrderProductBuilder()
                .WithOrder(orders[i].Id)
                .WithProduct(product.Id)
                .Build();

            await context.AddAsync(orderProduct, cancellationToken);
        }

        await context.SaveChangesAsync(cancellationToken);
    }
}