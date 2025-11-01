using AutoMapper;
using OrderManagement.Application.Features.ProductFeatures.GetAllProducts;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Mappings;

public class ProductMappings : Profile
{
    public ProductMappings()
    {
        CreateMap<Product, GetAllProductsResponse>();
    }
}