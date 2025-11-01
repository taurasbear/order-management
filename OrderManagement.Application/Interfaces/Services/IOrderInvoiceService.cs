using OrderManagement.Application.Features.OrderFeatures.GetOrderInvoice;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Interfaces.Services;

public interface IOrderInvoiceService
{
    public GetOrderInvoiceResponse GenerateOrderInvoice(Order order);
}