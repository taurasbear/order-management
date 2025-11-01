using OrderManagement.Application.Features.ProductFeatures.GetProductReport;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Interfaces.Services;

public interface IProductReportService
{
    public GetProductReportResponse GenerateProductReport(Product product);
}