using Bogus;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure.Data.Builders;

public class OrderBuilder
{
    private readonly Faker<Order> _faker;

    public OrderBuilder()
    {
        _faker = new Faker<Order>()
            .RuleFor(Order => Order.Id, faker => faker.Random.Guid());
    }

    public List<Order> Build(int count) => _faker.Generate(count);
}