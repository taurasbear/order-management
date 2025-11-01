using FluentValidation;

namespace OrderManagement.Application.Features.ProductFeatures.ApplyProductDiscount;

public class ApplyProductDiscountCommandValidator : AbstractValidator<ApplyProductDiscountCommand>
{
    public ApplyProductDiscountCommandValidator()
    {
        RuleFor(command => command.Discount)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Discount must not be negative.");

        RuleFor(command => command.MinDiscountCount)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum count for discount must not be negative.");
    }
}