using AutoMapper;
using MediatR;
using OrderManagement.Application.Interfaces.Data;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Features.OrderFeatures.CreateOrder;

public class CreateOrderCommandHandler(IRepository repository, IMapper mapper) : IRequestHandler<CreateOrderCommand>
{
    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Order();
        foreach (var requestOrderProduct in request.OrderProducts)
        {
            var orderProduct = mapper.Map<OrderProduct>(requestOrderProduct);
            order.OrderProducts.Add(orderProduct);
        }

        await repository.CreateAsync(order, cancellationToken);
        await repository.SaveChangesAsync(cancellationToken);
    }
}