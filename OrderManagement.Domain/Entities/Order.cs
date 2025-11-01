namespace OrderManagement.Domain.Entities;

public class Order : BaseEntity
{
    public ICollection<OrderProduct> OrderProducts { get; set; } = [];
}