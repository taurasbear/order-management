namespace OrderManagement.Domain.Entities;

public class Order : BaseEntity
{
    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = [];
}