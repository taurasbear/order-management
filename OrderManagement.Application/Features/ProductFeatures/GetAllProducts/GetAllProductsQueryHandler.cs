using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Application.Interfaces.Data;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Features.ProductFeatures.GetAllProducts;

public class GetAllProductsQueryHandler(IRepository repository, IMapper mapper) : IRequestHandler<GetAllProductsQuery, IEnumerable<GetAllProductsResponse>>
{
    public async Task<IEnumerable<GetAllProductsResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await repository.AsQueryable<Product>()
            .Where(product => request.Name == null || product.Name.ToLower() == request.Name.ToLower())
            .ToListAsync(cancellationToken);

        var response = mapper.Map<IEnumerable<GetAllProductsResponse>>(products);

        return response;
    }
}