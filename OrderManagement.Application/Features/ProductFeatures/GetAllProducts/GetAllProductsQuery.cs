using MediatR;

namespace OrderManagement.Application.Features.ProductFeatures.GetAllProducts;

public sealed record GetAllProductsQuery : IRequest<IEnumerable<GetAllProductsResponse>>
{
    public string? Name { get; set; }
}