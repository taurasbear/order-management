using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure.Data.DatabaseContext;

public class OrderContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderProduct> OrderProducts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderProduct>()
            .HasOne(orderProduct => orderProduct.Order)
            .WithMany(order => order.OrderProducts)
            .HasForeignKey(orderProduct => orderProduct.OrderId);

        modelBuilder.Entity<OrderProduct>()
            .HasOne(orderProduct => orderProduct.Product)
            .WithMany(product => product.OrderProducts)
            .HasForeignKey(orderProduct => orderProduct.ProductId);
    }
}