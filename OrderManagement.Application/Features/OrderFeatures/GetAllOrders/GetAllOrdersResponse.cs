namespace OrderManagement.Application.Features.OrderFeatures.GetAllOrders;

public sealed record GetAllOrdersResponse
{
    public Guid Id { get; set; }

    public List<Product> Products { get; set; } = [];

    public sealed class Product
    {
        public int Quantity { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}