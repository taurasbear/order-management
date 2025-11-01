using Microsoft.AspNetCore.Mvc;

namespace OrderManagement.Server.Controllers;

public class ProductController : BaseController
{
    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        return Ok(new { Name = "Laptop", Price = "5000" });
    }
}
