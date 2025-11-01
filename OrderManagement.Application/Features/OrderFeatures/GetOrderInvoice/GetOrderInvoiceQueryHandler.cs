using MediatR;
using OrderManagement.Application.Interfaces.Data;
using OrderManagement.Application.Interfaces.Services;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Features.OrderFeatures.GetOrderInvoice;

public class GetOrderInvoiceQueryHandler(
    IRepository repository,
    IOrderInvoiceService orderInvoiceService) : IRequestHandler<GetOrderInvoiceQuery, GetOrderInvoiceResponse>
{
    public async Task<GetOrderInvoiceResponse> Handle(GetOrderInvoiceQuery request, CancellationToken cancellationToken)
    {
        var order = await repository.GetByIdAsync<Order>(request.Id, cancellationToken);

        var response = orderInvoiceService.GenerateOrderInvoice(order);

        return response;
    }
}