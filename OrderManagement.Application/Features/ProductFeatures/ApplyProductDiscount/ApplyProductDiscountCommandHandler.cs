using MediatR;
using OrderManagement.Application.Interfaces.Data;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Features.ProductFeatures.ApplyProductDiscount;

public class ApplyProductDiscountCommandHandler(IRepository repository) : IRequestHandler<ApplyProductDiscountCommand>
{
    public async Task Handle(ApplyProductDiscountCommand request, CancellationToken cancellationToken)
    {
        var product = await repository.GetByIdAsync<Product>(request.Id, cancellationToken);

        product.Discount = request.Discount;
        product.MinDiscountCount = request.MinDiscountCount;

        await repository.SaveChangesAsync(cancellationToken);

        return;
    }
}