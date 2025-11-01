using Bogus;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure.Data.Builders;

public class OrderProductBuilder
{
    private readonly Faker<OrderProduct> _faker;

    public OrderProductBuilder()
    {
        _faker = new Faker<OrderProduct>()
            .RuleFor(Order => Order.Id, faker => faker.Random.Guid())
            .RuleFor(Order => Order.Quantity, faker => faker.Random.Int(1, 5));
    }

    public OrderProductBuilder WithProduct(Guid productId)
    {
        _faker.RuleFor(orderProduct => orderProduct.ProductId, productId);
        return this;
    }

    public OrderProductBuilder WithOrder(Guid orderId)
    {
        _faker.RuleFor(orderProduct => orderProduct.OrderId, orderId);
        return this;
    }

    public OrderProduct Build() => _faker.Generate();
}