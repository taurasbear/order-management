using AutoMapper;
using MediatR;
using OrderManagement.Application.Interfaces.Data;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Features.OrderFeatures.GetAllOrders;

public class GetAllOrdersQueryHandler(IRepository repository, IMapper mapper) : IRequestHandler<GetAllOrdersQuery, IEnumerable<GetAllOrdersResponse>>
{
    public async Task<IEnumerable<GetAllOrdersResponse>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        var orders = await repository.GetAllAsync<Order>(cancellationToken);

        var response = mapper.Map<IEnumerable<GetAllOrdersResponse>>(orders);

        return response;
    }
}