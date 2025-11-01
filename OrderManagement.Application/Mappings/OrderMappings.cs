using AutoMapper;
using OrderManagement.Application.Features.OrderFeatures.GetAllOrders;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Mappings;

public class OrderMappings : Profile
{
    public OrderMappings()
    {
        CreateMap<Order, GetAllOrdersResponse>()
            .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.OrderProducts));
    }
}