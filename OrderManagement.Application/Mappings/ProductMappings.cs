using AutoMapper;
using OrderManagement.Application.Features.ProductFeatures.CreateProduct;
using OrderManagement.Application.Features.ProductFeatures.GetAllProducts;
using OrderManagement.Application.Features.ProductFeatures.GetProductReport;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Mappings;

public class ProductMappings : Profile
{
    public ProductMappings()
    {
        CreateMap<Product, GetAllProductsResponse>();

        CreateMap<CreateProductCommand, Product>();
    }
}