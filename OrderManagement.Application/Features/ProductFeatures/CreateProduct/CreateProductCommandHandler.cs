using AutoMapper;
using MediatR;
using OrderManagement.Application.Interfaces.Data;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Features.ProductFeatures.CreateProduct;

public class CreateProductCommandHandler(IRepository repository, IMapper mapper) : IRequestHandler<CreateProductCommand>
{
    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request);

        await repository.CreateAsync(product, cancellationToken);
        await repository.SaveChangesAsync(cancellationToken);

        return;
    }
}