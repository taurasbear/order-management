namespace OrderManagement.Application.Features.ProductFeatures.GetProductReport;

public sealed record GetProductReportResponse
{
    public string Name { get; set; } = string.Empty;

    public double Discount { get; set; }

    public int OrderCount { get; set; }

    public decimal TotalAmount { get; set; }
}