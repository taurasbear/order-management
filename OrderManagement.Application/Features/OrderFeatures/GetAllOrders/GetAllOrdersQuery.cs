using MediatR;

namespace OrderManagement.Application.Features.OrderFeatures.GetAllOrders;

public sealed record GetAllOrdersQuery : IRequest<IEnumerable<GetAllOrdersResponse>>;