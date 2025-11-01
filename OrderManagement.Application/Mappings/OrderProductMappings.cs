using AutoMapper;
using OrderManagement.Application.Features.OrderFeatures.GetAllOrders;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Mappings;

public class OrderProductMappings : Profile
{
    public OrderProductMappings()
    {
        CreateMap<OrderProduct, GetAllOrdersResponse.Product>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Product.Name))
            .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity));
    }
}