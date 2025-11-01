
namespace OrderManagement.Application.Features.OrderFeatures.GetOrderInvoice;

public sealed record GetOrderInvoiceResponse
{
    public decimal TotalAmount { get; set; }

    public ICollection<InvoiceLine> Products { get; set; } = [];

    public sealed class InvoiceLine
    {
        public string Name { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public double Discount { get; set; }

        public decimal Amount { get; set; }
    }
}