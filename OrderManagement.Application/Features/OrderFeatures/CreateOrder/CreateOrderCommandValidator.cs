using FluentValidation;

namespace OrderManagement.Application.Features.OrderFeatures.CreateOrder;

public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator()
    {
        RuleFor(command => command.OrderProducts)
            .NotEmpty()
            .WithMessage("Order must contain at least one product.");

        RuleForEach(command => command.OrderProducts)
            .ChildRules(orderProduct =>
            {
                orderProduct.RuleFor(op => op.ProductId)
                    .NotEmpty()
                    .WithMessage("Product Id is required.");

                orderProduct.RuleFor(op => op.Quantity)
                    .GreaterThan(0)
                    .WithMessage("Quantity must be more than 0.");
            });
    }
}