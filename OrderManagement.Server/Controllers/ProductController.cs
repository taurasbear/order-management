using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Application.Features.ProductFeatures.CreateProduct;
using OrderManagement.Application.Features.ProductFeatures.GetAllProducts;

namespace OrderManagement.Server.Controllers;

public class ProductController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<ActionResult<GetAllProductsResponse>> GetAll([FromQuery] GetAllProductsQuery query, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(query, cancellationToken);

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductCommand command, CancellationToken cancellationToken)
    {
        await mediator.Send(command, cancellationToken);
        return Created();
    }
}
