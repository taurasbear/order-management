namespace OrderManagement.Application.Features.ProductFeatures.GetAllProducts;

public sealed record GetAllProductsResponse
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public double Discount { get; set; }

    public int MinDiscountCount { get; set; }
}