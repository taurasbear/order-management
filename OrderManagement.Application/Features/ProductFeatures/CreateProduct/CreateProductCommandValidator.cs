using FluentValidation;

namespace OrderManagement.Application.Features.ProductFeatures.CreateProduct;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(command => command.Name)
            .NotEmpty()
            .WithMessage("Product name cannot be blank.");

        RuleFor(command => command.Price)
            .GreaterThan(0)
            .WithMessage("Product price must be more than 0.")
            .Must(price => decimal.Round(price, 2) == price)
            .WithMessage("Product price must have at most 2 decimal places.");
    }
}