using MediatR;

namespace OrderManagement.Application.Features.ProductFeatures.ApplyProductDiscount;

public sealed record ApplyProductDiscountCommand : IRequest
{
    public Guid Id { get; set; }

    public double Discount { get; set; }

    public int MinDiscountCount { get; set; }
}