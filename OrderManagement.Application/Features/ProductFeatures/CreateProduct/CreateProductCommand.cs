using MediatR;

namespace OrderManagement.Application.Features.ProductFeatures.CreateProduct;

public sealed record CreateProductCommand : IRequest
{
    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }
}