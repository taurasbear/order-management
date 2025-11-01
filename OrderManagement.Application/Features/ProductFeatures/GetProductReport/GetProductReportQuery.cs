using MediatR;

namespace OrderManagement.Application.Features.ProductFeatures.GetProductReport;

public sealed record GetProductReportQuery : IRequest<GetProductReportResponse>
{
    public Guid Id { get; set; }
}