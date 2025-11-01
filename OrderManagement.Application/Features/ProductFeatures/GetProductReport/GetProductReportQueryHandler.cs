using MediatR;
using OrderManagement.Application.Interfaces.Data;
using OrderManagement.Application.Interfaces.Services;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Features.ProductFeatures.GetProductReport;

public class GetProductReportQueryHandler(
    IRepository repository,
    IProductReportService productReportService) : IRequestHandler<GetProductReportQuery, GetProductReportResponse>
{
    public async Task<GetProductReportResponse> Handle(GetProductReportQuery request, CancellationToken cancellationToken)
    {
        var product = await repository.GetByIdAsync<Product>(request.Id, cancellationToken);

        var response = productReportService.GenerateProductReport(product);
        return response;
    }
}