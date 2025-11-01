using MediatR;

namespace OrderManagement.Application.Features.OrderFeatures.GetOrderInvoice;

public sealed record GetOrderInvoiceQuery : IRequest<GetOrderInvoiceResponse>
{
    public Guid Id { get; set; }
}