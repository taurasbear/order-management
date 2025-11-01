using MediatR;

namespace OrderManagement.Application.Features.OrderFeatures.CreateOrder;

public sealed record CreateOrderCommand : IRequest
{
    public ICollection<OrderProduct> OrderProducts { get; set; } = [];

    public sealed class OrderProduct
    {
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
    }
}