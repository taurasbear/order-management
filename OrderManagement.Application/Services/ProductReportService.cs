using OrderManagement.Application.Features.ProductFeatures.GetProductReport;
using OrderManagement.Application.Interfaces.Services;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Services;

public class ProductReportService : IProductReportService
{
    public GetProductReportResponse GenerateProductReport(Product product)
    {
        int orderCount = product.OrderProducts.Count;
        decimal totalAmount = 0;

        foreach (var orderProduct in product.OrderProducts)
        {
            var price = product.Price;
            var quantity = orderProduct.Quantity;

            if (quantity >= product.MinDiscountCount && product.Discount > 0)
            {
                var discountedPrice = price * (1 - ((decimal)product.Discount / 100));
                totalAmount += quantity * discountedPrice;
            }
            else
            {
                totalAmount += quantity * price;
            }
        }

        var report = new GetProductReportResponse
        {
            Name = product.Name,
            Discount = product.Discount,
            OrderCount = orderCount,
            TotalAmount = Math.Round(totalAmount, 2),
        };

        return report;
    }
}