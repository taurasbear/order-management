using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Entities;
using OrderManagement.Infrastructure.Data.Builders;
using OrderManagement.Infrastructure.Data.DatabaseContext;
using OrderManagement.Infrastructure.Interfaces;

namespace OrderManagement.Infrastructure.Data.Seeders;

public class ProductSeeder(OrderContext context) : IDevelopmentSeeder
{
    public async Task SeedAsync(CancellationToken cancellationToken)
    {
        if (await context.Set<Product>().AnyAsync(cancellationToken))
        {
            return;
        }

        var products = new ProductBuilder()
            .Build(3);

        await context.AddRangeAsync(products, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}