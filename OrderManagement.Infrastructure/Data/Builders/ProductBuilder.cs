using Bogus;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure.Data.Builders;

public class ProductBuilder
{
    private readonly Faker<Product> _faker;

    public ProductBuilder()
    {
        _faker = new Faker<Product>()
            .RuleFor(product => product.Id, faker => faker.Random.Guid())
            .RuleFor(product => product.Name, faker => faker.Commerce.ProductName())
            .RuleFor(product => product.Price, faker => Math.Round(faker.Random.Decimal(100, 5000), 2))
            .RuleFor(product => product.Discount, faker => faker.Random.Int(0, 50))
            .RuleFor(product => product.MinDiscountCount, faker => faker.Random.Int(0, 4));
    }

    public List<Product> Build(int count) => _faker.Generate(count);
}