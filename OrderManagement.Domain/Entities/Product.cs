namespace OrderManagement.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public double Discount { get; set; }

    public int MinDiscountCount { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = [];
}