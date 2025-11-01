using OrderManagement.Application.Features.OrderFeatures.GetOrderInvoice;
using OrderManagement.Application.Interfaces.Services;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Services;

public class OrderInvoiceService : IOrderInvoiceService
{
    public GetOrderInvoiceResponse GenerateOrderInvoice(Order order)
    {
        var invoice = new GetOrderInvoiceResponse();

        foreach (var orderProduct in order.OrderProducts)
        {
            var discount = orderProduct.Product.Discount;
            var price = orderProduct.Product.Price;
            var quantity = orderProduct.Quantity;

            var invoiceProduct = new GetOrderInvoiceResponse.InvoiceLine
            {
                Name = orderProduct.Product.Name,
                Quantity = quantity,
                Discount = discount,
                Amount = price * quantity,
            };

            if (quantity >= orderProduct.Product.MinDiscountCount && discount > 0)
            {
                var discountedPrice = price * (1 - ((decimal)discount / 100));
                invoiceProduct.Amount = Math.Round(discountedPrice * quantity, 2);
            }

            invoice.TotalAmount += invoiceProduct.Amount;
            invoice.Products.Add(invoiceProduct);
        }

        return invoice;
    }
}