namespace OrderManagement.Domain.Entities;

public class OrderProduct : BaseEntity
{
    public int Quantity { get; set; }

    public Guid OrderId { get; set; }

    public Order Order { get; set; } = null!;

    public Guid ProductId { get; set; }

    public Product Product { get; set; } = null!;
}