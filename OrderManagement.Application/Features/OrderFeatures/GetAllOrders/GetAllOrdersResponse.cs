namespace OrderManagement.Application.Features.OrderFeatures.GetAllOrders;

public sealed record GetAllOrdersResponse
{
    public Guid Id { get; set; }

    public List<OrderProduct> Products { get; set; } = [];

    public sealed class OrderProduct
    {
        public int Quantity { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}