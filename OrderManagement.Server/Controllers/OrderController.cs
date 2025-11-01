using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Application.Features.OrderFeatures.CreateOrder;
using OrderManagement.Application.Features.OrderFeatures.GetAllOrders;
using OrderManagement.Application.Features.OrderFeatures.GetOrderInvoice;

namespace OrderManagement.Server.Controllers;

public class OrderController(IMediator mediator) : BaseController
{
    [HttpGet]
    public async Task<ActionResult<GetAllOrdersResponse>> GetAll(CancellationToken cancellationToken)
    {
        var query = new GetAllOrdersQuery();
        var response = await mediator.Send(query, cancellationToken);

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateOrderCommand command, CancellationToken cancellationToken)
    {
        await mediator.Send(command, cancellationToken);

        return Created();
    }

    [HttpGet]
    public async Task<ActionResult<GetOrderInvoiceResponse>> GetInvoice([FromQuery] GetOrderInvoiceQuery query, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(query, cancellationToken);

        return Ok(response);
    }
}