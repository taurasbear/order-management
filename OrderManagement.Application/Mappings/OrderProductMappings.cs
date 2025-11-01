using AutoMapper;
using OrderManagement.Application.Features.OrderFeatures.CreateOrder;
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

        CreateMap<CreateOrderCommand.OrderProduct, OrderProduct>()
            .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId));
    }
}